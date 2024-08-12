using EF_26.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_26
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreLearning;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecordSales>()
                .HasKey(x => x.RecordSaleId);
            modelBuilder.Entity<RecordSales>()
                .HasOne(x => x.Car)
                .WithMany(x => x.RecordSales)
                .HasForeignKey(x => x.LicensePlate)
                .HasPrincipalKey(x => x.LicensePlate);
        }
        public DbSet<RecordSales> RecordSales { get; set; }
    }
}
