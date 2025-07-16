using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.Infrastructure.SQL
{
    public static class ShowtimeSQL
    {
        public static string GetAvailableMovies= @"SELECT * FROM mov.Movies WHERE Availability = 1;";

        public static string GetMoviePriceID = @"SELECT MoviePriceID 
                                                 FROM mov.MoviePrices 
                                                 WHERE MovieID = @MovieID AND DayType = @DayType;";

        public static string InsertShowtime = @" INSERT INTO dbo.Showtime (MovieID, HallID, ShowDate, StartTime, EndTime, MoviePriceID, Screening)
                                                 VALUES (@MovieID, @HallID, @ShowDate, @StartTime, @EndTime, @MoviePriceID, @Screening);";

        public static string RetrieveShowtime = @"EXEC RetrieveShowtimes @HallID;";

        public static string UpdateShowtime = @"UPDATE dbo.Showtime
                                                SET ShowDate = @ShowDate,
                                                    StartTime = @StartTime,
                                                    EndTime = @EndTime,
                                                    MoviePriceID = @MoviePriceID,
                                                    Screening = @Screening
                                                WHERE ShowtimeID = @ShowtimeID AND Screening = @Screening";

        public static string DeleteShowtime = @"DELETE FROM dbo.Showtime WHERE ShowtimeID = @ShowtimeID";

        public static string GetShowtimesByDateAndHall = @"SELECT ShowtimeID, MovieID, StartTime, EndTime, ShowDate, Screening
                                                           FROM dbo.Showtime
                                                           WHERE CAST(ShowDate AS DATE) = @ShowDate AND HallID = @HallID;";
        public static string GetScreeningsForDate = @"SELECT Screening 
                                                      FROM dbo.Showtime 
                                                      WHERE ShowDate = @ShowDate AND HallID = @HallID";

        public static string GetTimeSlotsForDate = @"SELECT StartTime, EndTime 
                                                     FROM dbo.Showtime 
                                                     WHERE ShowDate = @ShowDate AND HallID = @HallID";
    }
}
