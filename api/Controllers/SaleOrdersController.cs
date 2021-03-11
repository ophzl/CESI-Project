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
    public class SaleOrdersController : ControllerBase
    {
        private readonly ApiContext _context;

        public SaleOrdersController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/SaleOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleOrder>>> GetSaleOrders()
        {
            return await _context.SaleOrders.ToListAsync();
        }

        // GET: api/SaleOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleOrder>> GetSaleOrder(long id)
        {
            var saleOrder = await _context.SaleOrders.FindAsync(id);

            if (saleOrder == null)
            {
                return NotFound();
            }

            return saleOrder;
        }

        // PUT: api/SaleOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleOrder(long id, SaleOrder saleOrder)
        {
            if (id != saleOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(saleOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleOrderExists(id))
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

        // POST: api/SaleOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleOrder>> PostSaleOrder(SaleOrder saleOrder)
        {

            if (!saleOrder.Customer_Id.Equals(null))
            {
                saleOrder.Customer = await _context.Customers.FindAsync((long)saleOrder.Customer_Id);
            }


            var Orders = new List<Order>();
            double Total = 0;

            var Products = await _context.Products.ToListAsync();



            // Changes the stock for each products of SaleOrders.products
            saleOrder.Orders.ForEach(elem =>
            {
                elem.Product = Products.FirstOrDefault(e => e.Id == elem.Product_Id);
                Total += elem.Product.SellPrice * elem.Quantity;
                Orders.Add(elem);

                var product = Products.FirstOrDefault(e => e.Id == elem.Product_Id);
                product.Quantity -= elem.Quantity;

                if (product.Quantity <= 0)
                {
                    var autoOrder = new Order { Product = product, Product_Id = product.Id, Quantity = product.Quantity + 50 };
                    var autoList = new List<Order>();
                    autoList.Add(autoOrder);
                    var PurchaseOrder = new PurchaseOrder
                    {
                        DateTime = DateTime.Now,
                        Orders = autoList,
                        Supplier = product.DefaultSupplier,
                        Supplier_Id = product.DefaultSupplier_Id

                    };
                    _context.PurchaseOrders.Add(PurchaseOrder);
                }

            });

            saleOrder.Orders = Orders;
            saleOrder.Total = Total;
            saleOrder.DateTime = DateTime.Now;

            _context.SaleOrders.Add(saleOrder);


            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaleOrder", new
            {
                id = saleOrder.Id
            }, saleOrder);
        }

        // DELETE: api/SaleOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleOrder(long id)
        {
            var saleOrder = await _context.SaleOrders.FindAsync(id);
            if (saleOrder == null)
            {
                return NotFound();
            }

            _context.SaleOrders.Remove(saleOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleOrderExists(long id)
        {
            return _context.SaleOrders.Any(e => e.Id == id);
        }
    }
}
