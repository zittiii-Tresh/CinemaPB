using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.ModelShowing
{
    public class ShowingCard
    {
        public int ShowtimeID { get; set; }
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genres { get; set; }
        public string Duration { get; set; }
        public string RatingName { get; set; }
        public string ShowDate { get; set; }
        public string First { get; set; }  // Time 1 (e.g. "9:30 AM - 11:15 AM")
        public string Second { get; set; }
        public string Last { get; set; }
        public int Screening { get; set; }

        public byte[] Poster { get; set; }

        public Image PosterImage
        {
            get
            {
                if (Poster == null) return null;
                using (var ms = new MemoryStream(Poster))
                {
                    return Image.FromStream(ms);
                }
            }
        }
    }
}
