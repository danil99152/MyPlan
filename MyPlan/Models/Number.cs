using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlan.Models
{
    public class Number
    {
        public int NumberID { get; set; }
        public int ContactID { get; set; }
        public long PhoneNumber { get; set; }
        public virtual Contact Contact { get; set; }
    }
}