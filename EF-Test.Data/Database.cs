using EF_Test.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EF_Test.Data
{
  public class DatabaseContext : DbContext
  {
    public DbSet<Product> Products { get; set; }

    public DbSet<OrderItem> OrderItems { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySql("server=localhost;user=root;password=root;port=3306;database=ef_test", new MySqlServerVersion(new Version(8, 0, 28)));
    }
  }
}