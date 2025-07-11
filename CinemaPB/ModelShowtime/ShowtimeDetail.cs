using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.ModelShowtime
{
    public class ShowtimeDetail
    {
        public int ShowtimeID { get; set; }
        public string Title { get; set; }
        public TimeSpan StartTime { get; set; }  
        public TimeSpan EndTime { get; set; }    
        public string DayType { get; set; }
        public decimal Price { get; set; }
        public DateTime ShowDate { get; set; }

        
        public string StartTimeFormatted => DateTime.Today.Add(StartTime).ToString("h:mmtt");
        public string EndTimeFormatted => DateTime.Today.Add(EndTime).ToString("h:mmtt");
    }
}
