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
                var result = connection.Query<dynamic>(
                    ShowingSQL.GetCurrentShowing,
                    new { ShowDate = showDate.Date, HallID = hallId });

                var cards = new List<ShowingCard>();

                foreach (var row in result)
                {
                    int showtimeId = row.ShowtimeID ?? 0;
                    int movieId = row.MovieID ?? 0;
                    int screening = row.Screening ?? 0;
                    DateTime? showDateValue = row.ShowDate;
                    TimeSpan? startTime = row.StartTime;
                    TimeSpan? endTime = row.EndTime;

                    string timeslot = (startTime.HasValue && endTime.HasValue)
                        ? FormatTimeRange(startTime.Value, endTime.Value)
                        : "--";

                    cards.Add(new ShowingCard
                    {
                        ShowtimeID = showtimeId,
                        MovieID = movieId,
                        Title = row.Title,
                        Genres = row.Genres,
                        Duration = row.Duration,
                        RatingName = row.RatingName,
                        ShowDate = showDateValue.HasValue ? showDateValue.Value.ToString("yyyy-MM-dd") : "",
                        Screening = screening, // ✅ assign this
                        Timeslot = timeslot,
                        Poster = row.Poster,
                        HallID = row.HallID ?? 0,
                        MoviePriceID = row.MoviePriceID ?? 0,
                        StartTime = startTime,
                        EndTime = endTime,
                        // ✅ ScreeningLabel is auto-computed
                    });
                }


                return cards;
            }
        }

        private string FormatTimeRange(TimeSpan start, TimeSpan end)
        {
            var formattedStart = DateTime.Today.Add(start).ToString("h:mm tt");
            var formattedEnd = DateTime.Today.Add(end).ToString("h:mm tt");
            return $"{formattedStart} - {formattedEnd}";
        }

    }
}
