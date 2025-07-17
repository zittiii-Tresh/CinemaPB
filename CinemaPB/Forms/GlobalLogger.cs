using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPB.Configuration;
using CinemaPB.ModelMovie;
using CinemaPB.ModelShowtime;
using Dapper;

namespace CinemaPB.Forms
{
    public class GlobalLogger
    {
        public static void movieLog(string module, int movieId, string activity, string username)
        {
            string connectionString = GlobalSetting.GetConnectionString();
            string movieTitle = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string titleQuery = "SELECT Title FROM mov.Movies WHERE MovieID = @MovieID";
                using (SqlCommand cmd = new SqlCommand(titleQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    var result = cmd.ExecuteScalar();
                    movieTitle = result?.ToString() ?? "[Unknown]";
                }

                // ✅ 2. Insert log with full activity
                string insertQuery = @"
                INSERT INTO log.MovieLogs (Username, MovieID, DateTime, Activity)
                VALUES (@Username, @MovieID, @DateTime, @Activity)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Activity", $"{activity}");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void showtimeLog(int showtimeId, string activity, string username)
        {
            string connectionString = GlobalSetting.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO log.ShowtimeLogs (ShowtimeID, Username, DateTime, Activity)
            VALUES (@ShowtimeID, @Username, @DateTime, @Activity)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Activity", activity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void employeeLoginLog(string username, bool isSuccess)
        {
            string connectionString = GlobalSetting.GetConnectionString();
            string status = isSuccess ? "Success" : "Failed";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO log.EmployeeLogs (Username, DateTime, Activity, Authentication)
            VALUES (@Username, @DateTime, @Activity, @Authentication)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Activity", "Login attempt");
                    cmd.Parameters.AddWithValue("@Authentication", status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void employeeLog(string activity, string username)
        {
            string connectionString = GlobalSetting.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                                        INSERT INTO log.EmployeeLogs (Username, DateTime, Activity, Authentication)
                                        VALUES (@Username, @DateTime, @Activity, NULL)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Activity", activity);
                    cmd.ExecuteNonQuery();
                }
            }
        }





    }
}
