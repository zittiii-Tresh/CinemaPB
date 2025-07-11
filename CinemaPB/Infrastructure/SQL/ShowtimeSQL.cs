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

        public static string InsertShowtime = @" INSERT INTO dbo.Showtime (MovieID, HallID, ShowDate, StartTime, EndTime, MoviePriceID)
                                                 VALUES (@MovieID, @HallID, @ShowDate, @StartTime, @EndTime, @MoviePriceID);";

        public static string RetrieveShowtime = @"EXEC RetrieveShowtimes;";
    }
}
