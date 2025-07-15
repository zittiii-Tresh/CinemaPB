using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.ModelMovie
{
    public class MoviePrice
    {
        public int MoviePriceID { get; set; }
        public int MovieID { get; set; }
        public string DayType { get; set; }
        public decimal Price { get; set; }
    }
}
