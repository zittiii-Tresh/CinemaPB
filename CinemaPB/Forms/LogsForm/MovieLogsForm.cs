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
    public partial class MovieLogsForm : DevExpress.XtraEditors.XtraUserControl
    {
        public MovieLogsForm()
        {
            InitializeComponent();
        }
        private void LoadLogsIntoGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                string query = @"SELECT    ml.LogID, 
                                           ml.Username,
	                                       m.Title,
	                                       ml.DateTime, 
	                                       ml.Activity 
                                    FROM log.MovieLogs ml
                                    LEFT JOIN mov.Movies m
                                    ON m.MovieID = ml.MovieID
                                    ORDER BY ml.LogID DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gcMovieLogs.DataSource = dt;

                var view = gcMovieLogs.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                {
                    view.Columns["DateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    view.Columns["DateTime"].DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt"; // example: 07/16/2025 02:15 PM
                    view.BestFitColumns(); // optional: auto-fit columns
                }
            }
        }

        private void gcMovieLogs_Load(object sender, EventArgs e)
        {
            LoadLogsIntoGrid();
        }
    }
}
