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
    public partial class SchedulingHall1Form : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ShowtimeRepository _showtimeRepository;

        public SchedulingHall1Form()
        {
            InitializeComponent();
            _showtimeRepository = new ShowtimeRepository(GlobalSetting.GetConnectionString());

            LoadAvailableMovies();
            LoadShowtimeGrid();
            ClearAll();
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

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (availablemovieLUE.EditValue == null || showdateDE.EditValue == null)
            {
                XtraMessageBox.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            int movieId = Convert.ToInt32(availablemovieLUE.EditValue);
            DateTime showDate = showdateDE.DateTime;
            int hallId = 1;

            var movieList = availablemovieLUE.Properties.DataSource as List<MovieWithDetail>;
            var selectedMovie = movieList?.FirstOrDefault(m => m.MovieID == movieId);

            if (selectedMovie == null || !TimeSpan.TryParse(selectedMovie.Duration, out var duration))
            {
                XtraMessageBox.Show("Invalid movie selection or duration.", "Error");
                return;
            }
            // Get movie price ID
            string dayType = (showDate.DayOfWeek == DayOfWeek.Saturday || showDate.DayOfWeek == DayOfWeek.Sunday) ? "Weekend" : "Weekday";
            int moviePriceId = _showtimeRepository.GetMoviePriceID(movieId, dayType);

            // 🎫 1. Check how many screenings already exist for this date
            var existingScreenings = _showtimeRepository.GetScreeningsForDate(showDate, hallId); // e.g. [1, 2]
            if (existingScreenings.Count >= 3)
            {
                XtraMessageBox.Show("All 3 screenings are already scheduled for the selected date.", "Validation Error");
                ClearAll();
                return;
            }

            // ⏱ 2. Fetch existing showtime ranges (start-end) for conflict validation
            var existingSlots = _showtimeRepository.GetTimeSlotsForDate(showDate, hallId);

            var startTimes = new List<(TimeEdit Control, int Screening)>
            {
                (starttime1TE, 1),
                (starttime2TE, 2),
                (starttime3TE, 3)
            };

            int insertedCount = 0;

            foreach (var (control, screening) in startTimes)
            {
                if (control.EditValue == null)
                    continue;

                // ⛔ 3. Skip screening if already used
                if (existingScreenings.Contains(screening))
                {
                    XtraMessageBox.Show($"Screening {screening} already exists. Please choose a vacant screening.", "Validation Error");
                    ClearAll();
                    continue;
                }

                TimeSpan startTime = control.Time.TimeOfDay;
                TimeSpan endTime = startTime.Add(duration);

                // ⛔ 4. Overlap check
                bool overlaps = existingSlots.Any(slot =>
                    (startTime < slot.EndTime && endTime > slot.StartTime));

                if (overlaps)
                {
                    XtraMessageBox.Show($"Screening {screening} time overlaps with an existing showtime.", "Overlap Conflict");
                    ClearAll();
                    continue;
                }

                // ✅ 5. Passed all validation, insert it
                _showtimeRepository.InsertShowtime(movieId, hallId, showDate, startTime, endTime, moviePriceId, screening);
                insertedCount++;
            }

            LoadShowtimeGrid();

            if (insertedCount > 0)
            {
                XtraMessageBox.Show($"Successfully scheduled {insertedCount} showtime(s).", "Success");
                ClearAll();
            }
            else
            {
                XtraMessageBox.Show("No showtimes were scheduled due to conflicts or limits.", "Notice");
            }
        }



        private void LoadShowtimeGrid()
        {
            int hallId = 1;
            //var showtimes = _showtimeRepository.GetAllShowtimes();
            showtime1GC.DataSource = _showtimeRepository.GetAllShowtimes(hallId); // bind the list

        }

        private void showtime1GV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedShowtime = showtime1GV.GetFocusedRow() as ShowtimeDetail;
            if (selectedShowtime == null)
            {
                XtraMessageBox.Show("Please select a valid showtime.", "Error");
                return;
            }
            ClearAll();
            // 🔹 Display labels
            movienameLBL.Text = selectedShowtime.Title;
            showdateLBL.Text = selectedShowtime.ShowDate.ToString("MMMM dd, yyyy");
            timeslotLBL.Text = $"{selectedShowtime.StartTimeFormatted} - {selectedShowtime.EndTimeFormatted}";
            priceLBL.Text = selectedShowtime.Price.ToString("N2");

            // 🔹 Set LookUpEdit & DateEdit
            availablemovieLUE.EditValue = selectedShowtime.MovieID;
            showdateDE.DateTime = selectedShowtime.ShowDate;

            posterPE.Image = null;

            // 🔹 Set only the active one
            TimeSpan startTime = selectedShowtime.StartTime;
            DateTime formattedTime = DateTime.Today.Add(startTime);
            switch (selectedShowtime.Screening)
            {
                case 1:
                    starttime1TE.Time = formattedTime;
                    break;
                case 2:
                    starttime2TE.Time = formattedTime;
                    break;
                case 3:
                    starttime3TE.Time = formattedTime;
                    break;
            }

            // 🔹 Load poster
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
            var selectedShowtime = showtime1GV.GetFocusedRow() as ShowtimeDetail;
            if (selectedShowtime == null)
            {
                XtraMessageBox.Show("Please select a showtime to update.", "Error");
                return;
            }

            if (availablemovieLUE.EditValue == null || showdateDE.EditValue == null)
            {
                XtraMessageBox.Show("Please fill in all required fields.", "Validation Error");
                return;
            }

            int movieId = Convert.ToInt32(availablemovieLUE.EditValue);
            DateTime showDate = showdateDE.DateTime;
            int hallId = 1;
            int screening = selectedShowtime.Screening;

            // Determine new StartTime based on selected screening
            TimeSpan? newStartTime = null;
            switch (screening)
            {
                case 1:
                    if (starttime1TE.EditValue == null)
                    {
                        XtraMessageBox.Show("Start Time 1 is required.", "Validation Error");
                        return;
                    }
                    newStartTime = starttime1TE.Time.TimeOfDay;
                    break;

                case 2:
                    if (starttime2TE.EditValue == null)
                    {
                        XtraMessageBox.Show("Start Time 2 is required.", "Validation Error");
                        return;
                    }
                    newStartTime = starttime2TE.Time.TimeOfDay;
                    break;

                case 3:
                    if (starttime3TE.EditValue == null)
                    {
                        XtraMessageBox.Show("Start Time 3 is required.", "Validation Error");
                        return;
                    }
                    newStartTime = starttime3TE.Time.TimeOfDay;
                    break;

                default:
                    XtraMessageBox.Show("Invalid screening value.", "Error");
                    return;
            }

            var movieList = availablemovieLUE.Properties.DataSource as List<MovieWithDetail>;
            var selectedMovie = movieList?.FirstOrDefault(m => m.MovieID == movieId);

            if (selectedMovie == null || !TimeSpan.TryParse(selectedMovie.Duration, out var duration))
            {
                XtraMessageBox.Show("Unable to retrieve movie duration.", "Error");
                return;
            }

            TimeSpan newEndTime = newStartTime.Value.Add(duration);

            // Check for time overlaps (exclude current ShowtimeID)
            var existingSlots = _showtimeRepository
                .GetTimeSlotsForDate(showDate, hallId)
                .Where(slot =>
                    !(slot.StartTime == selectedShowtime.StartTime && slot.EndTime == selectedShowtime.EndTime) // skip current
                ).ToList();

            bool overlaps = existingSlots.Any(slot => (newStartTime < slot.EndTime && newEndTime > slot.StartTime));

            if (overlaps)
            {
                XtraMessageBox.Show("This updated time overlaps with an existing showtime.", "Conflict");
                return;
            }

            // Get correct MoviePriceID
            string dayType = (showDate.DayOfWeek == DayOfWeek.Saturday || showDate.DayOfWeek == DayOfWeek.Sunday)
                             ? "Weekend" : "Weekday";

            int moviePriceId;
            try
            {
                moviePriceId = _showtimeRepository.GetMoviePriceID(movieId, dayType);
            }
            catch
            {
                XtraMessageBox.Show("Movie price not found for the selected day type.", "Error");
                return;
            }

            // Proceed with update
            _showtimeRepository.UpdateShowtime(
                selectedShowtime.ShowtimeID,
                showDate,
                newStartTime.Value,
                newEndTime,
                moviePriceId,
                screening
            );

            LoadShowtimeGrid();
            ClearAll();

            XtraMessageBox.Show("Showtime updated successfully!", "Success");
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            var selectedShowtime = showtime1GV.GetFocusedRow() as ShowtimeDetail;
            if (selectedShowtime == null)
            {
                XtraMessageBox.Show("Please select a valid showtime to delete.", "Error");
                return;
            }

            var confirm = XtraMessageBox.Show("Are you sure you want to delete this showtime?", "Confirm Delete",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _showtimeRepository.DeleteShowtime(selectedShowtime.ShowtimeID);
                LoadShowtimeGrid();
                XtraMessageBox.Show("Showtime deleted successfully.", "Deleted");
            }
        }
        private void ClearAll()
        {
            // Clear TimeEdits
            starttime1TE.EditValue = null;
            starttime2TE.EditValue = null;
            starttime3TE.EditValue = null;

            // Clear selection inputs
            availablemovieLUE.EditValue = null;
            showdateDE.EditValue = null;
        }

        private void ClearLabelandPoster()
        {
            movienameLBL.Text = string.Empty;
            showdateLBL.Text = string.Empty;
            timeslotLBL.Text = string.Empty;
            priceLBL.Text = string.Empty;
            posterPE.Image = null;
        }


        //private void repositoryItemButtonEditUpdate_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    ButtonEdit editor = (ButtonEdit)sender;
        //    int buttonIndex = editor.Properties.Buttons.IndexOf(e.Button);

        //    if (buttonIndex == 0)
        //    {
        //        // edit function
        //    }
        //    else
        //    {
        //        // delete function
        //    }
        //}
    }
}
