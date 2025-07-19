using CinemaPB.Infrastructure.SQL;
using CinemaPB.ModelShowing;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CinemaPB.Infrastructure.Repositories
{
    public class ShowingRepository
    {
        private readonly string _connectionString;

        public ShowingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ShowingCard> GetCurrentShowings(DateTime showDate, int hallId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = connection.Query<dynamic>(ShowingSQL.GetCurrentShowing, new { ShowDate = showDate.Date, HallID = hallId });

                var grouped = result
                    .GroupBy(x => new { x.MovieID, x.Title, x.Genres, x.Duration, x.RatingName, x.Poster })
                    .Select(g =>
                    {
                        var screenings = g.ToDictionary(
                            x => (int)x.Screening,
                            x => (string)x.TimeRange
                        );

                        return new ShowingCard
                        {
                            MovieID = g.Key.MovieID,
                            Title = g.Key.Title,
                            Genres = g.Key.Genres,
                            Duration = g.Key.Duration,
                            RatingName = g.Key.RatingName,
                            Poster = g.Key.Poster,
                            First = screenings.ContainsKey(1) ? screenings[1] : null,
                            Second = screenings.ContainsKey(2) ? screenings[2] : null,
                            Last = screenings.ContainsKey(3) ? screenings[3] : null
                        };
                    })
                    .ToList();

                return grouped;
            }
        }

        private string FormatTimeRange(TimeSpan start, TimeSpan end)
        {
            DateTime today = DateTime.Today;
            string formattedStart = today.Add(start).ToString("hh:mm tt");
            string formattedEnd = today.Add(end).ToString("hh:mm tt");
            return $"{formattedStart} - {formattedEnd}";
        }

    }
}
