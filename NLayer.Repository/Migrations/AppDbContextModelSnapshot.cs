﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayer.Repository;

#nullable disable

namespace NLayer.Repository.Migrations
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

            modelBuilder.Entity("NLayer.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kitaplar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal (18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 8, 28, 14, 55, 22, 16, DateTimeKind.Local).AddTicks(2015),
                            Name = "Kalem1",
                            Price = 100m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 8, 28, 14, 55, 22, 16, DateTimeKind.Local).AddTicks(2027),
                            Name = "Kalem2",
                            Price = 200m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 8, 28, 14, 55, 22, 16, DateTimeKind.Local).AddTicks(2029),
                            Name = "Kalem3",
                            Price = 300m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 8, 28, 14, 55, 22, 16, DateTimeKind.Local).AddTicks(2031),
                            Name = "Kitap1",
                            Price = 400m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 8, 28, 14, 55, 22, 16, DateTimeKind.Local).AddTicks(2033),
                            Name = "Kitap2",
                            Price = 500m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 8, 28, 14, 55, 22, 16, DateTimeKind.Local).AddTicks(2034),
                            Name = "Defter1",
                            Price = 600m,
                            Stock = 60
                        });
                });

            modelBuilder.Entity("NLayer.Core.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Red",
                            Height = 100,
                            ProductId = 1,
                            Width = 200
                        },
                        new
                        {
                            Id = 2,
                            Color = "Blue",
                            Height = 200,
                            ProductId = 2,
                            Width = 300
                        },
                        new
                        {
                            Id = 3,
                            Color = "Yellow",
                            Height = 300,
                            ProductId = 3,
                            Width = 400
                        });
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.HasOne("NLayer.Core.Category", "Cateory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cateory");
                });

            modelBuilder.Entity("NLayer.Core.ProductFeature", b =>
                {
                    b.HasOne("NLayer.Core.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("NLayer.Core.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NLayer.Core.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.Navigation("ProductFeature");
                });
#pragma warning restore 612, 618
        }
    }
}
