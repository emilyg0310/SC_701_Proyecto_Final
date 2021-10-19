﻿using System;
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
    public class CalculoMaterisController : ControllerBase
    {
        private readonly calcuMateriContext _context;

        public CalculoMaterisController(calcuMateriContext context)
        {
            _context = context;
        }

        // GET: api/CalculoMateris
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalculoMateri>>> GetCalculoMateri()
        {
            return await _context.CalculoMateri.ToListAsync();
        }

        // GET: api/CalculoMateris/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalculoMateri>> GetCalculoMateri(int id)
        {
            var calculoMateri = await _context.CalculoMateri.FindAsync(id);

            if (calculoMateri == null)
            {
                return NotFound();
            }

            return calculoMateri;
        }

        // PUT: api/CalculoMateris/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalculoMateri(int id, CalculoMateri calculoMateri)
        {
            if (id != calculoMateri.IdCalMateri)
            {
                return BadRequest();
            }

            _context.Entry(calculoMateri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalculoMateriExists(id))
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

        // POST: api/CalculoMateris
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CalculoMateri>> PostCalculoMateri(CalculoMateri calculoMateri)
        {
            _context.CalculoMateri.Add(calculoMateri);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalculoMateri", new { id = calculoMateri.IdCalMateri }, calculoMateri);
        }

        // DELETE: api/CalculoMateris/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CalculoMateri>> DeleteCalculoMateri(int id)
        {
            var calculoMateri = await _context.CalculoMateri.FindAsync(id);
            if (calculoMateri == null)
            {
                return NotFound();
            }

            _context.CalculoMateri.Remove(calculoMateri);
            await _context.SaveChangesAsync();

            return calculoMateri;
        }

        private bool CalculoMateriExists(int id)
        {
            return _context.CalculoMateri.Any(e => e.IdCalMateri == id);
        }
    }
}