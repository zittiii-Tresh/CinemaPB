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
using CinemaPB.ModelSeat;
using CinemaPB.ModelShowing;
using DevExpress.XtraEditors;

namespace CinemaPB.Forms
{
    public partial class EditSeatLayoutForm : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly SeatRepository _seatRepository;
        private List<SimpleButton> seatButtons;
        private HashSet<string> modifiedSeatNames = new HashSet<string>();
        private const int HallID = 1;

        public EditSeatLayoutForm()
        {
            InitializeComponent();
            _seatRepository = new SeatRepository(GlobalSetting.GetConnectionString());

            LoadSeatButtons();
            LoadSeatStatus();

            foreach (var btn in seatButtons)
            {
                btn.Click += SeatButton_Click;
            }

            availableRG.SelectedIndexChanged += availableRG_SelectedIndexChanged;
        }

        private void LoadSeatButtons()
        {
            seatButtons = sidePanel7.Controls.OfType<SimpleButton>()
                                             .Where(b => !string.IsNullOrEmpty(b.Name) && char.IsLetter(b.Name[0]) && char.IsDigit(b.Name[1]))
                                             .ToList();
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

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (availableRG.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Please select Enable or Disable first.", "No Action Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var btn = sender as SimpleButton;
            if (btn == null) return;

            int selectedAvailability = (availableRG.SelectedIndex == 0) ? 0 : 1;
            int currentAvailability = (btn.Tag != null) ? Convert.ToInt32(btn.Tag) : -1;

            if (selectedAvailability != currentAvailability)
            {
                btn.Tag = selectedAvailability;
                modifiedSeatNames.Add(btn.Name);

                // Set color immediately for visual feedback
                btn.Appearance.BackColor = (selectedAvailability == 0)
                    ? Color.FromArgb(0, 126, 65)     // Available - Green
                    : Color.FromArgb(160, 106, 13);  // Disabled - Orange
            }
        }

        private void availableRG_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No action needed yet
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (modifiedSeatNames.Count == 0)
            {
                XtraMessageBox.Show("No changes to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int updatesMade = 0;

            foreach (var seatName in modifiedSeatNames)
            {
                var btn = seatButtons.FirstOrDefault(b => b.Name == seatName);

                int isAvailable = Convert.ToInt32(btn.Tag);

                bool result = _seatRepository.UpdateSeatAvailability(new Seat
                {
                    SeatNumber = seatName,
                    HallID = HallID,
                    IsAvailable = isAvailable
                });

                if (result)
                {

                    updatesMade++;
                    string activity = isAvailable == 0 ? "Enabled a seat" : "Disabled a seat";
                    GlobalLogger.seatLayoutLog(UserSession.Username, seatName, HallID, activity);
                }
                else
                {
                    XtraMessageBox.Show($"Failed to update seat '{seatName}' in DB.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            modifiedSeatNames.Clear();

            if (updatesMade > 0)
            {
                XtraMessageBox.Show($"{updatesMade} seat(s) updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("No seats were updated in the database.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
