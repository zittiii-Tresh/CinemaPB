using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.ModelMovie
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public int LanguageID { get; set; }
        public Image Poster { get; set; }
        public int Availability { get; set; }
        public int RatingID { get; set; }
    }
}
