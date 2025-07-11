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
                return connection.QuerySingle<int>(ShowtimeSQL.GetMoviePriceID, new { MovieID = movieId, DayType = dayType });
            }
        }

        public void InsertShowtime(int movieId, int hallId, DateTime showDate, TimeSpan startTime, TimeSpan endTime, int moviePriceId)
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
                    MoviePriceID = moviePriceId
                });
            }
        }

        public List<ShowtimeDetail> GetAllShowtimes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = ShowtimeSQL.RetrieveShowtime;
                return connection.Query<ShowtimeDetail>(sql).ToList(); // Dapper maps to model
            }
        }

    }
}
