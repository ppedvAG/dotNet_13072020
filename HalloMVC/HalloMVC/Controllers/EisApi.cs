using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HalloMVC.Data;
using HalloMVC.Models;

namespace HalloMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EisApi : ControllerBase
    {
        private readonly HalloMVCContext _context;

        public EisApi(HalloMVCContext context)
        {
            _context = context;
        }

        // GET: api/EisApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eis>>> GetEis()
        {
            return await _context.Eis.ToListAsync();
        }

        // GET: api/EisApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eis>> GetEis(int id)
        {
            var eis = await _context.Eis.FindAsync(id);

            if (eis == null)
            {
                return NotFound();
            }

            return eis;
        }

        // PUT: api/EisApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEis(int id, Eis eis)
        {
            if (id != eis.Id)
            {
                return BadRequest();
            }

            _context.Entry(eis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EisExists(id))
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

        // POST: api/EisApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eis>> PostEis(Eis eis)
        {
            _context.Eis.Add(eis);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEis", new { id = eis.Id }, eis);
        }

        // DELETE: api/EisApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eis>> DeleteEis(int id)
        {
            var eis = await _context.Eis.FindAsync(id);
            if (eis == null)
            {
                return NotFound();
            }

            _context.Eis.Remove(eis);
            await _context.SaveChangesAsync();

            return eis;
        }

        private bool EisExists(int id)
        {
            return _context.Eis.Any(e => e.Id == id);
        }
    }
}
