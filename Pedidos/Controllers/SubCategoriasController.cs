using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pedidos;
using Pedidos.Models;

namespace Pedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriasController : ControllerBase
    {
        private readonly PedidoDbContext _context;

        public SubCategoriasController(PedidoDbContext context)
        {
            _context = context;
        }

        // GET: api/SubCategorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategoria>>> GetSubCategoria()
        {
            return await _context.SubCategoria.Include(x => x.categoria).ToListAsync();
        }

        // GET: api/SubCategorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategoria>> GetSubCategoria(string id)
        {
            var subCategoria = await _context.SubCategoria.FindAsync(id);

            if (subCategoria == null)
            {
                return NotFound();
            }

            return subCategoria;
        }

        // PUT: api/SubCategorias/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubCategoria(int id, SubCategoria subCategoria)
        {
            if (id != subCategoria.id)
            {
                return BadRequest();
            }

            _context.Entry(subCategoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubCategoriaExists(id))
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

        // POST: api/SubCategorias
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SubCategoria>> PostSubCategoria(SubCategoria subCategoria)
        {
            _context.SubCategoria.Add(subCategoria);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SubCategoriaExists(subCategoria.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSubCategoria", new { id = subCategoria.id }, subCategoria);
        }

        // DELETE: api/SubCategorias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubCategoria>> DeleteSubCategoria(string id)
        {
            var subCategoria = await _context.SubCategoria.FindAsync(id);
            if (subCategoria == null)
            {
                return NotFound();
            }

            _context.SubCategoria.Remove(subCategoria);
            await _context.SaveChangesAsync();

            return subCategoria;
        }

        private bool SubCategoriaExists(int id)
        {
            return _context.SubCategoria.Any(e => e.id == id);
        }
    }
}
