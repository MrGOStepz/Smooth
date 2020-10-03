using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class SettingContext : DbContext
    {
        public SettingContext(DbContextOptions options) : base(options) { }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<TableInfo> TableInfo { get; set; }
        public DbSet<TableSection> TableSection { get; set; }
    }
}
