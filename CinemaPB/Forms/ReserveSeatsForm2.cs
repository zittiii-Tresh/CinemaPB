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

namespace CinemaPB.Forms
{
    public partial class ReserveSeatsForm2 : DevExpress.XtraEditors.XtraForm
    {
        private SeatRepository _seatRepository;
        private List<SimpleButton> seatButtons;
        private const int HallID = 2; // or pass this in dynamically later
        public ReserveSeatsForm2()
        {
            InitializeComponent();
            _seatRepository = new SeatRepository(GlobalSetting.GetConnectionString());
            LoadSeatButtons();
            LoadSeatStatus();
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

                    // Apply color
                    btn.Appearance.BackColor = (seat.IsAvailable == 0)
                        ? Color.FromArgb(0, 126, 65)     // Available - Green
                        : Color.FromArgb(160, 106, 13);   // Disabled - Orange
                }
            }
        }

        private void LoadSeatButtons()
        {
            seatButtons = sidePanel7.Controls.OfType<SimpleButton>()
                                              .Where(b => !string.IsNullOrEmpty(b.Name) && char.IsLetter(b.Name[0]) && char.IsDigit(b.Name[1]))
                                              .ToList();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            ReserveSeatsForm2.ActiveForm.Close();
        }
    }
}