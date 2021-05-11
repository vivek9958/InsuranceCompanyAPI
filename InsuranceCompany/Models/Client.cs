using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceCompany.Models
{
    public class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Occupation { get; set; }
        public long DeathSumInsured { get; set; }

    }
}