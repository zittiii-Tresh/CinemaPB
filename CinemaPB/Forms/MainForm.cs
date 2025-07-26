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
using CinemaPB.Forms.LogsForm;

namespace CinemaPB.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly MovieRepository _movieRepository;
        public MainForm()
        {
            InitializeComponent();
            _movieRepository = new MovieRepository(GlobalSetting.GetConnectionString());
            AdminLBL.Text = UserSession.Username;
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

        private void movielogsACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new MovieLogsForm());
        }

        private void showtimelogsACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new ShowtimeLogsForm());
        }

        private void seatlayoutlogsACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new SeatLayoutLogsForm());
        }

        private void ticketlogsACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new TicketLogsForm());
        }

        private void hall2seatsACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new EditSeatLayoutForm2());
        }

        private void employeelogsACE_Click(object sender, EventArgs e)
        {
            FormHelper.LoadUserControl(mainSPanel, new EmployeeLogs());
        }

        private void dailysalesACE_Click(object sender, EventArgs e)
        {
            var report = new Reports.DailySalesReport();
            var tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);
            tool.ShowPreviewDialog();
        }

        private void weeklysalesACE_Click(object sender, EventArgs e)
        {
            var report = new Reports.WeeklySalesReport();
            var tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);
            tool.ShowPreviewDialog();
        }

        private void monthlysalesACE_Click(object sender, EventArgs e)
        {
            var report = new Reports.SalesReport();
            var tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);
            tool.ShowPreviewDialog();
        }
    }
}