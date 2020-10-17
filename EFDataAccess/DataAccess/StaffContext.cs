using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class StaffContext : DbContext
    {
        public StaffContext(DbContextOptions options) : base(options) { }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffPosition> StaffPosition { get; set; }
        public DbSet<ClockStatus> ClockStatus { get; set; }
        public DbSet<StaffTimesheet> StaffTimesheet { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedEnumValues<StaffPosition, StaffPositionEnum>(e => e);
            builder.SeedEnumValues<ClockStatus, ClockStatusEnum>(e => e);

        }
    }

}
