using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.Infrastructure.SQL
{
    public class SeatSQL
    {
        public const string GetSeatsForHall = @"SELECT SeatID, HallID, SeatNumber, IsAvailable
                                                 FROM dbo.Seats
                                                 WHERE HallID = @HallID";

        public const string UpdateSeatAvailability = @"UPDATE dbo.Seats
                                                       SET IsAvailable = @IsAvailable
                                                       WHERE SeatNumber = @SeatNumber AND HallID = @HallID";
    }
}
