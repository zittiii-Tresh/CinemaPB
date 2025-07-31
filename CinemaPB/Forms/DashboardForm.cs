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

namespace CinemaPB.Forms
{
    public partial class DashboardForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void dailySalesGC_Load(object sender, EventArgs e)
        {
            LoadDailySaLesIntoGrid();
        }

        private void LoadDailySaLesIntoGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                string query = @"SELECT  M.MovieID,
                                         M.Title AS MovieTitle,
                                         COUNT(T.TicketID) AS TicketsSold,
                                         FORMAT(SUM(MP.Price), 'N2') AS TotalRevenue
                                         FROM Tickets T
                                         LEFT JOIN Showtime S ON S.ShowtimeID = T.ShowtimeID
                                         LEFT JOIN mov.Movies M ON M.MovieID = S.MovieID
                                         LEFT JOIN mov.MoviePrices MP ON MP.MoviePriceID = T.MoviePriceID
                                         WHERE CAST(S.ShowDate AS DATE) = CAST(GETDATE() AS DATE)
                                         GROUP BY M.MovieID, M.Title;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dailySalesGC.DataSource = dt;

                var view = dailySalesGC.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                {
                    view.BestFitColumns(); 
                }
            }
        }
    }
}
