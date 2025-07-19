using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.Infrastructure.SQL
{
    public class ShowingSQL
    {
        public static string GetCurrentShowing = @"SELECT s.MovieID
	                                                      ,s.ShowDate
	                                                      ,s.HallID
	                                                      ,s.Screening
	                                                      ,s.StartTime
	                                                      ,s.EndTime
	                                                      ,STRING_AGG(g.GenreName, ', ') AS Genres
	                                                      ,m.Title
	                                                      ,m.Poster
                                                          ,cr.RatingName
                                                          ,CONCAT(DATEPART(HOUR, m.Duration), 'hr:', RIGHT('0' + CAST(DATEPART(MINUTE, m.Duration) AS VARCHAR), 2), 'min') AS Duration
                                                    FROM dbo.Showtime s
                                                    LEFT JOIN mov.Movies m
                                                    ON m.MovieID = s.MovieID
                                                    LEFT JOIN mov.MovieGenres mg
                                                    ON mg.MovieID = m.MovieID
                                                    LEFT JOIN mov.Genre g
                                                    ON g.GenreID = mg.GenreID
                                                    LEFT JOIN mov.ContentRating cr
                                                    ON cr.RatingID = m.RatingID
                                                    WHERE s.ShowDate = @ShowDate AND s.HallID = @HallID
                                                    GROUP BY 
                                                        s.MovieID,
                                                        s.ShowDate,
                                                        s.HallID,
                                                        s.Screening,
                                                        s.StartTime,
                                                        s.EndTime,
                                                        m.Title,
                                                        m.Poster,
                                                        cr.RatingName,
                                                        m.Duration;";
    }
}
