using CinemaPB.Configuration;
using CinemaPB.Infrastructure.Repositories;
using CinemaPB.ModelMovie;
using CinemaPB.ModelShowtime;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaPB.Forms
{
    public partial class SeatReservationForm : DevExpress.XtraEditors.XtraForm
    {
        public int ShowtimeID { get; set; }
        public int SeatID { get; set; }
        public int SeatStatusID { get; set; }
        public int MoviePriceID { get; set; }

        public SeatReservationForm()
        {
            InitializeComponent();
        }
        public string ReservedUsername
        {
            get { return usernameTE.Text.Trim(); }
        }

        private void reserveBTN_Click(object sender, EventArgs e)
        {
            string username = usernameTE.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                XtraMessageBox.Show("Please enter a customer name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ticketRepo = new TicketRepository(GlobalSetting.GetConnectionString());
            bool success = ticketRepo.InsertReservedTicket(ShowtimeID, SeatID, username, MoviePriceID);

            if (success)
            {
                XtraMessageBox.Show("Seat reserved successfully!", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Reservation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}