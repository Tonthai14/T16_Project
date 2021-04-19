using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Payment { get; set; }
        public string EnteredPark { get; set; }
        public string LeftPark { get; set; }
        public string EmailAddress { get; set; }
    }
}
