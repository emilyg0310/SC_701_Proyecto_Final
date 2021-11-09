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
    public class MaterialesController : ControllerBase
    {
        private readonly CalculoMateContext _context;

        public MaterialesController(CalculoMateContext context)
        {
            _context = context;
        }

        // GET: api/Materiales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materiales>>> GetMateriales()
        {
            return await _context.Materiales.ToListAsync();
        }

        // GET: api/Materiales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materiales>> GetMateriales(int id)
        {
            var materiales = await _context.Materiales.FindAsync(id);

            if (materiales == null)
            {
                return NotFound();
            }

            return materiales;
        }

        // PUT: api/Materiales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateriales(int id, Materiales materiales)
        {
            if (id != materiales.IdMaterial)
            {
                return BadRequest();
            }

            _context.Entry(materiales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialesExists(id))
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

        // POST: api/Materiales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Materiales>> PostMateriales(Materiales materiales)
        {
            _context.Materiales.Add(materiales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMateriales", new { id = materiales.IdMaterial }, materiales);
        }

        // DELETE: api/Materiales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Materiales>> DeleteMateriales(int id)
        {
            var materiales = await _context.Materiales.FindAsync(id);
            if (materiales == null)
            {
                return NotFound();
            }

            _context.Materiales.Remove(materiales);
            await _context.SaveChangesAsync();

            return materiales;
        }

        private bool MaterialesExists(int id)
        {
            return _context.Materiales.Any(e => e.IdMaterial == id);
        }
    }
}
