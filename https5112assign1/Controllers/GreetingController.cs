using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace https5112assign1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Displays the string, "Hello World!".
        /// <returns>The string "Hello World!".</returns>
        /// GET: api/Greeting/ -> Hello World!
        public string Post()
        {
            string helloworld = "Hello World!";
            return helloworld;
        }
    }
}
