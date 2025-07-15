using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.Infrastructure.SQL
{
    public static class MovieSQL
    {
        public static string GetListOfGenre = @"SELECT GenreID, GenreName FROM mov.Genre;";

        public static string GetListOfLanguage = @"SELECT LanguageID, LanguageName FROM mov.Language;";

        public static string GetListOfContentRating = @"SELECT RatingID, RatingName FROM mov.ContentRating;";

        public static string InsertMovie = @"EXEC InsertMovie
                                                  @Title = @Title, 
                                                  @GenreID = @GenreID, 
                                                  @Description = @Description, 
                                                  @Duration = @Duration, 
                                                  @LanguageID = @LanguageID, 
                                                  @Poster = @Poster,
                                                  @Availability = @Availability, 
                                                  @RatingID = @RatingID,
                                                  @MovieID = @MovieID OUTPUT;";

        public static string InsertGenre = @"INSERT INTO mov.Genre (GenreName) VALUES (@GenreName);";
        public static string InsertLanguage = @"INSERT INTO mov.Language (LanguageName) VALUES (@LanguageName);";
        public static string RetrieveMoviePriceAndDetails = @"EXEC RetrieveMovieAndPriceDetails";
        public static string UpdateMovie = @"UPDATE mov.Movies
                                             SET Title = @Title,
                                                 Description = @Description,
                                                 Duration = @Duration,
                                                 LanguageID = @LanguageID,
                                                 RatingID = @RatingID,
                                                 Availability = @Availability,
                                                 Poster = @Poster
                                             WHERE MovieID = @MovieID";

        public static string DeleteMovieGenres = @"DELETE FROM mov.MovieGenres WHERE MovieID = @MovieID";

        public static string InsertMovieGenre = @"INSERT INTO mov.MovieGenres (MovieID, GenreID) VALUES (@MovieID, @GenreID)";

        public static string CheckIfMoviePriceExists = @"SELECT COUNT(1) FROM mov.MoviePrices WHERE MovieID = @MovieID AND DayType = @DayType";

        public static string UpdateMoviePrice = @"UPDATE mov.MoviePrices SET Price = @Price 
                                                  WHERE MovieID = @MovieID AND DayType = @DayType";

        public static string InsertMoviePrice = @"INSERT INTO mov.MoviePrices (MovieID, DayType, Price) 
                                                  VALUES (@MovieID, @DayType, @Price)";

        public static string DeleteMoviePrices = @"DELETE FROM mov.MoviePrices WHERE MovieID = @MovieID";

        public static string DeleteMovie = @"DELETE FROM mov.Movies WHERE MovieID = @MovieID";

    }
}
