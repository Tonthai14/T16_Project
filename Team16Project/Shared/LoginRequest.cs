using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Shared
{
    public class LoginRequest
    {
        [Required]
        [StringLength(10)]
        public string StaffId { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
