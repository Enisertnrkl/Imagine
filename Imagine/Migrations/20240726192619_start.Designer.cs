﻿// <auto-generated />
using System;
using Imagine.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Imagine.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240726192619_start")]
    partial class start
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Imagine.DataAccess.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Devices and gadgets",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Apparel and fashion items",
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Literature and educational materials",
                            Name = "Books"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Items for interior decoration",
                            Name = "Home Decor"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Gear and supplies for sports",
                            Name = "Sports Equipment"
                        });
                });

            modelBuilder.Entity("Imagine.DataAccess.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Latest model smartphone with high-end features",
                            ImageUrl = "smartphone.jpg",
                            Name = "Smartphone",
                            Price = 699.99m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "High-performance laptop for gaming and productivity",
                            ImageUrl = "laptop.jpg",
                            Name = "Laptop",
                            Price = 1199.99m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Noise-cancelling wireless headphones",
                            ImageUrl = "headphones.jpg",
                            Name = "Headphones",
                            Price = 199.99m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Smartwatch with fitness tracking and notifications",
                            ImageUrl = "smartwatch.jpg",
                            Name = "Smartwatch",
                            Price = 249.99m,
                            Stock = 70
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "DSLR camera with high-resolution lens",
                            ImageUrl = "camera.jpg",
                            Name = "Camera",
                            Price = 899.99m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Cotton t-shirt available in various colors",
                            ImageUrl = "tshirt.jpg",
                            Name = "T-shirt",
                            Price = 19.99m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Stylish denim jeans with a modern fit",
                            ImageUrl = "jeans.jpg",
                            Name = "Jeans",
                            Price = 39.99m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Warm winter jacket with a waterproof layer",
                            ImageUrl = "jacket.jpg",
                            Name = "Jacket",
                            Price = 89.99m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Comfortable sneakers for everyday wear",
                            ImageUrl = "sneakers.jpg",
                            Name = "Sneakers",
                            Price = 59.99m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Elegant wristwatch with a leather strap",
                            ImageUrl = "watch.jpg",
                            Name = "Watch",
                            Price = 149.99m,
                            Stock = 60
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Bestselling novel with gripping plot",
                            ImageUrl = "novel.jpg",
                            Name = "Novel",
                            Price = 15.99m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Educational textbook for university students",
                            ImageUrl = "textbook.jpg",
                            Name = "Textbook",
                            Price = 79.99m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Biography of a famous historical figure",
                            ImageUrl = "biography.jpg",
                            Name = "Biography",
                            Price = 25.99m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "Cookbook with a variety of recipes",
                            ImageUrl = "cookbook.jpg",
                            Name = "Cookbook",
                            Price = 22.99m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Science fiction novel with an intriguing story",
                            ImageUrl = "scifi.jpg",
                            Name = "Science Fiction",
                            Price = 18.99m,
                            Stock = 70
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Description = "Comfortable 3-seater sofa for living rooms",
                            ImageUrl = "sofa.jpg",
                            Name = "Sofa",
                            Price = 499.99m,
                            Stock = 25
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Description = "Elegant lamp with adjustable brightness",
                            ImageUrl = "lamp.jpg",
                            Name = "Lamp",
                            Price = 59.99m,
                            Stock = 90
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Soft and durable area rug",
                            ImageUrl = "rug.jpg",
                            Name = "Rug",
                            Price = 149.99m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Stylish curtains available in multiple colors",
                            ImageUrl = "curtains.jpg",
                            Name = "Curtains",
                            Price = 89.99m,
                            Stock = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Modern coffee table with a glass top",
                            ImageUrl = "coffee_table.jpg",
                            Name = "Coffee Table",
                            Price = 199.99m,
                            Stock = 35
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 5,
                            Description = "Professional tennis racket with high tension strings",
                            ImageUrl = "tennis_racket.jpg",
                            Name = "Tennis Racket",
                            Price = 129.99m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            Description = "Standard size football for practice and games",
                            ImageUrl = "football.jpg",
                            Name = "Football",
                            Price = 29.99m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 5,
                            Description = "Comfortable yoga mat for practice and exercise",
                            ImageUrl = "yoga_mat.jpg",
                            Name = "Yoga Mat",
                            Price = 39.99m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 5,
                            Description = "Adjustable dumbbells for strength training",
                            ImageUrl = "dumbbells.jpg",
                            Name = "Dumbbells",
                            Price = 89.99m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            Description = "Mountain bicycle with 21-speed gear",
                            ImageUrl = "bicycle.jpg",
                            Name = "Bicycle",
                            Price = 399.99m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 1,
                            Description = "Portable tablet with high-resolution display",
                            ImageUrl = "tablet.jpg",
                            Name = "Tablet",
                            Price = 299.99m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 1,
                            Description = "Portable Bluetooth speaker with high sound quality",
                            ImageUrl = "bluetooth_speaker.jpg",
                            Name = "Bluetooth Speaker",
                            Price = 89.99m,
                            Stock = 60
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 1,
                            Description = "1TB external hard drive for data storage",
                            ImageUrl = "external_hard_drive.jpg",
                            Name = "External Hard Drive",
                            Price = 99.99m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 4,
                            Description = "Adjustable desk lamp with LED light",
                            ImageUrl = "desk_lamp.jpg",
                            Name = "Desk Lamp",
                            Price = 49.99m,
                            Stock = 70
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 4,
                            Description = "Beautiful wall art for home decoration",
                            ImageUrl = "wall_art.jpg",
                            Name = "Wall Art",
                            Price = 119.99m,
                            Stock = 25
                        });
                });

            modelBuilder.Entity("Imagine.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Imagine.DataAccess.Entities.Product", b =>
                {
                    b.HasOne("Imagine.DataAccess.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Imagine.DataAccess.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
