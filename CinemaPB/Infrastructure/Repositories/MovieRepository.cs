using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPB.ModelMovie;
using Dapper;
using System.Drawing;
using CinemaPB.Infrastructure.SQL;
using System.Data;

namespace CinemaPB.Infrastructure.Repositories
{
    public class MovieRepository
    {
        private readonly string _connectionString;

        public MovieRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ModelMovie.Genre> Genres()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = SQL.MovieSQL.GetListOfGenre;

                return connection.Query<ModelMovie.Genre>(query).ToList();
            }
        }

        public List<ModelMovie.Language> Languages()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = SQL.MovieSQL.GetListOfLanguage;

                return connection.Query<ModelMovie.Language>(query).ToList();
            }
        }

        public List<ModelMovie.ContentRating> ContentRatings()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = SQL.MovieSQL.GetListOfContentRating;

                return connection.Query<ModelMovie.ContentRating>(query).ToList();
            }
        }

        public int InsertMovie(Movie movie)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@Title", movie.Title);
                parameters.Add("@GenreID", movie.GenreID);
                parameters.Add("@Description", movie.Description);
                parameters.Add("@Duration", movie.Duration);
                parameters.Add("@LanguageID", movie.LanguageID);
                parameters.Add("@Poster", ImageToByteArray(movie.Poster)); // helper method
                parameters.Add("@Availability", movie.Availability);
                parameters.Add("@RatingID", movie.RatingID);
                parameters.Add("@MovieID", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute(MovieSQL.InsertMovie, parameters);

                return parameters.Get<int>("@MovieID"); // 🎯 MovieID after insert
            }
        }
        public void InsertMoviePrice(int movieId, string dayType, decimal price)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO mov.MoviePrices (MovieID, DayType, Price)
                         VALUES (@MovieID, @DayType, @Price)";

                connection.Execute(query, new { MovieID = movieId, DayType = dayType, Price = price });
            }
        }

        public byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (var ms = new MemoryStream())
            {
                using (var bitmap = new Bitmap(image)) // clone image to avoid GDI+ lock
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // use fixed format
                }
                return ms.ToArray();
            }
        }

        public void InsertGenre(Genre genre)
        {
            using (var connection = new SqlConnection(_connectionString))
            { 
                var parameters = new
                {
                    genre.GenreName
                };
                connection.Execute(SQL.MovieSQL.InsertGenre, parameters);
            }
        }

        public void InsertLanguage(Language language)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    language.LanguageName
                };
                connection.Execute(SQL.MovieSQL.InsertLanguage, parameters);
            }
        }

        public void InsertMovieGenre(int movieId, int genreId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO mov.MovieGenres (MovieID, GenreID) VALUES (@MovieID, @GenreID)";
                connection.Execute(sql, new { MovieID = movieId, GenreID = genreId });
            }
        }

        public List<MovieWithDetail> GetAllMovieDetails()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<MovieWithDetail>(MovieSQL.RetrieveMoviePriceAndDetails).ToList();
                return result;
            }
        }
        public List<MoviePrice> GetMoviePrices(int movieId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT MoviePriceID, MovieID, DayType, Price 
                         FROM mov.MoviePrices 
                         WHERE MovieID = @MovieID";

                return connection.Query<MoviePrice>(query, new { MovieID = movieId }).ToList();
            }
        }
        public void UpdateMovie(Movie movie)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(MovieSQL.UpdateMovie, new
                {
                    movie.Title,
                    movie.Description,
                    movie.Duration,
                    movie.LanguageID,
                    movie.RatingID,
                    movie.Availability,
                    Poster = ImageToByteArray(movie.Poster),
                    movie.MovieID
                });
            }
        }

        public void UpdateMovieGenres(int movieId, List<int> genreIds)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(MovieSQL.DeleteMovieGenres, new { MovieID = movieId });

                foreach (var genreId in genreIds)
                {
                    connection.Execute(MovieSQL.InsertMovieGenre, new { MovieID = movieId, GenreID = genreId });
                }
            }
        }

        public void UpdateMoviePrice(int movieId, string dayType, decimal price)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var exists = connection.ExecuteScalar<int>(MovieSQL.CheckIfMoviePriceExists,
                    new { MovieID = movieId, DayType = dayType }) > 0;

                if (exists)
                {
                    connection.Execute(MovieSQL.UpdateMoviePrice, new { MovieID = movieId, DayType = dayType, Price = price });
                }
                else
                {
                    connection.Execute(MovieSQL.InsertMoviePrice, new { MovieID = movieId, DayType = dayType, Price = price });
                }
            }
        }

        public void DeleteMovie(int movieId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(MovieSQL.DeleteMovieGenres, new { MovieID = movieId });
                connection.Execute(MovieSQL.DeleteMoviePrices, new { MovieID = movieId });
                connection.Execute(MovieSQL.DeleteMovie, new { MovieID = movieId });
            }
        }

        public List<MovieShowtimeInfo> GetMovieShowtimeList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"
                SELECT M.Title, S.HallID, S.StartTime, S.Screening
                FROM dbo.Showtime S
                LEFT JOIN mov.Movies M ON M.MovieID = S.MovieID";

                return connection.Query<MovieShowtimeInfo>(sql).ToList();
            }
        }
    }
}
