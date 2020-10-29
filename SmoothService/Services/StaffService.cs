using EFDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using EFDataAccess.DataAccess;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace SmoothService.Services
{
    public class StaffService
    {
        private readonly ILogger _logger;
        StaffContext _staffContext;

        public StaffService(StaffContext context)
        {
            _staffContext = context;
        }

        public int SetClockInOut(Login login)
        {
            var staff = _staffContext.Staff.Where(c => c.Id == login.Id)
                .Include(a => a.ClockStatus)
                .Include(b => b.StaffPosition)
                .FirstOrDefault<Staff>();
            List<ClockStatus> clockStatus = _staffContext.ClockStatus.ToList();


            if (staff.ClockStatus.Id == (int)ClockStatusEnum.In)
            {
                staff.ClockStatus = clockStatus.Where(a => a.Id == (int)ClockStatusEnum.Out).SingleOrDefault();
                var staffTimesheetClockIn = _staffContext.StaffTimesheet
                    .Where(c => c.Staff.Id == login.Id)
                    .OrderByDescending(c => c.Id)
                    .FirstOrDefault();
                staffTimesheetClockIn.ClockOut = DateTime.Now;
                _staffContext.Entry(staffTimesheetClockIn).State = EntityState.Modified;
                _staffContext.Entry(staff).State = EntityState.Modified;
                _staffContext.SaveChanges();

            }
            else
            {
                var staffTimesheet = new StaffTimesheet();
                staffTimesheet.Staff = staff;
                staffTimesheet.ClockIn = DateTime.Now;
                staff.ClockStatus = clockStatus.Where(a => a.Id == (int)ClockStatusEnum.In).SingleOrDefault();
                _staffContext.StaffTimesheet.Add(staffTimesheet);
                _staffContext.Entry(staff).State = EntityState.Modified;
                _staffContext.SaveChanges();
            }

            return 1;
        }

    }
}
