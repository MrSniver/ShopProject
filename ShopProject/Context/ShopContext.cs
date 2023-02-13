using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using ShopProject.Models;
using System.Collections.Generic;

namespace ShopProject.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) 
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Transaction> Transactions { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable(nameof(Product));
            modelBuilder.Entity<Customer>().ToTable(nameof(Customer));
            modelBuilder.Entity<Transaction>().ToTable(nameof(Transaction));
        }
    }
}
