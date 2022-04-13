using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductdetWEBAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductdetWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            CollegeContext cnt = new CollegeContext();
            return cnt.Product;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IEnumerable<Product> Get(int id)
        {
            CollegeContext cnt = new CollegeContext();
            var sql = from i in cnt.Product where i.Pcode == id select i;
            return sql;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            CollegeContext cnt = new CollegeContext();
            {
                cnt.Product.Add(value);
                cnt.SaveChanges();
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            CollegeContext cnt = new CollegeContext();
            var prodet = cnt.Product.Find(id);
            if (prodet != null)
            {
                prodet.Pname = value.Pname;
                prodet.Pdesc = value.Pdesc;
                prodet.UnitPrice = value.UnitPrice;
                prodet.Category = value.Category;
                prodet.Stockinhand = value.Stockinhand;
                cnt.SaveChanges();
            }
        }
    

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CollegeContext cnt = new CollegeContext();
            var obj = cnt.Product.Find(id);
            cnt.Product.Remove(obj);
            cnt.SaveChanges();
        }
    }
}
