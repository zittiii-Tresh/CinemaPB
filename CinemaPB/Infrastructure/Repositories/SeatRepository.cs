using CinemaPB.Infrastructure.SQL;
using CinemaPB.ModelSeat;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static CinemaPB.Forms.ReserveSeatsForm;
using CinemaPB.ModelShowtime;

namespace CinemaPB.Infrastructure.Repositories
{
    public class SeatRepository
    {
        private readonly string _connectionString;

        public SeatRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Seat> GetSeatsByHall(int hallId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Seat>(SeatSQL.GetSeatsForHall, new { HallID = hallId }).ToList();
            }
        }

        public bool UpdateSeatAvailability(Seat seat)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                int rows = connection.Execute(SeatSQL.UpdateSeatAvailability, new
                {
                    SeatNumber = seat.SeatNumber,
                    HallID = seat.HallID,
                    IsAvailable = seat.IsAvailable
                });

                return rows > 0;
            }
        }

        public List<ShowtimeSeat> GetShowtimeSeatsByShowtime(int showtimeID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT ShowtimeID, SeatID, SeatStatusID
                         FROM ShowtimeSeats
                         WHERE ShowtimeID = @ShowtimeID";

                return connection.Query<ShowtimeSeat>(query, new { ShowtimeID = showtimeID }).ToList();
            }
        }

        public bool InsertShowtimeSeat(ShowtimeSeat seat)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO ShowtimeSeats (ShowtimeID, SeatID, SeatStatusID)
                         VALUES (@ShowtimeID, @SeatID, @SeatStatusID)";

                int result = connection.Execute(query, seat);
                return result > 0;
            }
        }

        public int GetSeatIDBySeatNumberAndHall(string seatNumber, int hallId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<int>(
                    "SELECT SeatID FROM Seats WHERE SeatNumber = @SeatNumber AND HallID = @HallID",
                    new { SeatNumber = seatNumber, HallID = hallId }
                );
            }
        }

        public bool CheckIfShowtimeSeatsExist(int showtimeId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var count = connection.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM ShowtimeSeats WHERE ShowtimeID = @ShowtimeID",
                    new { ShowtimeID = showtimeId }
                );
                return count > 0;
            }
        }

        public List<(int SeatID, string SeatNumber, int SeatStatusID, string Username)> GetSeatsByShowtimeWithUsername(int showtimeId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
            SELECT 
                ss.SeatID,
                s.SeatNumber,
                ss.SeatStatusID,
                t.Username
            FROM ShowtimeSeats ss
            JOIN Seats s ON s.SeatID = ss.SeatID
            LEFT JOIN Tickets t ON t.SeatID = ss.SeatID AND t.ShowtimeID = ss.ShowtimeID
            WHERE ss.ShowtimeID = @ShowtimeID";

                return connection.Query<(int, string, int, string)>(query, new { ShowtimeID = showtimeId }).ToList();
            }
        }


        public bool UpdateSeatStatus(int showtimeId, int seatId, int seatStatusId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE ShowtimeSeats
                         SET SeatStatusID = @SeatStatusID
                         WHERE ShowtimeID = @ShowtimeID AND SeatID = @SeatID";

                int affected = connection.Execute(query, new
                {
                    ShowtimeID = showtimeId,
                    SeatID = seatId,
                    SeatStatusID = seatStatusId
                });

                return affected > 0;
            }
        }

        public (int SeatStatusID, string Username) GetSeatWithUsername(int showtimeId, int seatId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<(int, string)>(
                    @"SELECT ss.SeatStatusID, t.Username
              FROM ShowtimeSeats ss
              LEFT JOIN Tickets t ON t.SeatID = ss.SeatID AND t.ShowtimeID = ss.ShowtimeID
              WHERE ss.ShowtimeID = @ShowtimeID AND ss.SeatID = @SeatID",
                    new { ShowtimeID = showtimeId, SeatID = seatId }
                );
            }
        }
    }
}
