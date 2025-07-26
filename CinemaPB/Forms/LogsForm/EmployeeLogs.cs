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
using DevExpress.XtraEditors;

namespace CinemaPB.Forms.LogsForm
{
    public partial class EmployeeLogs : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeLogs()
        {
            InitializeComponent();
        }

        private void LoadLogsIntoGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                string query = @"SELECT    el.LogID, 
                                           el.Username,
	                                       el.DateTime, 
	                                       el.Activity,
                                           el.Authentication
                                    FROM log.EmployeeLogs el
                                    ORDER BY el.LogID DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gcEmployeeLogs.DataSource = dt;

                var view = gcEmployeeLogs.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                {
                    view.Columns["DateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    view.Columns["DateTime"].DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt"; // example: 07/16/2025 02:15 PM
                    view.BestFitColumns(); // optional: auto-fit columns
                }
            }
        }

        private void gcEmployeeLogs_Load(object sender, EventArgs e)
        {
            LoadLogsIntoGrid();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            LogsReport.EmployeeLogsReport reports = new LogsReport.EmployeeLogsReport();

            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                string query = @"SELECT    el.LogID, 
                                           el.Username,
	                                       el.DateTime, 
	                                       el.Activity,
                                           el.Authentication
                                    FROM log.EmployeeLogs el
                                    ORDER BY el.LogID DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        reports.DataSource = dataTable;
                        DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(reports);
                        printTool.ShowPreviewDialog();
                    }
                }
            }
        }
    }
}
