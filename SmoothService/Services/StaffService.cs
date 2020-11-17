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
        SmoothContext _smoothContext;

        public StaffService(SmoothContext context)
        {
            _smoothContext = context;
        }

        public int SetClockInOut(Login login)
        {
            try
            {
                var staff = _smoothContext.Staff.Where(c => c.Id == login.StaffId)
                    .Include(a => a.ClockStatus)
                    .Include(b => b.StaffPosition)
                    .FirstOrDefault<Staff>();
                List<ClockStatus> clockStatus = _smoothContext.ClockStatus.ToList();


                if (staff.ClockStatus.Id == (int)ClockStatusEnum.In)
                {
                    staff.ClockStatus = clockStatus.Where(a => a.Id == (int)ClockStatusEnum.Out).SingleOrDefault();
                    var staffTimesheetClockIn = _smoothContext.StaffTimesheet
                        .Where(c => c.Staff.Id == login.StaffId)
                        .OrderByDescending(c => c.Id)
                        .FirstOrDefault();
                    staffTimesheetClockIn.ClockOut = DateTime.Now;
                    _smoothContext.Entry(staffTimesheetClockIn).State = EntityState.Modified;
                    _smoothContext.Entry(staff).State = EntityState.Modified;
                    _smoothContext.SaveChanges();

                }
                else
                {
                    var staffTimesheet = new StaffTimesheet();
                    staffTimesheet.Staff = staff;
                    staffTimesheet.ClockIn = DateTime.Now;
                    staff.ClockStatus = clockStatus.Where(a => a.Id == (int)ClockStatusEnum.In).SingleOrDefault();
                    _smoothContext.StaffTimesheet.Add(staffTimesheet);
                    _smoothContext.Entry(staff).State = EntityState.Modified;
                    _smoothContext.SaveChanges();
                }

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

    }
}
