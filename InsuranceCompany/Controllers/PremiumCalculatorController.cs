using InsuranceCompany.Models;
using InsuranceCompany.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InsuranceCompany.Controllers
{
    [RoutePrefix("Api/PremiumCalculator")]
    public class PremiumCalculatorController : ApiController
    {
        
        [HttpGet]
        [Route("test")]
        public int Get()
        {
            return 11;
        }

        [HttpPost]
        [Route("calculate")]
        public double Post([FromBody]Client value)
        { 
            if (CalculationService.GetOccupationRatings().ContainsKey(value.Occupation))
            {
                return ((value.DeathSumInsured * CalculationService.GetOccupationRatings()[value.Occupation] * value.Age) / 1000) * 12;
            } else
            {
                return 0;  // Throw exception for input field
            }
            //Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12

        }
    }
}