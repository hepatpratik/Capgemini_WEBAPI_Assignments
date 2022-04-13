using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerWEBAPI.Model;

namespace CustomerWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        List<Customer> Slist = new List<Customer>()
                {

                    new Customer() { cid = 1, cname = "Pratik", caddr = "Samudrapur", contactno =8180811916 ,cmailaddr="pratik@gmail.com"},
                    new Customer() { cid = 2, cname = "Akshat", caddr = "Wardha", contactno =1235678902 ,cmailaddr="akshat@gmail.com"},
                    new Customer() { cid = 3, cname = "Sandeep", caddr = "Delhi", contactno =1728330433 ,cmailaddr="sandeep@gmail.com"},
                    new Customer() { cid = 4, cname = "Pradeep", caddr = "Wardha", contactno =1923839393 ,cmailaddr="pradeep@gmail.com"},
                    new Customer() { cid = 5, cname = "Ram", caddr = "Pune", contactno =637288234,cmailaddr="ram@gmail.com"},
                    new Customer() { cid = 6, cname = "Jayant", caddr = "Hinghanghat", contactno =2178288128,cmailaddr="jayant@gmail.com"},
                    new Customer() { cid = 7, cname = "Kartik", caddr = "Nagpur", contactno =1739292872 ,cmailaddr="kartik@gmail.com"},
                    new Customer() { cid = 8, cname = "Roy", caddr = "Mumbai", contactno =2827318278,cmailaddr="roy@gmail.com"},
                    new Customer() { cid = 9, cname = "King", caddr = "Chennai", contactno =1729126426 ,cmailaddr="king@gmail.com"},
                    new Customer() { cid = 10, cname = "Prem", caddr = "Pune", contactno =1262164276,cmailaddr="prem@gmail.com"},


                };

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> getallcust()
        {
            var result = from i in Slist select i;
            return result.ToList();
        }
    }
}