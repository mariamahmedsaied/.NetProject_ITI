﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolLibraryStore.Context;

#nullable disable

namespace SchoolLibraryStore.Migrations
{
    [DbContext(typeof(SchoolLibraryStoreContext))]
    partial class SchoolLibraryStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolLibraryStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Our STEM book selection features captivating stories and hands-on activities that encourage creativity and critical thinking in Science, Technology, Engineering, and Mathematics.",
                            Name = "STEM"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Our Humanities collection offers a rich array of books that delve into history, literature, art, and culture, encouraging critical thinking and empathy.",
                            Name = "Humanities"
                        });
                });

            modelBuilder.Entity("SchoolLibraryStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "A comprehensive guide to basic algebra concepts for middle school students.",
                            ImagePath = "/images/books/algebra_intro.jpg",
                            Price = 1630m,
                            Quantity = 15,
                            Title = "Introduction to Algebra"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Description = "A detailed account of ancient civilizations and their impact on modern society.",
                            ImagePath = "/images/books/history_vol1.jpg",
                            Price = 250m,
                            Quantity = 8,
                            Title = "World History Volume I"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "A collection of Shakespeare’s sonnets, exploring themes of love, time, and beauty.",
                            ImagePath = "/images/books/shakespeare_sonnets.jpg",
                            Price = 780m,
                            Quantity = 20,
                            Title = "Shakespeare's Sonnets"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "Hands-on chemistry experiments designed for high school students.",
                            ImagePath = "/images/books/chemistry_experiments.jpg",
                            Price = 2800m,
                            Quantity = 12,
                            Title = "Chemistry Experiments"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Description = "F. Scott Fitzgerald's classic novel set in the Roaring Twenties.",
                            ImagePath = "/images/books/great_gatsby.jpg",
                            Price = 450m,
                            Quantity = 7,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            Description = "A foundational textbook covering basic physics laws and principles.",
                            ImagePath = "/images/books/physics_principles.jpg",
                            Price = 1500m,
                            Quantity = 5,
                            Title = "Physics Principles"
                        });
                });

            modelBuilder.Entity("SchoolLibraryStore.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "Ramy.Ahmed@School.com",
                            FirstName = "Ramy",
                            LastName = "Ahmed",
                            Password = "12345"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Ali.Saied@School.com",
                            FirstName = "Ali",
                            LastName = "Saied",
                            Password = "22345"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "Mohammed.Moussa@School.com",
                            FirstName = "Mohamed",
                            LastName = "Moussa",
                            Password = "32345"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "Ahmed.Sayed@School.com",
                            FirstName = "Ahmed",
                            LastName = "Sayed",
                            Password = "42345"
                        },
                        new
                        {
                            UserId = 5,
                            Email = "Hala.Mohmoudd@School.com",
                            FirstName = "Hala",
                            LastName = "Mahmoud",
                            Password = "52345"
                        },
                        new
                        {
                            UserId = 6,
                            Email = "Mai.Sami@School.com",
                            FirstName = "Mai",
                            LastName = "Sami",
                            Password = "62345"
                        },
                        new
                        {
                            UserId = 7,
                            Email = "Omar.Sabry@School.com",
                            FirstName = "Omar",
                            LastName = "Sabry",
                            Password = "72345"
                        },
                        new
                        {
                            UserId = 8,
                            Email = "Sara.Ali@School.com",
                            FirstName = "Sara",
                            LastName = "Ali",
                            Password = "82345"
                        },
                        new
                        {
                            UserId = 9,
                            Email = "Mostafa.Nabil@School.com",
                            FirstName = "Mostafa",
                            LastName = "Nabil",
                            Password = "92345"
                        },
                        new
                        {
                            UserId = 10,
                            Email = "Nour.Gerges@School.com",
                            FirstName = "Nour",
                            LastName = "Gerges",
                            Password = "02345"
                        });
                });

            modelBuilder.Entity("SchoolLibraryStore.Models.Product", b =>
                {
                    b.HasOne("SchoolLibraryStore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SchoolLibraryStore.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
