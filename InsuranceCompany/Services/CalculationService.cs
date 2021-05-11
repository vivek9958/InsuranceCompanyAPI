using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceCompany.Services
{
    public static class CalculationService
    {

        public static IDictionary<string, double> GetOccupationRatings()
        {
            return new Dictionary<string, double>()
           {
               {"Professional", 1.0 },
               {"White Collar", 1.25 },
               {"Light Manual", 1.50 },
               {"Heavy Manual", 1.75 }
           };


        }
    }
}