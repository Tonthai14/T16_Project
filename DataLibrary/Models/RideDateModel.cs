using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class RideDateModel
    {
        public DateTime Date { get; set; }
        public int RideId { get; set; }
        public int TicketsUsed { get; set; }
        public int TimesRidden { get; set; }
    }
}
