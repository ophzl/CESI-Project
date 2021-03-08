using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly ApiContext _context;

        public PurchaseOrdersController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrder>>> GetPurchaseOrder()
        {
            return await _context.PurchaseOrder.ToListAsync();
        }

        // GET: api/PurchaseOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrder>> GetPurchaseOrder(long id)
        {
            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return purchaseOrder;
        }

        // PUT: api/PurchaseOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrder(long id, PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderExists(id))
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

        // POST: api/PurchaseOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOrder>> PostPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _context.PurchaseOrder.Add(purchaseOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrder", new { id = purchaseOrder.Id }, purchaseOrder);
        }

        // DELETE: api/PurchaseOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrder(long id)
        {
            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            _context.PurchaseOrder.Remove(purchaseOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOrderExists(long id)
        {
            return _context.PurchaseOrder.Any(e => e.Id == id);
        }
    }
}
