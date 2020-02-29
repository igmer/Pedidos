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
    public class PedidoDetallesController : ControllerBase
    {
        private readonly PedidoDbContext _context;

        public PedidoDetallesController(PedidoDbContext context)
        {
            _context = context;
        }

        // GET: api/PedidoDetalles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedidoDetalle>>> GetPedidoDetalle()
        {
            return await _context.PedidoDetalle.Include( x => x.pedido).ToListAsync();
        }

        // GET: api/PedidoDetalles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PedidoDetalle>> GetPedidoDetalle(int id)
        {
            var pedidoDetalle = await _context.PedidoDetalle.FindAsync(id);

            if (pedidoDetalle == null)
            {
                return NotFound();
            }

            return pedidoDetalle;
        }

        // PUT: api/PedidoDetalles/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedidoDetalle(int id, PedidoDetalle pedidoDetalle)
        {
            if (id != pedidoDetalle.id)
            {
                return BadRequest();
            }

            _context.Entry(pedidoDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoDetalleExists(id))
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

        // POST: api/PedidoDetalles
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PedidoDetalle>> PostPedidoDetalle(PedidoDetalle pedidoDetalle)
        {
            _context.PedidoDetalle.Add(pedidoDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedidoDetalle", new { id = pedidoDetalle.id }, pedidoDetalle);
        }

        // DELETE: api/PedidoDetalles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PedidoDetalle>> DeletePedidoDetalle(int id)
        {
            var pedidoDetalle = await _context.PedidoDetalle.FindAsync(id);
            if (pedidoDetalle == null)
            {
                return NotFound();
            }

            _context.PedidoDetalle.Remove(pedidoDetalle);
            await _context.SaveChangesAsync();

            return pedidoDetalle;
        }

        private bool PedidoDetalleExists(int id)
        {
            return _context.PedidoDetalle.Any(e => e.id == id);
        }
    }
}
