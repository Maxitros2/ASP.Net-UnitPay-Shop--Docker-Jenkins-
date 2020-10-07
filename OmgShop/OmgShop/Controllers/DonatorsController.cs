using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using OmgShop.Models;

namespace OmgShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonatorsController : ControllerBase
    {
        private readonly DonatorContext _context;

        public DonatorsController(DonatorContext context)
        {
            _context = context;
        }

        // GET: api/Donators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donator>>> GetUserReports()
        {
            return await _context.Donators.Skip(_context.Donators.Count()-4).ToListAsync();
        }
               
        // GET: api/Donators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Donator>> GetDonator(long id)
        {
            var donator = await _context.Donators.FindAsync(id);

            if (donator == null)
            {
                return NotFound();
            }

            return donator;
        }

        // PUT: api/Donators/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonator(long id, Donator donator)
        {
            if (id != donator.Id)
            {
                return BadRequest();
            }

            _context.Entry(donator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonatorExists(id))
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

        // POST: api/Donators
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Donator>> PostDonator(Donator donator)
        {
            _context.Donators.Add(donator);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonator", new { id = donator.Id }, donator);
        }

        // DELETE: api/Donators/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Donator>> DeleteDonator(long id)
        {
            var donator = await _context.Donators.FindAsync(id);
            if (donator == null)
            {
                return NotFound();
            }

            _context.Donators.Remove(donator);
            await _context.SaveChangesAsync();

            return donator;
        }

        private bool DonatorExists(long id)
        {
            return _context.Donators.Any(e => e.Id == id);
        }
    }
}
