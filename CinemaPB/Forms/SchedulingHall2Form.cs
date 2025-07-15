using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaPB.Configuration;
using CinemaPB.Infrastructure.Repositories;
using DevExpress.XtraEditors;
using CinemaPB.ModelMovie;
using CinemaPB.ModelShowtime;
using System.IO;
using System.Globalization;

namespace CinemaPB.Forms
{
    public partial class SchedulingHall2Form : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ShowtimeRepository _showtimeRepository;

        public SchedulingHall2Form()
        {
            InitializeComponent();
            _showtimeRepository = new ShowtimeRepository(GlobalSetting.GetConnectionString());
            LoadAvailableMovies();
            LoadShowtimeGrid();
        }
        private void LoadAvailableMovies()
        {
            var availableMovies = _showtimeRepository.GetAvailableMovies();

            if (availableMovies.Any())
            {
                availablemovieLUE.Properties.DataSource = availableMovies;
                availablemovieLUE.Properties.DisplayMember = "Title";      // or any readable name
                availablemovieLUE.Properties.ValueMember = "MovieID";      // the ID you'll use internally

                // Optional: Hide the ID column in popup
                availablemovieLUE.Properties.Columns.Clear();
                availablemovieLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Movie Title"));
            }
        }

        private void daytypeRG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (availablemovieLUE.EditValue == null || showdateDE.EditValue == null || starttimeTE.EditValue == null)
            {
                XtraMessageBox.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            int movieId = Convert.ToInt32(availablemovieLUE.EditValue);
            DateTime showDate = Convert.ToDateTime(showdateDE.EditValue);
            TimeSpan startTime = starttimeTE.Time.TimeOfDay;

            // Fetch duration of the selected movie
            var movieList = availablemovieLUE.Properties.DataSource as List<MovieWithDetail>;
            var selectedMovie = movieList?.FirstOrDefault(m => m.MovieID == movieId);
            if (selectedMovie == null)
            {
                XtraMessageBox.Show("Selected movie not found.", "Error");
                return;
            }

            TimeSpan duration = TimeSpan.TryParse(selectedMovie.Duration, out var dur)
                                ? dur : TimeSpan.Zero;
            TimeSpan endTime = startTime.Add(duration);

            // Determine DayType
            string dayType = (showDate.DayOfWeek == DayOfWeek.Saturday || showDate.DayOfWeek == DayOfWeek.Sunday)
                             ? "Weekend" : "Weekday";

            // Get MoviePriceID
            int moviePriceId = _showtimeRepository.GetMoviePriceID(movieId, dayType);

            // Insert Showtime
            //_showtimeRepository.InsertShowtime(movieId, hallId: 2, showDate, startTime, endTime, moviePriceId);

            LoadShowtimeGrid();

            XtraMessageBox.Show("Showtime successfully scheduled!", "Success");
        }
        private void LoadShowtimeGrid()
        {
            int hallId = 2;
            //var showtimes = _showtimeRepository.GetAllShowtimes();
            showtime2GC.DataSource = _showtimeRepository.GetAllShowtimes(hallId); // bind the list

        }

        private void showtime2GV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedShowtime = showtime2GV.GetFocusedRow() as ShowtimeDetail;
            if (selectedShowtime == null)
            {
                XtraMessageBox.Show("Please select a valid showtime.", "Error");
                return;
            }

            // 1. Set display labels
            movienameLBL.Text = selectedShowtime.Title;
            showdateLBL.Text = selectedShowtime.ShowDate.ToString("MMMM dd, yyyy");
            timeslotLBL.Text = $"{selectedShowtime.StartTimeFormatted} - {selectedShowtime.EndTimeFormatted}";
            priceLBL.Text = selectedShowtime.Price.ToString("N2");

            // 2. Set input controls (for editing)
            availablemovieLUE.EditValue = selectedShowtime.MovieID; // Optional helper if you need MovieID
            showdateDE.DateTime = selectedShowtime.ShowDate;
            starttimeTE.Time = DateTime.Today.Add(selectedShowtime.StartTime);

            // 3. Set RadioGroup for DayType
            daytypeRG.SelectedIndex = selectedShowtime.DayType == "Weekday" ? 1 : 0;

            // 4. Load poster
            if (selectedShowtime.Poster != null)
            {
                using (var ms = new MemoryStream(selectedShowtime.Poster))
                {
                    posterPE.Image = Image.FromStream(ms);
                }
            }
            else
            {
                posterPE.Image = null;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
