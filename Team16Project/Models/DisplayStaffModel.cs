using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Models
{
    public class DisplayStaffModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "First name is too long.")]
        [MinLength(2, ErrorMessage = "First name is too short.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last name is too long.")]
        [MinLength(2, ErrorMessage = "Last name is too short.")]
        public string LastName { get; set; }

        [Required]
        public string Job { get; set; }
    }
}
