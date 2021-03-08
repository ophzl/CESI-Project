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
    public class WineFamiliesController : ControllerBase
    {
        private readonly ApiContext _context;

        public WineFamiliesController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/WineFamilies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WineFamily>>> GetWineFamilies()
        {
            return await _context.WineFamilies.ToListAsync();
        }

        // GET: api/WineFamilies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WineFamily>> GetWineFamily(long id)
        {
            var wineFamily = await _context.WineFamilies.FindAsync(id);

            if (wineFamily == null)
            {
                return NotFound();
            }

            return wineFamily;
        }

        // PUT: api/WineFamilies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWineFamily(long id, WineFamily wineFamily)
        {
            if (id != wineFamily.Id)
            {
                return BadRequest();
            }

            _context.Entry(wineFamily).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WineFamilyExists(id))
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

        // POST: api/WineFamilies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WineFamily>> PostWineFamily(WineFamily wineFamily)
        {
            _context.WineFamilies.Add(wineFamily);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWineFamily", new { id = wineFamily.Id }, wineFamily);
        }

        // DELETE: api/WineFamilies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWineFamily(long id)
        {
            var wineFamily = await _context.WineFamilies.FindAsync(id);
            if (wineFamily == null)
            {
                return NotFound();
            }

            _context.WineFamilies.Remove(wineFamily);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WineFamilyExists(long id)
        {
            return _context.WineFamilies.Any(e => e.Id == id);
        }
    }
}
