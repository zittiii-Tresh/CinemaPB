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
        public string Timeslot { get; set; }
        public int HallID { get; set; }
        public int MoviePriceID { get; set; }


        public int Screening { get; set; }
        public string ScreeningLabel
        {
            get
            {
                if (Screening == 1)
                    return "First Screening";
                else if (Screening == 2)
                    return "Second Screening";
                else if (Screening == 3)
                    return "Last Screening";
                else
                    return "Unknown";
            }
        }

        public string ScreeningTime { get; set; }

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
