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
    public partial class SeatLayoutLogsForm : DevExpress.XtraEditors.XtraUserControl
    {
        public SeatLayoutLogsForm()
        {
            InitializeComponent();
        }

        private void LoadLogsIntoGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                string query = @"SELECT TOP (1000) [LogID]
                                                  ,[Username]
                                                  ,[SeatID]
                                                  ,[HallID]
                                                  ,[DateTime]
                                                  ,[Activity]
                                              FROM [CinemaDB].[log].[SeatLayoutLogs]
                                              ORDER BY LogID DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gcSeatLayoutLogs.DataSource = dt;

                var view = gcSeatLayoutLogs.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                {
                    view.Columns["DateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    view.Columns["DateTime"].DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt"; // example: 07/16/2025 02:15 PM
                    view.BestFitColumns(); // optional: auto-fit columns
                }
            }
        }
        private void gcSeatLayoutLogs_Load(object sender, EventArgs e)
        {
            LoadLogsIntoGrid();
        }
    }
}
