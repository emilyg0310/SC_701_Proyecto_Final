using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaCrsController : ControllerBase
    {
        private readonly calcuMateriContext _context;

        public ProvinciaCrsController(calcuMateriContext context)
        {
            _context = context;
        }

        // GET: api/ProvinciaCrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvinciaCr>>> GetProvinciaCr()
        {
            return await _context.ProvinciaCr.ToListAsync();
        }

        // GET: api/ProvinciaCrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinciaCr>> GetProvinciaCr(short id)
        {
            var provinciaCr = await _context.ProvinciaCr.FindAsync(id);

            if (provinciaCr == null)
            {
                return NotFound();
            }

            return provinciaCr;
        }

        // PUT: api/ProvinciaCrs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvinciaCr(short id, ProvinciaCr provinciaCr)
        {
            if (id != provinciaCr.CodigoProvincia)
            {
                return BadRequest();
            }

            _context.Entry(provinciaCr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciaCrExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProvinciaCrs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProvinciaCr>> PostProvinciaCr(ProvinciaCr provinciaCr)
        {
            _context.ProvinciaCr.Add(provinciaCr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProvinciaCr", new { id = provinciaCr.CodigoProvincia }, provinciaCr);
        }

        // DELETE: api/ProvinciaCrs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProvinciaCr>> DeleteProvinciaCr(short id)
        {
            var provinciaCr = await _context.ProvinciaCr.FindAsync(id);
            if (provinciaCr == null)
            {
                return NotFound();
            }

            _context.ProvinciaCr.Remove(provinciaCr);
            await _context.SaveChangesAsync();

            return provinciaCr;
        }

        private bool ProvinciaCrExists(short id)
        {
            return _context.ProvinciaCr.Any(e => e.CodigoProvincia == id);
        }
    }
}
