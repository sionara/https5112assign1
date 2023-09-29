using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace https5112assign1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Output a message breaking down total hosting cost by FN rate + tax.
        /// </summary>
        /// <param name="id"> User input indicating the number of days they used the hosting service</param>
        /// <returns>
        // GET: api/HostingCost/0 -> 1 fortnights at $5.50/FN = $5.50 CAD
        // HST 13% = $0.72 CAD
        // Total = $6.22 CAD
        // GET: api/HostingCost/14 -> 2 fortnights at $5.50/FN = $11.00 CAD
        // HST13% = $1.43 CAD
        // Total = $12.43 CAD
        /// </returns>
        [HttpGet]
        public IEnumerable<string> HostingCosts(int id)
        {   
            //Used IEnumerable method to display three string objects in multiple lines. Found in ValueController file.
            //intialize variables to hold values
            //had to use Math.Round to round values to 2 decimal places.
            decimal numFortnight = Math.Floor(id / 14m) + 1;
            decimal hostingCost = Math.Round(numFortnight * (decimal)5.50, 3); 
            decimal taxCost = Math.Round(hostingCost * (decimal)0.13, 2);
            decimal totalCost = Math.Round(hostingCost + taxCost, 2);

            //message to return
            string line1 = numFortnight + " fortnights at $5.50/FN = " + "$" + hostingCost.ToString("0.00") + " CAD";
            string line2 = "HST 13 % = " + taxCost + " CAD";
            string line3 = "Total = " + totalCost + " CAD";
            
            

            return new string[] { line1, line2, line3 };

        }
    }
}
