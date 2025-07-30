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
using CinemaPB.Forms;
using CinemaPB.Forms.LogsForm;
using CinemaPB.Infrastructure.Repositories;
using CinemaPB.Reports;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

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
            DailySalesReport report = new DailySalesReport();

            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();
                string query = GlobalSQL.SQLQuery.DailyReport;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        report.DataSource = table;
                        report.ShowPreview();
                    }
                }
            }
        }

        private void weeklysalesACE_Click(object sender, EventArgs e)
        {
            WeeklySalesReport report = new WeeklySalesReport();

            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();
                string query = GlobalSQL.SQLQuery.WeeklyReport;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        report.DataSource = table;
                        report.ShowPreview();
                    }
                }
            }
        }

        private void monthlysalesACE_Click(object sender, EventArgs e)
        {
            SalesReport report = new SalesReport();

            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();
                string query = GlobalSQL.SQLQuery.MonthlyReport;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        report.DataSource = table;
                        report.ShowPreview();
                    }
                }
            }
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Are you sure you want to log out?",
                   "Confirm Logout",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );

            if (result == DialogResult.Yes)
            {
                UserSession.Username = null;

                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
            }
        }
    }
}