using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Models
{
    public class DisplayRideModel
    {
        [Required]
        public int TicketsToRide { get; set; }
        public int TimesRidden { get; set; }
        public int TicketsUsed { get; set; }
    }
}
