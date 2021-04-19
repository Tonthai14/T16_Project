using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Models
{
    public class DisplayStaffRideModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name of ride is too long.")]
        [MinLength(2, ErrorMessage = "Name of ride is too short.")]
        public string RideName { get; set; }
        [Required]
        public int TimesRidden { get; set; }
        [Required]
        public int TicketsToRide { get; set; }
    }
}
