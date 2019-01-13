using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.ViewModels
{
    public class RecieptView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Models.Type? MassageType { get; set; }
        public int Hours { get; set; }
        public int NumberVisits { get; set; }
    }
}