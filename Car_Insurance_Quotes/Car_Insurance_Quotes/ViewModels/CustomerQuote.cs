using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Insurance_Quotes.ViewModels
{
    public class CustomerQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Quote { get; set; }
    }
}