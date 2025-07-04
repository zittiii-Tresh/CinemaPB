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
            var lookupBindings = new[]
            {
                new { Control = moviegenreLUE,    Data = (object)_movieRepository.Genres(),         Display = "GenreName",   Value = "GenreID" },
                new { Control = movielanguageLUE, Data = (object)_movieRepository.Languages(),      Display = "LanguageName",Value = "LanguageID" },
                new { Control = movieratingLUE,   Data = (object)_movieRepository.ContentRatings(), Display = "RatingName",  Value = "RatingID" }
            };

            foreach (var binding in lookupBindings.Where(b => ((System.Collections.IEnumerable)b.Data).Cast<object>().Any()))
            {
                var props = binding.Control.Properties;

                props.DataSource = binding.Data;
                props.DisplayMember = binding.Display;
                props.ValueMember = binding.Value;

                // Hide ValueMember column by customizing popup
                props.Columns.Clear(); // Clear auto-generated columns
                props.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(binding.Display)); // Only add display column
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
                GenreID = Convert.ToInt32(moviegenreLUE.EditValue),
                Description = moviedescriptionTE.Text.Trim(), // Optional field
                Duration = dur,
                LanguageID = Convert.ToInt32(movielanguageLUE.EditValue),
                RatingID = Convert.ToInt32(movieratingLUE.EditValue),
                Availability = availabilityTS.IsOn ? 1 : 0,
                Poster = posterPE.Image
            };

            _movieRepository.InsertMovie(movie);
            XtraMessageBox.Show("Movie saved successfully!", "Success");
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
    }
}

