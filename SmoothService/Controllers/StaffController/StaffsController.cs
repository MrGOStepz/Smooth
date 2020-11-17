using EFDataAccess.DataAccess;
using EFDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using SmoothService.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly SmoothContext _context;
        private StaffService _staffService;

        public StaffsController(SmoothContext context)
        {
            _context = context;
            _staffService = new StaffService(_context);
        }

        // GET: api/Staffs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staff>>> GetStaff()
        {
            return await _context.Staff.ToListAsync();
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> GetStaff(int id)
        {
            var staff = await _context.Staff.FindAsync(id);

            if (staff == null)
            {
                return NotFound();
            }

            return staff;
        }

        // GET: api/Staffs/password/
        [HttpGet("password/{password}")]
        public ActionResult<Staff> GetStaffItem(string password)
        {
            var staff = _context.Staff.Where(s => s.Password == password).FirstOrDefault<Staff>();

            if (staff == null)
            {
                return NotFound();
            }

            return staff;
        }

        // PUT: api/Staffs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.Id)
            {
                return BadRequest();
            }

            _context.Entry(staff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(id))
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

        // POST: api/Staffs
        [HttpPost("clock")]
        public ActionResult<Staff> PostClockStaff(Login login)
        {
            try
            {
                var tmpStaff = _staffService.SetClockInOut(login);
                return Content("Update Complete");
            }
            catch (System.Exception ex)
            {
                return Content(string.Format("Cannot Update Clock : {0}", ex.Message));
            }


        }

        // POST: api/Staffs
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            ClockStatus clockStatus = _context.ClockStatus.Find(staff.ClockStatus.Id);
            StaffPosition staffPosition = _context.StaffPosition.Find(staff.StaffPosition.Id);
            staff.ClockStatus = clockStatus;
            staff.StaffPosition = staffPosition;
            _context.Staff.Add(staff);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStaff), new { id = staff.Id }, staff);
        }


        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Staff>> DeleteStaff(int id)
        {
            var staff = await _context.Staff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }

            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();

            return staff;
        }

        private bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.Id == id);
        }
    }
}
