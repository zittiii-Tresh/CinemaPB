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

        public void InsertMovie(Movie movie)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var posterBytes = ImageToByteArray(movie.Poster); // ✅ This line needs `movie.Poster`

                var parameters = new
                {
                    movie.Title,
                    movie.GenreID,
                    movie.Description,
                    Duration = movie.Duration.ToString(@"hh\:mm\:ss"),
                    movie.LanguageID,
                    Poster = posterBytes,
                    Availability = movie.Availability == 1 ? 1 : 0,
                    movie.RatingID
                };

                connection.Execute(SQL.MovieSQL.InsertMovie, parameters);
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
    }
}
