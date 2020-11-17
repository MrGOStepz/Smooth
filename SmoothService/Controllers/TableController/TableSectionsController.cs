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
    public class TableSectionsController : ControllerBase
    {
        private readonly SmoothContext _context;

        public TableSectionsController(SmoothContext context)
        {
            _context = context;
        }

        // GET: api/TableSections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TableSection>>> GetTableSection()
        {
            return await _context.TableSection.ToListAsync();
        }

        // GET: api/TableSections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TableSection>> GetTableSection(int id)
        {
            var tableSection = await _context.TableSection.FindAsync(id);

            if (tableSection == null)
            {
                return NotFound();
            }

            return tableSection;
        }

        // PUT: api/TableSections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTableSection(int id, TableSection tableSection)
        {
            if (id != tableSection.Id)
            {
                return BadRequest();
            }

            _context.Entry(tableSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableSectionExists(id))
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

        // POST: api/TableSections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TableSection>> PostTableSection(TableSection tableSection)
        {
            _context.TableSection.Add(tableSection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTableSection", new { id = tableSection.Id }, tableSection);
        }

        // DELETE: api/TableSections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TableSection>> DeleteTableSection(int id)
        {
            var tableSection = await _context.TableSection.FindAsync(id);
            if (tableSection == null)
            {
                return NotFound();
            }

            _context.TableSection.Remove(tableSection);
            await _context.SaveChangesAsync();

            return tableSection;
        }

        private bool TableSectionExists(int id)
        {
            return _context.TableSection.Any(e => e.Id == id);
        }
    }
}
