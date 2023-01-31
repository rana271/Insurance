using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using Insurance.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using Insurance.Repository;

namespace Insurance.Controllers
{

    [Route("[controller]")]
    public class PremiumCalculatorController : ControllerBase
    {
        private readonly IInsurance _insurance;
       


        public PremiumCalculatorController(IInsurance insurance) {
            _insurance = insurance;
        }
        
        
        [HttpPost]
       
        public string CalculatePremiumAction([FromBody] InsuranceModel model)
        {
            string totalPremium=string.Empty;
            if (!ModelState.IsValid)
            {
                return "Bad request";
            }
            try
            {
                totalPremium = _insurance.CalculatePremium(model).ToString();
            }
            catch (Exception)
            {
                throw;
            }

            return totalPremium;






        }
       
    }
}
