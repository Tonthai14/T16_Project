using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class ReportModel
    {
        public string ReportType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsGenerated { get; set; }
    }
}
