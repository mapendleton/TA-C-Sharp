using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public enum Type
    {
        leg, foot, back
    }
    public class Visit
    {
        public int VisitId { get; set; }
        public int CustomerId { get; set; }
        public Type? MassageType { get; set; }
        public int Hours { get; set; }

        public virtual Customer Customer { get; set; }
    }
}