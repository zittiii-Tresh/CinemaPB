using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPB.Configuration;
using Dapper;

namespace CinemaPB.Infrastructure.Repositories
{
    public class TicketRepository
    {
        private readonly string _connectionString;
        public TicketRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool InsertTicket(int showtimeId, int seatId, int moviePriceId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO dbo.Tickets 
                         (ShowtimeID, SeatID, PurchaseTime, MoviePriceID, PaymentStatus, TicketStatus)
                         VALUES (@ShowtimeID, @SeatID, @PurchaseTime, @MoviePriceID, @PaymentStatus, @TicketStatus)";

                var parameters = new
                {
                    ShowtimeID = showtimeId,
                    SeatID = seatId,
                    PurchaseTime = DateTime.Now.TimeOfDay,
                    MoviePriceID = moviePriceId,
                    PaymentStatus = "Paid",
                    TicketStatus = "Sold"
                };

                int rows = connection.Execute(query, parameters);
                return rows > 0;
            }
        }

        public int GetLastInsertedTicketID()
        {
            using (var connection = new SqlConnection(GlobalSetting.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT IDENT_CURRENT('Tickets')";
                return Convert.ToInt32(new SqlCommand(query, connection).ExecuteScalar());
            }
        }

    }
}
