﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.ModelSeat
{
    public class Seat
    {
        public int SeatID { get; set; }
        public int HallID { get; set; }
        public string SeatNumber { get; set; }
        public int IsAvailable { get; set; }
    }
}
