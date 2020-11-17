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
    public class PrinterInfoesController : ControllerBase
    {
        private readonly SmoothContext _context;

        public PrinterInfoesController(SmoothContext context)
        {
            _context = context;
        }

        // GET: api/PrinterInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrinterInfo>>> GetPrinterInfo()
        {
            return await _context.PrinterInfo.ToListAsync();
        }

        // GET: api/PrinterInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrinterInfo>> GetPrinterInfo(int id)
        {
            var printerInfo = await _context.PrinterInfo.FindAsync(id);

            if (printerInfo == null)
            {
                return NotFound();
            }

            return printerInfo;
        }

        // PUT: api/PrinterInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrinterInfo(int id, PrinterInfo printerInfo)
        {
            if (id != printerInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(printerInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrinterInfoExists(id))
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

        // POST: api/PrinterInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PrinterInfo>> PostPrinterInfo(PrinterInfo printerInfo)
        {
            _context.PrinterInfo.Add(printerInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrinterInfo", new { id = printerInfo.Id }, printerInfo);
        }

        // DELETE: api/PrinterInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PrinterInfo>> DeletePrinterInfo(int id)
        {
            var printerInfo = await _context.PrinterInfo.FindAsync(id);
            if (printerInfo == null)
            {
                return NotFound();
            }

            _context.PrinterInfo.Remove(printerInfo);
            await _context.SaveChangesAsync();

            return printerInfo;
        }

        private bool PrinterInfoExists(int id)
        {
            return _context.PrinterInfo.Any(e => e.Id == id);
        }
    }
}
