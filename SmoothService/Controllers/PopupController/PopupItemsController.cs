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
    public class PopupItemsController : ControllerBase
    {
        private readonly SmoothContext _context;

        public PopupItemsController(SmoothContext context)
        {
            _context = context;
        }

        // GET: api/PopupItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PopupItem>>> GetPopupItem()
        {
            return await _context.PopupItem.ToListAsync();
        }

        // GET: api/PopupItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PopupItem>> GetPopupItem(int id)
        {
            var popupItem = await _context.PopupItem.FindAsync(id);

            if (popupItem == null)
            {
                return NotFound();
            }

            return popupItem;
        }

        // PUT: api/PopupItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPopupItem(int id, PopupItem popupItem)
        {
            if (id != popupItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(popupItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PopupItemExists(id))
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

        // POST: api/PopupItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PopupItem>> PostPopupItem(PopupItem popupItem)
        {
            var popup = await _context.Popup.FindAsync(popupItem.Popup.Id);
            popupItem.Popup = popup;
            _context.PopupItem.Add(popupItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPopupItem", new { id = popupItem.Id }, popupItem);
        }

        // DELETE: api/PopupItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PopupItem>> DeletePopupItem(int id)
        {
            var popupItem = await _context.PopupItem.FindAsync(id);
            if (popupItem == null)
            {
                return NotFound();
            }

            _context.PopupItem.Remove(popupItem);
            await _context.SaveChangesAsync();

            return popupItem;
        }

        private bool PopupItemExists(int id)
        {
            return _context.PopupItem.Any(e => e.Id == id);
        }
    }
}
