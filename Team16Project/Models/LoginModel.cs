using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team16Project.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(8, ErrorMessage = "User ID is too long.")]
        [MinLength(1, ErrorMessage = "User ID is too short.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "User ID must be a number.")]
        public string UserID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Password is too long.")]
        [MinLength(2, ErrorMessage = "Password is too short.")]
        public string Password { get; set; }
    }
}