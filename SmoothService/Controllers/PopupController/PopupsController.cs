using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFDataAccess.DataAccess;
using EFDataAccess.Models;

namespace SmoothService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopupsController : ControllerBase
    {
        private readonly SmoothContext _context;

        public PopupsController(SmoothContext context)
        {
            _context = context;
        }

        // GET: api/Popups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Popup>>> GetPopup()
        {
            return await _context.Popup.ToListAsync();
        }

        // GET: api/Popups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Popup>> GetPopup(int id)
        {
            var popup = await _context.Popup.FindAsync(id);

            if (popup == null)
            {
                return NotFound();
            }

            return popup;
        }

        // PUT: api/Popups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPopup(int id, Popup popup)
        {
            if (id != popup.Id)
            {
                return BadRequest();
            }

            _context.Entry(popup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PopupExists(id))
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

        // POST: api/Popups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Popup>> PostPopup(Popup popup)
        {
            _context.Popup.Add(popup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPopup", new { id = popup.Id }, popup);
        }

        // DELETE: api/Popups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Popup>> DeletePopup(int id)
        {
            var popup = await _context.Popup.FindAsync(id);
            if (popup == null)
            {
                return NotFound();
            }

            _context.Popup.Remove(popup);
            await _context.SaveChangesAsync();

            return popup;
        }

        private bool PopupExists(int id)
        {
            return _context.Popup.Any(e => e.Id == id);
        }
    }
}
