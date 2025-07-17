using CinemaPB.Infrastructure.SQL;
using CinemaPB.ModelSeat;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

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
    }
}
