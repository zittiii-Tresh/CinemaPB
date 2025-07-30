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
using CinemaPB.ModelShowing;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.WinExplorer;

namespace CinemaPB.Forms
{
    public partial class Hall2Showing : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ShowingRepository _showingRepository;
        private const int HallID = 2;

        public Hall2Showing()
        {
            InitializeComponent();
            _showingRepository = new ShowingRepository(GlobalSetting.GetConnectionString());
            dateLBL.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt");
            showdateDE.EditValueChanged += showdateDE_EditValueChanged; // 👈 Add this line
            LoadShowings();

        }

        private void LoadShowings(DateTime? selectedDate = null)
        {
            var dateToUse = selectedDate ?? DateTime.Today;
            var cards = _showingRepository.GetCurrentShowings(dateToUse, HallID);

            showingGC.DataSource = cards;
            showingGC.RefreshDataSource();
        }


        private void showingEV_Click(object sender, EventArgs e)
        {
            var selected = showingEV.GetFocusedRow() as ShowingCard;
            if (selected != null)
            {
                var reserveForm = new ReserveSeatsForm2(selected);
                reserveForm.ShowDialog();
            }
        }

        private void showdateDE_EditValueChanged(object sender, EventArgs e)
        {
            if (showdateDE.EditValue != null && DateTime.TryParse(showdateDE.EditValue.ToString(), out DateTime selectedDate))
            {
                LoadShowings(selectedDate);

                if (selectedDate.Date == DateTime.Today)
                    dayLBL.Text = "TODAY";
                else
                    dayLBL.Text = selectedDate.ToString("dddd").ToUpper(); // e.g., "MONDAY"
            }
        }
    }
}

