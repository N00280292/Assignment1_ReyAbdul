using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_ReyAbdul.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting
        //Questions 4: Greeting
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Greeting/5
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to " + id + " people!" };
        }

        // Post api/Greeting
        //Questions 3: Greeting
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World" };
        }

    }
}
