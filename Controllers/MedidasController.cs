using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Change4Life.Models;

namespace Change4Life.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedidasController : ControllerBase
    {
        private readonly Change4LifeContext _context;

        public MedidasController(Change4LifeContext context)
        {
            _context = context;
        }

        // GET: api/Medidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medidas>>> GetMedidas()
        {
            return await _context.Medidas.ToListAsync();
        }

        // GET: api/Medidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medidas>> GetMedidas(Guid id)
        {
            var medidas = await _context.Medidas.FindAsync(id);

            if (medidas == null)
            {
                return NotFound();
            }

            return medidas;
        }

        // PUT: api/Medidas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedidas(Guid id, Medidas medidas)
        {
            if (id != medidas.Id)
            {
                return BadRequest();
            }

            _context.Entry(medidas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedidasExists(id))
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

        // POST: api/Medidas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Medidas>> PostMedidas(Medidas medidas)
        {
            _context.Medidas.Add(medidas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedidas", new { id = medidas.Id }, medidas);
        }

        // DELETE: api/Medidas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Medidas>> DeleteMedidas(Guid id)
        {
            var medidas = await _context.Medidas.FindAsync(id);
            if (medidas == null)
            {
                return NotFound();
            }

            _context.Medidas.Remove(medidas);
            await _context.SaveChangesAsync();

            return medidas;
        }

        private bool MedidasExists(Guid id)
        {
            return _context.Medidas.Any(e => e.Id == id);
        }
    }
}
