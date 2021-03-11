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
    public class ProductsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ProductsController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            List<Product> products = await _context.Products.ToListAsync();
            List<Product> resultProducts = new List<Product>();


            List<WineFamily> wineFamilies = await _context.WineFamilies.ToListAsync();
            List<Supplier> suppliers = await _context.Suppliers.ToListAsync();

            products.ForEach(product =>
            {
                if (!product.WineFamily_Id.Equals(null))
                {
                    product.WineFamily = wineFamilies.Find(w => w.Id == product.WineFamily_Id);
                }

                if (!product.DefaultSupplier_Id.Equals(null))
                {
                    product.DefaultSupplier = suppliers.Find(s => s.Id == product.DefaultSupplier_Id);
                }
                resultProducts.Add(product);
            });

            return resultProducts;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(long id)
        {
            var product = await _context.Products.FindAsync(id);

            if (!product.WineFamily_Id.Equals(null))
            {
                List<WineFamily> wineFamilies = await _context.WineFamilies.ToListAsync();
                product.WineFamily = wineFamilies.Find(w => w.Id == product.WineFamily_Id);
            }

            if (!product.DefaultSupplier_Id.Equals(null))
            {
                List<Supplier> suppliers = await _context.Suppliers.ToListAsync();
                product.DefaultSupplier = suppliers.Find(s => s.Id == product.DefaultSupplier_Id);
            }

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(long id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);

            if (!product.WineFamily_Id.Equals(null))
            {
                product.WineFamily = _context.WineFamilies.Find((long)product.WineFamily_Id);
            }

            if (!product.Quantity.Equals(null))
            {
                product.Quantity = 0;
            }

            await _context.SaveChangesAsync();


            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(long id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
