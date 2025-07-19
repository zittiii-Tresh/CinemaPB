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

namespace CinemaPB.Forms
{
    public partial class ReserveSeatsForm : DevExpress.XtraEditors.XtraForm
    {
        private MovieRepository _movieRepository;
        private SeatRepository _seatRepository;
        private List<SimpleButton> seatButtons;
        private const int HallID = 1; // or pass this in dynamically later

        public ReserveSeatsForm()
        {
            InitializeComponent();
            _seatRepository = new SeatRepository(GlobalSetting.GetConnectionString());
            LoadSeatButtons();
            LoadSeatStatus();
            _movieRepository = new MovieRepository(GlobalSetting.GetConnectionString());
            LoadMovieShowtimesIntoLookUp();

        }
        private void LoadSeatStatus()
        {
            var seats = _seatRepository.GetSeatsByHall(HallID);

            foreach (var seat in seats)
            {
                var btn = seatButtons.FirstOrDefault(b => b.Name == seat.SeatNumber);
                if (btn != null)
                {
                    btn.Enabled = true;
                    btn.Tag = seat.IsAvailable;

                    btn.Appearance.BackColor = (seat.IsAvailable == 0)
                        ? Color.FromArgb(0, 126, 65)     // Green (Enabled)
                        : Color.FromArgb(160, 106, 13);  // Orange (Disabled)
                }
            }
        }

        private void LoadSeatButtons()
        {
            seatButtons = seatPanel.Controls.OfType<SimpleButton>()
                .Where(b => !string.IsNullOrEmpty(b.Name) &&
                            char.IsLetter(b.Name[0]) &&
                            char.IsDigit(b.Name[1]))
                .ToList();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            ReserveSeatsForm.ActiveForm.Close();
        }

        private void LoadMovieShowtimesIntoLookUp()
        {
            var movieShowtimes = _movieRepository.GetMovieShowtimeList();

            movieLUE.Properties.DataSource = movieShowtimes;
            movieLUE.Properties.DisplayMember = "Title"; // or combine fields for display
            movieLUE.Properties.ValueMember = "Title";   // or HallID or whatever you need

            movieLUE.Properties.Columns.Clear();
            movieLUE.Properties.Columns.Add(new LookUpColumnInfo("Title", "Movie"));
            movieLUE.Properties.Columns.Add(new LookUpColumnInfo("HallID", "Hall"));
            movieLUE.Properties.Columns.Add(new LookUpColumnInfo("StartTime", "Time"));
            movieLUE.Properties.Columns.Add(new LookUpColumnInfo("Screening", "Screening"));

            movieLUE.Properties.NullText = "-- Select a Movie --";
        }
    }
}