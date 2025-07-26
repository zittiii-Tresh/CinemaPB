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
    public partial class ShowtimeLogsForm : DevExpress.XtraEditors.XtraUserControl
    {
        public ShowtimeLogsForm()
        {
            InitializeComponent();
        }

        private void LoadLogsIntoGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                string query = @"SELECT    sl.LogID, 
                                           sl.ShowtimeID,
                                           sl.Username,
	                                       sl.DateTime, 
	                                       sl.Activity 
                                    FROM log.ShowtimeLogs sl
                                    ORDER BY sl.LogID DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gcShowtimeLogs.DataSource = dt;

                var view = gcShowtimeLogs.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                {
                    view.Columns["DateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    view.Columns["DateTime"].DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt";
                    view.BestFitColumns(); // optional: auto-fit columns
                }
            }
        }

        private void gcShowtimeLogs_Load(object sender, EventArgs e)
        {
            LoadLogsIntoGrid();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            LogsReport.ShowtimeLogsReport reports = new LogsReport.ShowtimeLogsReport();

            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                string query = @"SELECT    sl.LogID, 
                                           sl.ShowtimeID,
                                           sl.Username,
	                                       sl.DateTime, 
	                                       sl.Activity 
                                    FROM log.ShowtimeLogs sl
                                    ORDER BY sl.LogID DESC";

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

    
