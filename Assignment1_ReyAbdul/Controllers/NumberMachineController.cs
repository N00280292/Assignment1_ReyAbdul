using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_ReyAbdul.Controllers
{
    public class NumberMachineController : ApiController
    {
        // GET api/NumberMachine/{id}
        //Question 5: Number Machine
        //Answer: 86, -34, 246
        public IEnumerable<int> Get(int id)
        {
            return new int[] { (id * 8) + 8 - 4 / 2 };
        }
    }
}
