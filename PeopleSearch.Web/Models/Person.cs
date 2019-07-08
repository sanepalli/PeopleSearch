using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleSearch.Web.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Nullable<int> Age { get; set; }
        public string Interests { get; set; }
        public string Picture { get; set; }
    }
}