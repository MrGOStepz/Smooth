using EFDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using EFDataAccess.DataAccess;

namespace SmoothService.Services
{
    public class StaffService
    {
        private readonly ILogger _logger;
        public Staff GetCredential(string Password, StaffContext context)
        {
            _logger.Information("GetCredemtial");
            var staff = (Staff)context.Staff.Where(c => c.Password == Password);
            return staff;
        }
    }
}
