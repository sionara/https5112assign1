using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace https5112assign1.Controllers
{
    public class AddTenController : ApiController
    {
        // GET: api/AddTen/10 -> 20
        // GET: api/AddTen/-9 -> 1
        /// <summary>
        /// Adds 10 to the input number.
        /// </summary>
        /// <param name="id">The input number to add to.</param>
        /// <returns>Input number plus 10.</returns>

        public int Get(int id)
        {
            int addten = id + 10;
            return addten;
        }

    }
}
