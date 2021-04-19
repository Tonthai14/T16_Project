using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Models
{
    public class DisplayRideModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long.")]
        [MinLength(2, ErrorMessage = "Name is too short.")]
        public string RideName { get; set; }
        [Required]
        public int TicketsToRide { get; set; }
        public int TimesRidden { get; set; }
        public int TicketsUsed { get; set; }
    }
}
