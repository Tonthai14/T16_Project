using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class RideReportModel
    {
        public int RideId { get; set; }
        public string RideName { get; set; }
        public decimal TimesRidden { get; set; }
        public bool IsGenerated { get; set; }
    }
}
