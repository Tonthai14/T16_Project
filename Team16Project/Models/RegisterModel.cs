using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team16Project.Models
{
    public class RegisterModel
    {
        [Required]
        [RegularExpression("([a-zA-Z]+)", ErrorMessage = "First Name must only contain letters.")]
        public string FirstName { get; set; }

        [RegularExpression("([a-zA-Z]+)", ErrorMessage = "Middle Name must only contain letters.")]
        public string MiddleName { get; set; }

        [Required]
        [RegularExpression("([a-zA-Z]+)", ErrorMessage = "Last Name must only contain letters.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Password is too long.")]
        [MinLength(2, ErrorMessage = "Password is too short.")]
        public string Password { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Password is too long.")]
        [MinLength(2, ErrorMessage = "Password is too short.")]
        public string ConfirmPassword { get; set; }
    }
}
