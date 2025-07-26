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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Dapper;
using CinemaPB.ModelShowing;
using System.IO;
using CinemaPB.ModelShowtime;

namespace CinemaPB.Forms
{
    public partial class ReserveSeatsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly TicketRepository _ticketRepository;
        private readonly SeatRepository _seatRepository;
        private List<SimpleButton> seatButtons;
        private readonly ShowingCard _showing;
        private const int HallID = 1; // You can pass dynamically later if needed

        public ReserveSeatsForm(ShowingCard showing)
        {
            InitializeComponent();
            _seatRepository = new SeatRepository(GlobalSetting.GetConnectionString());
            _ticketRepository = new TicketRepository(GlobalSetting.GetConnectionString());
            _showing = showing;
            InitializeShowtimeSeats(); // ✅ Load initial seat states

            EnsureShowtimeSeatsExist(_showing.ShowtimeID, HallID);
            LoadSeatButtons();
            LoadSeatStatus();

            movienameLBL.Text = _showing.Title;
            durationLBL.Text = _showing.Duration;
            showtimeLBL.Text = _showing.Timeslot;
            screeningLBL.Text = _showing.ScreeningLabel;
            moviegenreLBL.Text = _showing.Genres;
            posterPE.Image = _showing.PosterImage;
            movieratingLBL.Text = _showing.RatingName;
        }

        private void EnsureShowtimeSeatsExist(int showtimeId, int hallId)
        {
            using (var connection = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                connection.Open();

                var checkCmd = new SqlCommand("SELECT COUNT(*) FROM ShowtimeSeats WHERE ShowtimeID = @ShowtimeID", connection);
                checkCmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    var insertCmd = new SqlCommand(@"
                    INSERT INTO ShowtimeSeats (ShowtimeID, SeatID, SeatStatusID)
                    SELECT @ShowtimeID, SeatID, 1 FROM Seats WHERE HallID = @HallID
                ", connection);

                    insertCmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                    insertCmd.Parameters.AddWithValue("@HallID", hallId);
                    insertCmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void LoadSeatButtons()
        {
            seatButtons = seatPanel.Controls.OfType<SimpleButton>()
                .Where(b => !string.IsNullOrEmpty(b.Name) && char.IsLetter(b.Name[0]) && char.IsDigit(b.Name[1]))
                .ToList();

            foreach (var btn in seatButtons)
            {
                btn.Click += SeatButton_Click;
            }
        }

        private void LoadSeatStatus()
        {
            var existing = _seatRepository.CheckIfShowtimeSeatsExist(_showing.ShowtimeID);
            if (!existing)
            {
                // Insert from dbo.Seats into ShowtimeSeats
                var seats = _seatRepository.GetSeatsByHall(_showing.HallID);

                foreach (var seat in seats)
                {
                    int statusId = (seat.IsAvailable == 0) ? 1 : 4; // 1 = Available, 4 = Unavailable

                    _seatRepository.InsertShowtimeSeat(new ShowtimeSeat
                    {
                        ShowtimeID = _showing.ShowtimeID,
                        SeatID = seat.SeatID,
                        SeatStatusID = statusId
                    });
                }
            }

            // Now load the seat statuses from ShowtimeSeats
            var showtimeSeats = _seatRepository.GetSeatsByShowtime(_showing.ShowtimeID);

            foreach (var seat in showtimeSeats)
            {
                var btn = seatButtons.FirstOrDefault(b => b.Name == seat.SeatNumber);
                if (btn != null)
                {
                    if (seat.SeatStatusID == 1)
                    {
                        btn.Appearance.BackColor = Color.FromArgb(0, 126, 65); // Available
                        btn.Enabled = true;
                        toolTipController1.SetToolTip(btn, "Available");
                    }
                    else if (seat.SeatStatusID == 2)
                    {
                        btn.Appearance.BackColor = Color.FromArgb(90, 144, 255); // Reserved
                        btn.Enabled = true;
                        toolTipController1.SetToolTip(btn, "Reserved");
                    }
                    else if (seat.SeatStatusID == 3)
                    {
                        btn.Appearance.BackColor = Color.FromArgb(240, 101, 101); // Sold
                        btn.Enabled = false;
                        toolTipController1.SetToolTip(btn, "Sold");
                    }
                    else if (seat.SeatStatusID == 4)
                    {
                        btn.Appearance.BackColor = Color.FromArgb(160, 106, 13); // Unavailable
                        btn.Enabled = false;
                        toolTipController1.SetToolTip(btn, "Unavailable");
                    }
                    else
                    {
                        btn.Appearance.BackColor = Color.Gray;
                        btn.Enabled = false;
                        toolTipController1.SetToolTip(btn, "Unknown status");
                    }
                }
            }

        }

        private void UpdateSeatStatus(int showtimeId, string seatNumber, int newStatus)
        {
            using (var connection = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                connection.Open();

                var cmd = new SqlCommand(@"
                UPDATE ShowtimeSeats
                SET SeatStatusID = @Status
                WHERE ShowtimeID = @ShowtimeID AND SeatID = (
                    SELECT SeatID FROM Seats WHERE SeatNumber = @SeatNumber AND HallID = @HallID
                )
            ", connection);

                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                cmd.Parameters.AddWithValue("@HallID", HallID);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            var btn = sender as SimpleButton;
            if (btn == null) return;

            var prompt = new SeatActionPromptForm(btn.Name);
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (prompt.SelectedAction == "Buy")
                {
                    int seatId = _seatRepository.GetSeatIDBySeatNumberAndHall(btn.Name, _showing.HallID);

                    if (_showing == null)
                    {
                        XtraMessageBox.Show("Showing data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 1. Insert or update ShowtimeSeats table
                    bool updated = _seatRepository.UpdateSeatStatus(_showing.ShowtimeID, seatId, 3); // 3 = Sold


                    if (updated)
                    {
                        btn.Appearance.BackColor = Color.FromArgb(240, 101, 101); // Sold
                        btn.Enabled = false;

                        // 2. Insert into dbo.Tickets table
                        int moviePriceId = _showing.MoviePriceID;
                        bool inserted = _ticketRepository.InsertTicket(_showing.ShowtimeID, seatId, moviePriceId);

                        if (inserted)
                        {
                            XtraMessageBox.Show($"Seat {btn.Text} has been purchased. Ticket saved.", "Success");
                        }
                        else
                        {
                            XtraMessageBox.Show("Ticket failed to save!", "Error");
                        }
                    }
                }
                else if (prompt.SelectedAction == "Reserve")
                {
                    // Reservation logic
                    XtraMessageBox.Show($"Seat {btn.Name} has been reserved.", "Reserve");
                }
            }
        }


        private void confirmBTN_Click(object sender, EventArgs e)
        {
            // Your existing confirm logic (if any)
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeShowtimeSeats()
        {
            var existing = _seatRepository.GetShowtimeSeatsByShowtime(_showing.ShowtimeID);
            if (existing.Count > 0)
                return; // Already initialized, skip

            var allSeats = _seatRepository.GetSeatsByHall(_showing.HallID);

            foreach (var seat in allSeats)
            {
                int seatStatus = (seat.IsAvailable == 0) ? 1 : 4;

                _seatRepository.InsertShowtimeSeat(new ShowtimeSeat
                {
                    ShowtimeID = _showing.ShowtimeID,
                    SeatID = seat.SeatID,
                    SeatStatusID = seatStatus
                });
            }
        }

        public class ShowtimeSeat
        {
            public int ShowtimeID { get; set; }
            public int SeatID { get; set; }
            public int SeatStatusID { get; set; }
        }
    }
}