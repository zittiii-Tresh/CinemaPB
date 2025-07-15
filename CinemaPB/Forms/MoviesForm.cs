using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaPB.Configuration;
using CinemaPB.Infrastructure.Repositories;
using CinemaPB.ModelMovie;
using DevExpress.XtraEditors;
using static DevExpress.Utils.Frames.FrameHelper;
using System.Globalization;
using System.IO;
using DevExpress.XtraEditors.Controls;

namespace CinemaPB.Forms
{
    public partial class MoviesForm : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly MovieRepository _movieRepository;
        public MoviesForm()
        {
            InitializeComponent();
            _movieRepository = new MovieRepository(GlobalSetting.GetConnectionString());
            LoadLookUpEdit();
            LoadMoviesIntoGrid();
            SetupToggleSwitch();

            availabilityTS.Toggled += availabilityTS_Toggled; // 👈 Hook the event
            UpdateAvailabilityLabel();                      // 👈 Set initial state
        }
        private void SetupToggleSwitch()
        {
            availabilityTS.Properties.ValueOff = "Disabled";
            availabilityTS.Properties.ValueOn = "Enabled";
            var a = availabilityTS.Properties.GetValueByState(false); // returns "Disabled"
            var b = availabilityTS.Properties.GetStateByValue("Enabled"); // returns true
            var c = availabilityTS.Properties.GetStateByValue("Activated"); // returns false
        }

        private void LoadLookUpEdit()
        {
            // ✅ Genre: CheckedComboBoxEdit
            var genres = _movieRepository.Genres();
            moviegenreLUE.Properties.Items.Clear();

            // Use LINQ to add items
            genres.ForEach(g => moviegenreLUE.Properties.Items.Add(g.GenreID, g.GenreName));

            // ✅ Language: LookUpEdit
            var languages = _movieRepository.Languages();
            if (languages.Any())
            {
                movielanguageLUE.Properties.DataSource = languages;
                movielanguageLUE.Properties.DisplayMember = "LanguageName";
                movielanguageLUE.Properties.ValueMember = "LanguageID";
                movielanguageLUE.Properties.Columns.Clear();
                movielanguageLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LanguageName"));
            }

            // ✅ Rating: LookUpEdit
            var ratings = _movieRepository.ContentRatings();
            if (ratings.Any())
            {
                movieratingLUE.Properties.DataSource = ratings;
                movieratingLUE.Properties.DisplayMember = "RatingName";
                movieratingLUE.Properties.ValueMember = "RatingID";
                movieratingLUE.Properties.Columns.Clear();
                movieratingLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RatingName"));
            }
        }


        private void saveBTN_Click(object sender, EventArgs e)
        {
            // ✅ Validate required fields (description is NOT required)
            //if (string.IsNullOrWhiteSpace(movienameTE.Text) ||
            //    moviegenreLUE.EditValue == null ||
            //    string.IsNullOrWhiteSpace(moviedurationTE.Text) ||
            //    movielanguageLUE.EditValue == null ||
            //    movieratingLUE.EditValue == null ||
            //    posterPE.Image == null)
            //{
            //    XtraMessageBox.Show("Please fill in all required fields (except description) and select a poster image.", "Validation Error");
            //    return;
            //}

            // ✅ Parse duration safely
            TimeSpan dur = durationTE.Time.TimeOfDay;

            var movie = new ModelMovie.Movie
            {
                Title = movienameTE.Text.Trim(),
                Description = moviedescriptionTE.Text.Trim(),
                Duration = dur,
                LanguageID = Convert.ToInt32(movielanguageLUE.EditValue),
                RatingID = Convert.ToInt32(movieratingLUE.EditValue),
                Availability = availabilityTS.IsOn ? 1 : 0,
                Poster = posterPE.Image
            };

            // ✅ Insert movie (no GenreID needed here anymore)
            int movieId = _movieRepository.InsertMovie(movie);

            // ✅ Retrieve selected genres from CheckedComboBoxEdit
            var selectedGenreIds = moviegenreLUE.Properties.Items
                .GetCheckedValues()
                .OfType<int>()
                .ToList();

            // ✅ Insert genre links into MovieGenres (junction table)
            foreach (var genreId in selectedGenreIds)
            {
                _movieRepository.InsertMovieGenre(movieId, genreId);
            }

            // ✅ Insert weekday & weekend prices
            decimal weekdayPrice = Convert.ToDecimal(weekdaypriceTE.Text);
            decimal weekendPrice = Convert.ToDecimal(weekendpriceTE.Text);

            _movieRepository.InsertMoviePrice(movieId, "Weekday", weekdayPrice);
            _movieRepository.InsertMoviePrice(movieId, "Weekend", weekendPrice);

            // ✅ Refresh grid
            LoadMoviesIntoGrid();

            XtraMessageBox.Show("Movie, genres, and prices saved successfully!", "Success");
        }


        private void UpdateAvailabilityLabel()
        {
            if (availabilityTS.IsOn)
            {
                availabilityLC.Text = "Available";
                availabilityLC.ForeColor = Color.Green;
            }
            else
            {
                availabilityLC.Text = "Unavailable";
                availabilityLC.ForeColor = Color.Red;
            }
        }

        private void availabilityTS_Toggled(object sender, EventArgs e)
        {
            UpdateAvailabilityLabel();
        }

        private void browseBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        posterPE.Image = Image.FromFile(openFileDialog.FileName);
                        posterPE.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error: " + ex.Message, "Error Loading Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void addgenreBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new InsertGenreForm(_movieRepository, LoadLookUpEdit), LoadLookUpEdit);
        }

        private void addlanguageBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new InsertLanguageForm(_movieRepository, LoadLookUpEdit), LoadLookUpEdit);

        }

        private void LoadMoviesIntoGrid()
        {
            var movies = _movieRepository.GetAllMovieDetails();
            moviesGC.DataSource = movies;
        }

        private void moviesGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (moviesGV.GetFocusedRow() is MovieWithDetail selectedMovie)
            {
                // Title, Description, etc.
                movienameTE.Text = selectedMovie.Title;
                moviedescriptionTE.Text = selectedMovie.Description;

                // Duration assignment with safe parsing
                if (TimeSpan.TryParse(selectedMovie.Duration, out TimeSpan parsedDuration))
                {
                    durationTE.Time = DateTime.Today.Add(parsedDuration);
                }
                else
                {
                    durationTE.Time = DateTime.Today; // fallback
                }

                // Availability
                availabilityTS.IsOn = selectedMovie.Availability == "Available";

                // Language and Rating
                movielanguageLUE.EditValue = selectedMovie.LanguageID;
                movieratingLUE.EditValue = selectedMovie.RatingID;

                // Poster
                using (var ms = new MemoryStream(selectedMovie.Poster))
                {
                    posterPE.Image = Image.FromStream(ms);
                }

                // 🎯 Load genres into CheckedComboBoxEdit
                var allGenres = _movieRepository.Genres();
                var selectedGenreNames = selectedMovie.Genres?.Split(',').Select(g => g.Trim()) ?? Enumerable.Empty<string>();

                moviegenreLUE.Properties.Items.Clear();

                foreach (var genre in allGenres)
                {
                    moviegenreLUE.Properties.Items.Add(genre.GenreID, genre.GenreName);
                }

                foreach (var genre in allGenres)
                {
                    if (selectedGenreNames.Contains(genre.GenreName))
                    {
                        int index = moviegenreLUE.Properties.Items.IndexOf(genre.GenreID);
                        if (index >= 0)
                            moviegenreLUE.Properties.Items[index].CheckState = CheckState.Checked;
                    }
                }


                // Load prices: Weekday and Weekend
                var prices = _movieRepository.GetMoviePrices(selectedMovie.MovieID);
                foreach (var price in prices)
                {
                    if (price.DayType == "Weekday")
                        weekdaypriceTE.Text = price.Price.ToString("0.00"); // format as currency if desired
                    else if (price.DayType == "Weekend")
                        weekendpriceTE.Text = price.Price.ToString("0.00");
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            var selectedMovie = moviesGV.GetFocusedRow() as MovieWithDetail;
            if (selectedMovie == null)
            {
                XtraMessageBox.Show("Please select a valid movie.", "Error");
                return;
            }

            // Get selected genres safely
            var selectedGenresRaw = moviegenreLUE.Properties.GetCheckedItems() as string;
            if (string.IsNullOrWhiteSpace(movienameTE.Text) ||
                string.IsNullOrWhiteSpace(selectedGenresRaw) ||
                string.IsNullOrWhiteSpace(weekdaypriceTE.Text) ||
                string.IsNullOrWhiteSpace(weekendpriceTE.Text) ||
                movielanguageLUE.EditValue == null ||
                movieratingLUE.EditValue == null ||
                posterPE.Image == null)
            {
                XtraMessageBox.Show("Please fill all required fields.");
                return;
            }

            // Parse duration
            if (!TimeSpan.TryParse(durationTE.Time.ToString("HH:mm:ss"), out var dur))
            {
                XtraMessageBox.Show("Invalid duration format.");
                return;
            }

            var movie = new ModelMovie.Movie
            {
                MovieID = selectedMovie.MovieID,
                Title = movienameTE.Text.Trim(),
                Description = moviedescriptionTE.Text.Trim(),
                Duration = dur,
                LanguageID = Convert.ToInt32(movielanguageLUE.EditValue),
                RatingID = Convert.ToInt32(movieratingLUE.EditValue),
                Availability = availabilityTS.IsOn ? 1 : 0,
                Poster = posterPE.Image
            };

            // Save updated movie
            _movieRepository.UpdateMovie(movie);

            // Extract selected genre IDs
            var selectedGenres = moviegenreLUE.Properties.Items
                .Cast<CheckedListBoxItem>()
                .Where(item => item.CheckState == CheckState.Checked)
                .Select(item => Convert.ToInt32(item.Value))
                .ToList();

            _movieRepository.UpdateMovieGenres(movie.MovieID, selectedGenres);

            // Update prices
            decimal weekday = Convert.ToDecimal(weekdaypriceTE.Text);
            decimal weekend = Convert.ToDecimal(weekendpriceTE.Text);
            _movieRepository.UpdateMoviePrice(movie.MovieID, "Weekday", weekday);
            _movieRepository.UpdateMoviePrice(movie.MovieID, "Weekend", weekend);

            LoadMoviesIntoGrid();

            XtraMessageBox.Show("Movie updated successfully!");
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            var selectedMovie = moviesGV.GetFocusedRow() as MovieWithDetail;
            if (selectedMovie == null)
            {
                XtraMessageBox.Show("Please select a movie to delete.");
                return;
            }

            var result = XtraMessageBox.Show("Are you sure you want to delete this movie?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _movieRepository.DeleteMovie(selectedMovie.MovieID);
                LoadMoviesIntoGrid();
                XtraMessageBox.Show("Movie deleted successfully!");
            }
        }
    }
}

