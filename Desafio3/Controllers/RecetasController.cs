using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Desafio3.Models;
using Microsoft.AspNetCore.Authorization;

namespace Desafio3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class RecetasController : ControllerBase
    {
        private readonly RecetasDBContext _context;

        public RecetasController(RecetasDBContext context)
        {
            _context = context;
        }

        // GET: api/Recetas
        [HttpGet]
        [Authorize] //la info básica la pueden ver todos
        public async Task<ActionResult<IEnumerable<Receta>>> GetRecetas()
        {
            return await _context.Recetas.ToListAsync();
        }
        // GET: api/Recetas/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Receta>> GetReceta(int id)
        {
            var receta = await _context.Recetas.FindAsync(id);

            if (receta == null)
            {
                return NotFound();
            }

            return receta;
        }

        // PUT: api/Recetas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrador")] //modificaciones solo los admin
        public async Task<IActionResult> PutReceta(int id, Receta receta)
        {
            if (id != receta.Id)
            {
                return BadRequest();
            }

            _context.Entry(receta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecetaExists(id))
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

        // POST: api/Recetas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Receta>> PostReceta(Receta receta)
        {
            _context.Recetas.Add(receta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReceta", new { id = receta.Id }, receta);
        }

        // DELETE: api/Recetas/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> DeleteReceta(int id)
        {
            var receta = await _context.Recetas.FindAsync(id);
            if (receta == null)
            {
                return NotFound();
            }

            _context.Recetas.Remove(receta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecetaExists(int id)
        {
            return _context.Recetas.Any(e => e.Id == id);
        }
    }
}
