using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool InsertReservedTicket(int showtimeId, int seatId, string username, int moviePriceId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var query = @"INSERT INTO Tickets (SeatID, ShowtimeID, Username, PurchaseTime, MoviePriceID, PaymentStatus, TicketStatus)
                      VALUES (@SeatID, @ShowtimeID, @Username, GETDATE(), @MoviePriceID, 'Sold', 'Reserved')";

                int result = connection.Execute(query, new
                {
                    SeatID = seatId,
                    ShowtimeID = showtimeId,
                    Username = username,
                    MoviePriceID = moviePriceId
                });

                // Update seat status to Reserved (2)
                var update = @"UPDATE ShowtimeSeats 
                       SET SeatStatusID = 2 
                       WHERE ShowtimeID = @ShowtimeID AND SeatID = @SeatID";

                connection.Execute(update, new { ShowtimeID = showtimeId, SeatID = seatId });

                return result > 0;
            }
        }
        public bool UpdateTicketStatus(int showtimeId, int seatId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Tickets
                       SET TicketStatus = 'Sold',
                           PaymentStatus = 'Paid',
                           PurchaseTime = GETDATE()
                       WHERE ShowtimeID = @ShowtimeID AND SeatID = @SeatID";

                int rows = connection.Execute(sql, new { ShowtimeID = showtimeId, SeatID = seatId });
                return rows > 0;
            }
        }

        public bool ConfirmReservedTicket(int showtimeId, int seatId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // 1. Update the ticket info (status + payment)
                string updateTicketSql = @"
            UPDATE Tickets
            SET TicketStatus = 'Sold',
                PaymentStatus = 'Paid',
                PurchaseTime = GETDATE()
            WHERE ShowtimeID = @ShowtimeID AND SeatID = @SeatID AND TicketStatus = 'Reserved'";

                int ticketRows = connection.Execute(updateTicketSql, new
                {
                    ShowtimeID = showtimeId,
                    SeatID = seatId
                });

                // 2. Update the seat status to Sold (3)
                string updateSeatSql = @"
            UPDATE ShowtimeSeats
            SET SeatStatusID = 3
            WHERE ShowtimeID = @ShowtimeID AND SeatID = @SeatID";

                int seatRows = connection.Execute(updateSeatSql, new
                {
                    ShowtimeID = showtimeId,
                    SeatID = seatId
                });

                return ticketRows > 0 && seatRows > 0;
            }
        }
    }
}