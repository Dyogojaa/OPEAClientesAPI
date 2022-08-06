using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPEA.ClienteAPI.DataBase;
using OPEA.ClienteAPI.Models;

namespace OPEA.ClienteAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TipoEmpresasController : ControllerBase
    {
        private readonly BDContext _context;

        public TipoEmpresasController(BDContext context)
        {
            _context = context;
        }

        // GET: api/TipoEmpresas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEmpresa>>> GetTipoEmpresas()
        {
          if (_context.TipoEmpresas == null)
          {
              return NotFound();
          }
            return await _context.TipoEmpresas.ToListAsync();
        }

        // GET: api/TipoEmpresas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoEmpresa>> GetTipoEmpresa(int id)
        {
          if (_context.TipoEmpresas == null)
          {
              return NotFound();
          }
            var tipoEmpresa = await _context.TipoEmpresas.FindAsync(id);

            if (tipoEmpresa == null)
            {
                return NotFound();
            }

            return tipoEmpresa;
        }

        // PUT: api/TipoEmpresas/5        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoEmpresa(int id,[FromBody] TipoEmpresa tipoEmpresa)
        {
            if (id != tipoEmpresa.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoEmpresa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoEmpresaExists(id))
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

        // POST: api/TipoEmpresas        
        [HttpPost]
        public async Task<ActionResult<TipoEmpresa>> PostTipoEmpresa( [FromBody]TipoEmpresa tipoEmpresa)
        {
          if (_context.TipoEmpresas == null)
          {
                return BadRequest("Dados Inválidos");
          }
            _context.TipoEmpresas.Add(tipoEmpresa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoEmpresa", new { id = tipoEmpresa.Id }, tipoEmpresa);
        }

        // DELETE: api/TipoEmpresas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoEmpresa(int id)
        {
            if (_context.TipoEmpresas == null)
            {
                return NotFound();
            }
            var tipoEmpresa = await _context.TipoEmpresas.FindAsync(id);
            if (tipoEmpresa == null)
            {
                return NotFound();
            }

            _context.TipoEmpresas.Remove(tipoEmpresa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoEmpresaExists(int id)
        {
            return (_context.TipoEmpresas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
