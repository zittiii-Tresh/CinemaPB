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

    }
}
