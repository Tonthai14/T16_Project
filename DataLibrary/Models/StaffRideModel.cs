using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class StaffRideModel
    {
        public int RideId { get; set; }
        public string RideName { get; set; }
        public int TimesRidden { get; set; }
        public int TicketsToRide { get; set; }
    }
}
