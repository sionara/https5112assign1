﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace https5112assign1.Controllers
{
    public class SquareController : ApiController
    {
        // GET: api/squarenum/-4 -> 16
        // GET: api/squarenum/4 -> 16

        /// <summary>
        /// Squares the input number.
        /// </summary>
        /// <param name="id">The input number to square.</param>
        /// <returns>Input number squared.</returns>

        public int Get(int id)
        {
            int squarenum = id * id;
            return squarenum;
        }
    }
}
