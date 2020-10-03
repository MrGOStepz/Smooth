using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
    }
}
