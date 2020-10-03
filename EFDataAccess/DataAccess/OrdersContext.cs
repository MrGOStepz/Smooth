using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions options) : base(options) { }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderInfo> OrderInfo { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderType> OrderType { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }

    }
}
