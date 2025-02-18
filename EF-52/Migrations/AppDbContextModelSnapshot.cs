﻿// <auto-generated />
using System;
using EF_52;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_52.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_52.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("EF_52.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("EF_52.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NationalityId"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("NationalityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalityId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Nationalities", (string)null);
                });

            modelBuilder.Entity("EF_52.Models.Book", b =>
                {
                    b.HasOne("EF_52.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EF_52.Models.Nationality", b =>
                {
                    b.HasOne("EF_52.Models.Author", "Author")
                        .WithMany("Nationalities")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EF_52.Models.Author", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Nationalities");
                });
#pragma warning restore 612, 618
        }
    }
}
