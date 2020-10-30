using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFDataAccess.DataAccess;
using EFDataAccess.Models;

namespace SmoothService.Services
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

        // GET: api/Popups
        [HttpGet("PopupItems")]
        public async Task<ActionResult<IEnumerable<PopupItem>>> GetPopupItems()
        {
            return await _context.PopupItem.ToListAsync();
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

        // GET: api/Popups/5
        [HttpGet("PopupItmes/{id}")]
        public async Task<ActionResult<PopupItem>> GetPopupItems(int id)
        {
            var popupItem = await _context.PopupItem.FindAsync(id);

            if (popupItem == null)
            {
                return NotFound();
            }

            return popupItem;
        }

        // PUT: api/Popups/5
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

        // PUT: api/Popups/5
        [HttpPut("PopupItems/{id}")]
        public async Task<IActionResult> PutPopupItems(int id, PopupItem popupItems)
        {
            if (id != popupItems.Id)
            {
                return BadRequest();
            }

            _context.Entry(popupItems).State = EntityState.Modified;

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
        [HttpPost]
        public async Task<ActionResult<Popup>> PostPopup(Popup popup)
        {
            _context.Popup.Add(popup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPopup", new { id = popup.Id }, popup);
        }

        // POST: api/Popups
        [HttpPost("PopupItem")]
        public async Task<ActionResult<Popup>> PostPopupItem(PopupItem popupItems)
        {
            Popup popup = _context.Popup.Find(popupItems.Popup.Id);
            popupItems.Popup = popup;
            _context.PopupItem.Add(popupItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPopupItem", new { id = popupItems.Id }, popupItems);
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
