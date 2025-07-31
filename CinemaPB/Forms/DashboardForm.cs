using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            dateDE.EditValue = DateTime.Today; // 👈 default to current month
            LoadTopSellingMoviesByMonth(DateTime.Today);
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

        private void LoadTopSellingMoviesByMonth(DateTime selectedDate)
        {
            using (SqlConnection conn = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                string query = @"SELECT TOP 3 
                            M.MovieID,
                            M.Title,
                            M.Poster,
                            COUNT(DISTINCT S.ShowtimeID) AS TotalShowings,
                            COUNT(T.TicketID) AS TotalTicketsSold,
                            SUM(MP.Price) AS TotalSale
                         FROM Tickets T
                         LEFT JOIN Showtime S ON T.ShowtimeID = S.ShowtimeID
                         LEFT JOIN mov.MoviePrices MP ON T.MoviePriceID = MP.MoviePriceID
                         LEFT JOIN mov.Movies M ON S.MovieID = M.MovieID
                         WHERE MONTH(S.ShowDate) = @Month AND YEAR(S.ShowDate) = @Year
                         GROUP BY M.MovieID, M.Title, M.Poster
                         ORDER BY TotalSale DESC;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Month", selectedDate.Month);
                cmd.Parameters.AddWithValue("@Year", selectedDate.Year);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear previous images and labels first
                firstMoviePE.Image = secondMoviePE.Image = thirdMoviePE.Image = null;
                FirstTitleLBL.Text = SecondTitleLBL.Text = ThirdTitleLBL.Text = "";
                FirstTotalShowingCountLBL.Text = SecondTotalShowingCountLBL.Text = ThirdTotalShowingCountLBL.Text = "";
                FirstTotalTicketsSoldLBL.Text = SecondTotalTicketsSoldLBL.Text = ThirdTotalTicketsSoldLBL.Text = "";
                FirstTotalSaleLBL.Text = SecondTotalSaleLBL.Text = ThirdTotalSaleLBL.Text = "";

                int rank = 1;
                while (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    int showings = Convert.ToInt32(reader["TotalShowings"]);
                    int tickets = Convert.ToInt32(reader["TotalTicketsSold"]);
                    decimal totalSale = Convert.ToDecimal(reader["TotalSale"]);
                    byte[] posterBytes = reader["Poster"] as byte[];

                    Image posterImage = null;
                    if (posterBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(posterBytes))
                        {
                            posterImage = Image.FromStream(ms);
                        }
                    }

                    switch (rank)
                    {
                        case 1:
                            firstMoviePE.Image = posterImage;
                            FirstTitleLBL.Text = title;
                            FirstTotalShowingCountLBL.Text = $"Total Showing Count: {showings}";
                            FirstTotalTicketsSoldLBL.Text = $"Total Tickets Sold: {tickets}";
                            FirstTotalSaleLBL.Text = $"Total Sale: ₱{totalSale:N2}";
                            break;
                        case 2:
                            secondMoviePE.Image = posterImage;
                            SecondTitleLBL.Text = title;
                            SecondTotalShowingCountLBL.Text = $"Total Showing Count: {showings}";
                            SecondTotalTicketsSoldLBL.Text = $"Total Tickets Sold: {tickets}";
                            SecondTotalSaleLBL.Text = $"Total Sale: ₱{totalSale:N2}";
                            break;
                        case 3:
                            thirdMoviePE.Image = posterImage;
                            ThirdTitleLBL.Text = title;
                            ThirdTotalShowingCountLBL.Text = $"Total Showing Count: {showings}";
                            ThirdTotalTicketsSoldLBL.Text = $"Total Tickets Sold: {tickets}";
                            ThirdTotalSaleLBL.Text = $"Total Sale: ₱{totalSale:N2}";
                            break;
                    }

                    rank++;
                }

                reader.Close();
                conn.Close();
            }
        }

        private void dateDE_EditValueChanged(object sender, EventArgs e)
        {
            if (dateDE.EditValue != null && DateTime.TryParse(dateDE.EditValue.ToString(), out DateTime selectedDate))
            {
                LoadTopSellingMoviesByMonth(selectedDate);
            }
        }
    }
}
