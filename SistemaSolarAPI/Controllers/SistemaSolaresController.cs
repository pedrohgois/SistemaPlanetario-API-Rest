using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaSolarAPI.Data;
using SistemaSolarAPI.Entities;

namespace SistemaSolarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaSolaresController : ControllerBase
    {
        private readonly SistemaSolarAPIContext _context;

        public SistemaSolaresController(SistemaSolarAPIContext context)
        {
            _context = context;
        }

        // GET: api/SistemaSolares
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SistemaSolar>>> GetSistemaSolar()
        {
            return await _context.SistemaSolar.ToListAsync();
        }

        // GET: api/SistemaSolares/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SistemaSolar>> GetSistemaSolar(int id)
        {
            var sistemaSolar = await _context.SistemaSolar.FindAsync(id);

            if (sistemaSolar == null)
            {
                return NotFound();
            }

            return sistemaSolar;
        }

        // PUT: api/SistemaSolares/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSistemaSolar(int id, SistemaSolar sistemaSolar)
        {
            if (id != sistemaSolar.Id)
            {
                return BadRequest();
            }

            _context.Entry(sistemaSolar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SistemaSolarExists(id))
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

        // POST: api/SistemaSolares
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SistemaSolar>> PostSistemaSolar(SistemaSolar sistemaSolar)
        {
            _context.SistemaSolar.Add(sistemaSolar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSistemaSolar", new { id = sistemaSolar.Id }, sistemaSolar);
        }

        // DELETE: api/SistemaSolares/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSistemaSolar(int id)
        {
            var sistemaSolar = await _context.SistemaSolar.FindAsync(id);
            if (sistemaSolar == null)
            {
                return NotFound();
            }

            _context.SistemaSolar.Remove(sistemaSolar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SistemaSolarExists(int id)
        {
            return _context.SistemaSolar.Any(e => e.Id == id);
        }
    }
}
