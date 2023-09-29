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
        /// </summary>
        /// <returns>
        //  POST: api/Greeting/ -> Hello World!
        /// </returns>

        [HttpPost]
        public string Post()
        {
            string helloworld = "Hello World!";
            return helloworld;
        }

        /// <summary>
        /// Returns a greeting message based on the amount of people the user inputs.
        /// </summary>
        /// <param name="id">User inputted number.</param>
        /// <returns>
        //  GET: api/Greeting/10 -> Greeting to 10 people!
        //  GET: api/Greeting/6 -> Greeting to 6 people!
        /// </returns>

        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
