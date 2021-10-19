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
    public class CantonCrsController : ControllerBase
    {
        private readonly calcuMateriContext _context;

        public CantonCrsController(calcuMateriContext context)
        {
            _context = context;
        }

        // GET: api/CantonCrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CantonCr>>> GetCantonCr()
        {
            return await _context.CantonCr.ToListAsync();
        }

        // GET: api/CantonCrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CantonCr>> GetCantonCr(short id)
        {
            var cantonCr = await _context.CantonCr.FindAsync(id);

            if (cantonCr == null)
            {
                return NotFound();
            }

            return cantonCr;
        }

        // PUT: api/CantonCrs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCantonCr(short id, CantonCr cantonCr)
        {
            if (id != cantonCr.CodigoCanton)
            {
                return BadRequest();
            }

            _context.Entry(cantonCr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CantonCrExists(id))
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

        // POST: api/CantonCrs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CantonCr>> PostCantonCr(CantonCr cantonCr)
        {
            _context.CantonCr.Add(cantonCr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCantonCr", new { id = cantonCr.CodigoCanton }, cantonCr);
        }

        // DELETE: api/CantonCrs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CantonCr>> DeleteCantonCr(short id)
        {
            var cantonCr = await _context.CantonCr.FindAsync(id);
            if (cantonCr == null)
            {
                return NotFound();
            }

            _context.CantonCr.Remove(cantonCr);
            await _context.SaveChangesAsync();

            return cantonCr;
        }

        private bool CantonCrExists(short id)
        {
            return _context.CantonCr.Any(e => e.CodigoCanton == id);
        }
    }
}
