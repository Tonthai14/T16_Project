using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Models
{
    public class DisplayRidesModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name of ride too long.")]
        [MinLength(2, ErrorMessage = "Name of ride too short.")]
        public string RideName { get; set; }

        [Required]
        public string TicketsRequired { get; set; }

    }
}
