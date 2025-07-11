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

namespace CinemaPB.Forms
{
    public partial class SchedulingHall1Form : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ShowtimeRepository _showtimeRepository;

        public SchedulingHall1Form()
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
                                ? dur  : TimeSpan.Zero;
            TimeSpan endTime = startTime.Add(duration);

            // Determine DayType
            string dayType = (showDate.DayOfWeek == DayOfWeek.Saturday || showDate.DayOfWeek == DayOfWeek.Sunday)
                             ? "Weekend" : "Weekday";

            // Get MoviePriceID
            int moviePriceId = _showtimeRepository.GetMoviePriceID(movieId, dayType);

            // Insert Showtime
            _showtimeRepository.InsertShowtime(movieId, hallId: 1, showDate, startTime, endTime, moviePriceId);

            LoadShowtimeGrid();

            XtraMessageBox.Show("Showtime successfully scheduled!", "Success");
        }
        private void LoadShowtimeGrid()
        {
            //var showtimes = _showtimeRepository.GetAllShowtimes();
            showtime1GC.DataSource = _showtimeRepository.GetAllShowtimes(); // bind the list

        }
    }
}
