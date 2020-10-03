using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class PrintersContext : DbContext
    {
        public PrintersContext(DbContextOptions options) : base(options) { }
        public DbSet<PrinterInfo> PrinterInfo { get; set; }
        public DbSet<PrintType> PrintType { get; set; }
        public DbSet<PrintLog> PrintLog { get; set; }
    }
}
