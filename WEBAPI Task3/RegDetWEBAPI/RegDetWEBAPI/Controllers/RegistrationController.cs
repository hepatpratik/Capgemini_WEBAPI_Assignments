using Microsoft.AspNetCore.Mvc;
using RegDetWEBAPI.Models;
using RegDetWEBAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegDetWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegController : ControllerBase
    {

        private IReg _rg;

        public RegController(IReg rg)
        {
            _rg = rg;
        }

        // GET: api/<RegController>
        [HttpGet]
        public async Task<IEnumerable<Registration>> getReg()
        {
            return await _rg.GetAllReg();
        }

        // GET api/<RegController>/5
        [HttpGet("{rid}")]
        public async Task<ActionResult<Registration>> getReg(int rid)
        {
            return await _rg.GetReg(rid);
        }

        // POST api/<RegController>
        [HttpPost]
        public async Task<ActionResult<Registration>> PostReg([FromBody] Registration Robj)
        {
            var newreg = await _rg.InsertReg(Robj);
            return CreatedAtAction(nameof(getReg), new { rid = newreg.Rid }, newreg);
        }

        // PUT api/<RegController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> updateReg(int rid, [FromBody] Registration Robj)
        {
            if (rid != Robj.Rid)
            {
                return BadRequest();
            }
            await _rg.UpdateReg(Robj);
            return NoContent();
        }

        // DELETE api/<RegController>/5
        [HttpDelete("{rid}")]
        public async Task<ActionResult> deleteReg(int rid)
        {
            var res = await _rg.GetReg(rid);
            if (res == null)
            {
                return NoContent();
            }
            await _rg.DeleteReg(rid);
            return NoContent();
        }
    }
}
