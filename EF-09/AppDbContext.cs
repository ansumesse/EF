using EF_09.Configuration;
using EF_09.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_09
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreLearning;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AudityEntity>(); // third way to add entity to Model
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());

            // modelBuilder.Ignore<Blog>(); // Excluding Blog from Model by Fluent API
            //modelBuilder.Entity<AudityEntity>()

            //   .ToTable("AudityEntity", x => x.ExcludeFromMigrations()); // keep the table as it is and exclude it from migration

            //modelBuilder.Entity<AudityEntity>()
            //   .ToTable("AudEnt"); // Change Table Name using Fluent API

            //modelBuilder.Entity<Blog>()
            //    .ToTable("Blogs", schema: "Blogging"); // Changing schema by fluent API

            // modelBuilder.HasDefaultSchema("Blogging"); // Change the default Schema 

            // modelBuilder.Entity<Blog>().Ignore(x => x.AddedOn); // Exclude property using fluent API

            //modelBuilder.Entity<Blog>()
            //    .Property(x => x.Url)
            //    .HasColumnName("BlogUrl"); // Change Column name

            //modelBuilder.Entity<Blog>(eb =>
            //{
            //    eb.Property(x => x.Url).HasColumnType("varchar");
            //});

            //modelBuilder.Entity<Blog>()
            //    .Property(x => x.Url)
            //    .HasMaxLength(200);

            //modelBuilder.Entity<Blog>()
            //    .Property(x => x.Url)
            //    .HasComment("this a new comment");

            modelBuilder.Entity<Book>()
              .HasKey(x => x.BookKey) // Set primary key
             .HasName("PK_BookKey");

            //modelBuilder.Entity<Book>()
            //    .HasKey(x => new { x.Name, x.BookKey }); // Composite Key

            modelBuilder.Entity<Blog>()
                .Property(x => x.Rate)
                .HasDefaultValue(5);

            modelBuilder.Entity<Blog>()
                .Property(x => x.AddedOn)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Author>()
                .Property(x => x.DisplayName)
                .HasComputedColumnSql("[FIRSTNAME] + ', ' + [LASTNAME]");

            modelBuilder.Entity<Category>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

        }
        public DbSet<Blog> Blogs2 { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
