using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_ReyAbdul.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id}
        //Question 6: Intiative Question



        public IEnumerable<string> GetCost(int id)
        {
            double FN = (id/14) * 5.50; //the 5.50 here is the 'fee'. FN= Fortnight 
            double fee = 5.50; //I don't know how to display the full number below, it shows up as '5.5'. Also, the 5.50 rate will always be charged eve if 0 days were stayed, hence +5.50 to fill the gap.
            double tax = 1.13;// how I implemented tax without going through a longer process (easier for me)
            double total = Math.Round((FN + fee) * tax,2);//I looked up Math.Round online.
            return new string[] { $" " + id + " Fortnight at " + fee + " CAD", "HST 13% =" + Math.Round((FN + fee) * tax, 2), "Total= " + total};

            //Summary: I don't know if there was an easier way to get the answer because I feel like it went through a roundabout way to achieve this goal. I think there are unnessary variables in the equation but I could be wrong either way.
                   


        }
    }
}
