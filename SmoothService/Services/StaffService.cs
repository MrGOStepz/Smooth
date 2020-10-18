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

        public Staff GetCredential(string Password)
        {
            _logger.Information("GetCredential");
            var staff = (Staff)_staffContext.Staff.Where(c => c.Password == Password);
            if(staff != null)
            {
                return staff;
            }
            else
            {
                return staff = new Staff();
            }

            
        }

        public int SetClockInOut(Staff staffs)
        {
            //var staff = (Staff)_staffContext.Staff.Where(c => c.Id == staffs.Id);
            //var staffTimesheet = new StaffTimesheet();
            //staffTimesheet.Staff = staff;
            //staffTimesheet.ClockIn = DateTime.Now.ToLongDateString();

            //if (staff.ClockStatus.Id == (int)ClockStatusEnum.In)
            //{
            //    staff.ClockStatusId = (int)ClockStatusEnum.Out;
            //    var staffTimesheetClockIn = _staffContext.StaffTimesheet
            //    .Where(c => c.Id == staffs.Id)
            //    .OrderByDescending(c => c.Id)
            //    .First();
            //    staffTimesheetClockIn.ClockOut = DateTime.Now.ToLongTimeString();
            //    _staffContext.Entry(staffTimesheetClockIn).State = EntityState.Modified;     
            //    _staffContext.Entry(staff).State = EntityState.Modified;
            //    _staffContext.SaveChangesAsync();

            //    //_staffContext.Entry(staffTimesheetClockIn).CurrentValues.SetValues(item);

            //}
            //else
            //{
            //    staff.ClockStatusId = (int)ClockStatusEnum.In;
            //    _staffContext.StaffTimesheet.Add(staffTimesheet);
            //    _staffContext.Entry(staff).State = EntityState.Modified;
            //    _staffContext.SaveChangesAsync();
            //}
            
            return 1;
        }

    }
}
