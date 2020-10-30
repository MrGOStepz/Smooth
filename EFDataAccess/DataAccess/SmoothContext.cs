using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class SmoothContext : DbContext
    {
        public SmoothContext(DbContextOptions options) : base(options) { }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffPosition> StaffPosition { get; set; }
        public DbSet<ClockStatus> ClockStatus { get; set; }
        public DbSet<StaffTimesheet> StaffTimesheet { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Product> Product { get; set; }
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<Popup> Popup { get; set; }
        public DbSet<PopupItem> PopupItem { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Material> Material { get; set; }

        public DbSet<Setting> Setting { get; set; }
        //public DbSet<TableInfo> TableInfo { get; set; }
        //public DbSet<TableSection> TableSection { get; set; }

        public DbSet<PrinterInfo> PrinterInfo { get; set; }
        public DbSet<PrintType> PrintType { get; set; }
        public DbSet<PrintLog> PrintLog { get; set; }

        //public DbSet<Order> Order { get; set; }
        //public DbSet<OrderInfo> OrderInfo { get; set; }
        //public DbSet<OrderStatus> OrderStatus { get; set; }
        //public DbSet<OrderType> OrderType { get; set; }
        //public DbSet<PaymentType> PaymentType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Staff>()
            .HasIndex(u => u.Password)
            .IsUnique();
            builder.SeedEnumValues<StaffPosition, StaffPositionEnum>(e => e);
            builder.SeedEnumValues<ClockStatus, ClockStatusEnum>(e => e);
        }
    }

}
