using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaPB.ModelMovie
{
    public class MovieShowtimeInfo
    {
        public string Title { get; set; }
        public int HallID { get; set; }
        public TimeSpan StartTime { get; set; }
        public string Screening { get; set; }
    }
}
