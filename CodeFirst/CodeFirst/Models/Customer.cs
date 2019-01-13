using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int Number_Of_Visits { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}