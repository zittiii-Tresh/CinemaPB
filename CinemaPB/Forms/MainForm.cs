using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CinemaPB.Forms;
using CinemaPB.Infrastructure.Repositories;
using CinemaPB.Configuration;

namespace CinemaPB.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly MovieRepository _movieRepository;
        public MainForm()
        {
            InitializeComponent();
            _movieRepository = new MovieRepository(GlobalSetting.GetConnectionString());
        }

        private void moviesACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new MoviesForm());
        }

        private void employeelistACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new EmployeeListForm());
        }

        private void schedulinghall1BTN_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new SchedulingHall1Form());
        }

        private void schedulinghall2BTN_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new SchedulingHall2Form());
        }

        private void hall1seatsACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new EditSeatLayoutForm());
        }
    }
}