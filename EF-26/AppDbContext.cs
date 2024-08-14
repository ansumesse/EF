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
            modelBuilder.Entity<Car>()
                  .HasKey(x => x.LicensePlate);
            modelBuilder.Entity<RecordSales>()
                .HasKey(x => x.RecordSaleId);

            modelBuilder.Entity<CarRecordSales>()
                .HasKey(x => new { x.RecordSaleId, x.LicensePlate });

            modelBuilder.Entity<CarRecordSales>()
                .HasOne(x => x.Cars2)
                .WithMany(x => x.carRecordSales)
                .HasForeignKey(x => x.LicensePlate);
             modelBuilder.Entity<CarRecordSales>()
                .HasOne(x => x.RecordSales)
                .WithMany(x => x.carRecordSales)
                .HasForeignKey(x => x.RecordSaleId);
            

               
                
                
                
                

        }
         public DbSet<RecordSales> RecordSales { get; set; }
         public DbSet<Car> Cars2 { get; set; }
    }
}
