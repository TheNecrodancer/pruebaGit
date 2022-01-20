using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonasApi.Models;
using R10_EFconASPyMVC.Models;

namespace R11_ApiRestScaffolding.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly MyDBContext _context;

        public TrabajadoresController(MyDBContext context)
        {
            _context = context;
        }

        // GET: api/Trabajadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trabajador>>> GetTrabajador()
        {
            return await _context.Trabajador.ToListAsync();
        }

        // GET: api/Trabajadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trabajador>> GetTrabajador(int id)
        {
            var trabajador = await _context.Trabajador.FindAsync(id);

            if (trabajador == null)
            {
                return NotFound();
            }

            return trabajador;
        }

        // PUT: api/Trabajadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrabajador(int id, Trabajador trabajador)
        {
            if (id != trabajador.Id)
            {
                return BadRequest();
            }

            _context.Entry(trabajador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrabajadorExists(id))
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

        // POST: api/Trabajadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Trabajador>> PostTrabajador(Trabajador trabajador)
        {
            _context.Trabajador.Add(trabajador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrabajador", new { id = trabajador.Id }, trabajador);
        }

        // DELETE: api/Trabajadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrabajador(int id)
        {
            var trabajador = await _context.Trabajador.FindAsync(id);
            if (trabajador == null)
            {
                return NotFound();
            }

            _context.Trabajador.Remove(trabajador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrabajadorExists(int id)
        {
            return _context.Trabajador.Any(e => e.Id == id);
        }
    }
}
