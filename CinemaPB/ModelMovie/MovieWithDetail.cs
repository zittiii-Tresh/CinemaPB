using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.ModelMovie
{
    public class MovieWithDetail
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string LanguageName { get; set; }
        public int LanguageID { get; set; }
        public int RatingID { get; set; }
        public string RatingName { get; set; }
        public string Availability { get; set; }
        public byte[] Poster { get; set; }

        public string DurationFormatted => Duration;
    }

}
