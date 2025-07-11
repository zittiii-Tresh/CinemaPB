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
                image.Save(ms, image.RawFormat);
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

        public List<MovieWithDetail> GetAllMovieDetails()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<MovieWithDetail>(MovieSQL.RetrieveMoviePriceAndDetails).ToList();
                return result;
            }
        }
    }
}
