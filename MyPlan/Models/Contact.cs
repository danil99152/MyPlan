using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlan.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public ICollection<Number> Numbers { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Another { get; set; }

    }
}