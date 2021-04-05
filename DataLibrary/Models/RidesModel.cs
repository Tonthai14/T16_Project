using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class RidesModel
    {
        public int ride_id { get; set; }
        public int times_ridden { get; set; }
        public int breakdowns { get; set; }
        public string tickets_to_ride { get; set; }
        public string tickets_used { get; set; }
        public string ride_name { get; set; }

    }
}
