using InsuranceCompany.Models;
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
        public long Post([FromBody]Client value)
        {
            int ratingFactor = 1;  // Create a dictionary with all the Occupation Rating and find the matching one to get the exact factor 
            return (value.DeathSumInsured * ratingFactor * value.Age) / 1000 * 12;
            //Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12

        }
    }
}