﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cinama.Data;

#nullable disable

namespace cinama.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DirectorMovies", b =>
                {
                    b.Property<int>("DirectorsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("DirectorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("DirectorMovies");
                });

            modelBuilder.Entity("cinama.model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("cinama.model.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contect")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("cinama.model.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("cinama.model.National", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("directorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("directorId")
                        .IsUnique()
                        .HasFilter("[directorId] IS NOT NULL");

                    b.ToTable("National");
                });

            modelBuilder.Entity("DirectorMovies", b =>
                {
                    b.HasOne("cinama.model.Director", null)
                        .WithMany()
                        .HasForeignKey("DirectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cinama.model.Movies", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cinama.model.Movies", b =>
                {
                    b.HasOne("cinama.model.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("cinama.model.National", b =>
                {
                    b.HasOne("cinama.model.Director", "Director")
                        .WithOne("Nationalty")
                        .HasForeignKey("cinama.model.National", "directorId");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("cinama.model.Category", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("cinama.model.Director", b =>
                {
                    b.Navigation("Nationalty");
                });
#pragma warning restore 612, 618
        }
    }
}
