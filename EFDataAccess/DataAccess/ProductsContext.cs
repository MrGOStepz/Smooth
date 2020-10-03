using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> ClockStatus { get; set; }
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<Popup> Popup { get; set; }
        public DbSet<PopupItem> PopupItem { get; set; }
        public DbSet<PrinterInfo> PrinterInfo { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Material> Material { get; set; }
    }
}
