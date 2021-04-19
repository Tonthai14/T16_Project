using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class CustomerReportModel
    {
        public DateTime Date { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int NumCustomers { get; set; }
        public bool IsGenerated { get; set; }
    }
}
