using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Models
{
    public class DisplayRideDateModel
    {
        [Required]
        [Range(4, 100, ErrorMessage ="Please enter a valid number")]
        public int TicketsUsed { get; set; }
    }
}
