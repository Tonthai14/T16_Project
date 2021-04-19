using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Models
{
    public class DisplayMaintenanceRideModel
    {
        [Required]
        public string RideName { get; set; }


        public int TimesRidden { get; set; }
        public string NeedsMaintenance { get; set; }


    }
}