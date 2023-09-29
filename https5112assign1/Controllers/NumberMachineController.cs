using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace https5112assign1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Apply 4 different mathematical operations to the input number and return the same value.
        /// </summary>
        /// <param name="id">The user-inputted number.</param>
        /// <returns>
            //GET: api/NumberMachine/10 -> 10
            //GET: api/NumberMachine/-5 -> -5
            //GET: api/NumberMachine/30 -> 30
        /// </returns>
        public int Get(int id)
        {
            int newNum = (((id + id) / 2) * 1) - 0;
            return newNum;
        }
    }
}
