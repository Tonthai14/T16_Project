using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class RideModel
    {
        public int RideId { get; set; }
        public int TimesRidden { get; set; }
        public int TicketsToRide { get; set; }
        public int TicketsUsed { get; set; }
    }
}
