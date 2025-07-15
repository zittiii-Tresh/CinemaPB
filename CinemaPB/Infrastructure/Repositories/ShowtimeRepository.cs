using CinemaPB.ModelMovie;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using CinemaPB.Infrastructure.SQL;
using CinemaPB.ModelShowtime;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace CinemaPB.Infrastructure.Repositories
{
    public class ShowtimeRepository
    {
        private readonly string _connectionString;
        public ShowtimeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<MovieWithDetail> GetAvailableMovies()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<MovieWithDetail>(SQL.ShowtimeSQL.GetAvailableMovies).ToList();
                return result;
            }
        }

        public int GetMoviePriceID(int movieId, string dayType)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var priceId = connection.QuerySingleOrDefault<int>(
                    ShowtimeSQL.GetMoviePriceID,
                    new { MovieID = movieId, DayType = dayType }
                );

                if (priceId == 0)
                    throw new Exception($"No price found for MovieID: {movieId}, DayType: {dayType}");

                return priceId;
            }
        }

        public void InsertShowtime(int movieId, int hallId, DateTime showDate, TimeSpan startTime, TimeSpan endTime, int moviePriceId, int screening)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(ShowtimeSQL.InsertShowtime, new
                {
                    MovieID = movieId,
                    HallID = hallId,
                    ShowDate = showDate.Date,
                    StartTime = startTime,
                    EndTime = endTime,
                    MoviePriceID = moviePriceId,
                    Screening = screening
                });
            }
        }

        public List<ShowtimeDetail> GetAllShowtimes(int hallId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = ShowtimeSQL.RetrieveShowtime;
                return connection.Query<ShowtimeDetail>(ShowtimeSQL.RetrieveShowtime, new { HallID = hallId }).ToList();
            }
        }

        public void UpdateShowtime(int showtimeId, DateTime showDate, TimeSpan startTime, TimeSpan endTime, int moviePriceId, int screening)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(ShowtimeSQL.UpdateShowtime, new
                {
                    ShowtimeID = showtimeId,
                    ShowDate = showDate,
                    StartTime = startTime,
                    EndTime = endTime,
                    MoviePriceID = moviePriceId,
                    Screening = screening
                });
            }
        }

        public void DeleteShowtime(int showtimeId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(ShowtimeSQL.DeleteShowtime, new { ShowtimeID = showtimeId });
            }
        }
    }
}
