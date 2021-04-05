using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Data
{
    public class Ride
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Breakdowns { get; set; }
        public int TicketsRequired { get; set; }
        public int TicketsUsed { get; set; }
    }
}
