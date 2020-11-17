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
    public class TableInfoesController : ControllerBase
    {
        private readonly SmoothContext _context;

        public TableInfoesController(SmoothContext context)
        {
            _context = context;
        }

        // GET: api/TableInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TableInfo>>> GetTableInfo()
        {
            return await _context.TableInfo.ToListAsync();
        }

        // GET: api/TableInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TableInfo>> GetTableInfo(int id)
        {
            var tableInfo = await _context.TableInfo.FindAsync(id);

            if (tableInfo == null)
            {
                return NotFound();
            }

            return tableInfo;
        }

        // PUT: api/TableInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTableInfo(int id, TableInfo tableInfo)
        {
            if (id != tableInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(tableInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableInfoExists(id))
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

        // POST: api/TableInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TableInfo>> PostTableInfo(TableInfo tableInfo)
        {
            _context.TableInfo.Add(tableInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTableInfo", new { id = tableInfo.Id }, tableInfo);
        }

        // DELETE: api/TableInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TableInfo>> DeleteTableInfo(int id)
        {
            var tableInfo = await _context.TableInfo.FindAsync(id);
            if (tableInfo == null)
            {
                return NotFound();
            }

            _context.TableInfo.Remove(tableInfo);
            await _context.SaveChangesAsync();

            return tableInfo;
        }

        private bool TableInfoExists(int id)
        {
            return _context.TableInfo.Any(e => e.Id == id);
        }
    }
}
