using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using carrentalmanagmennt.Server.Data;
using carrentalmanagmennt.Shared.Domain;

namespace carrentalmanagmennt.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class makesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public makesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/makes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<make>>> GetMakes()
        {
          if (_context.Makes == null)
          {
              return NotFound();
          }
            return await _context.Makes.ToListAsync();
        }

        // GET: api/makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<make>> Getmake(int id)
        {
          if (_context.Makes == null)
          {
              return NotFound();
          }
            var make = await _context.Makes.FindAsync(id);

            if (make == null)
            {
                return NotFound();
            }

            return make;
        }

        // PUT: api/makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmake(int id, make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _context.Entry(make).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!makeExists(id))
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

        // POST: api/makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<make>> Postmake(make make)
        {
          if (_context.Makes == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Makes'  is null.");
          }
            _context.Makes.Add(make);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getmake", new { id = make.Id }, make);
        }

        // DELETE: api/makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletemake(int id)
        {
            if (_context.Makes == null)
            {
                return NotFound();
            }
            var make = await _context.Makes.FindAsync(id);
            if (make == null)
            {
                return NotFound();
            }

            _context.Makes.Remove(make);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool makeExists(int id)
        {
            return (_context.Makes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
