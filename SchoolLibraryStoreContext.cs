using Microsoft.EntityFrameworkCore;
using SchoolLibraryStore.Models;

namespace SchoolLibraryStore.Context
{
    public class SchoolLibraryStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GF9BNFE\\MSSQLSERVER2022;DataBase=Database=SchoolLibraryStore;Trusted_Connection=true;Encrypt=false;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var _Categories = new List<Category>
            {
                new Category { CategoryId = 1, Name = "STEM", Description = "Our STEM book selection features captivating stories and hands-on activities that encourage creativity and critical thinking in Science, Technology, Engineering, and Mathematics." },
                new Category { CategoryId = 2, Name = "Humanities", Description = "Our Humanities collection offers a rich array of books that delve into history, literature, art, and culture, encouraging critical thinking and empathy." },
            };

            var _Products = new List<Product>
            {
                new Product { CategoryId = 1, ProductId = 1, Title = "Introduction to Algebra", Price = 1630, Description = "A comprehensive guide to basic algebra concepts for middle school students.", Quantity = 15, ImagePath = "/images/books/algebra_intro.jpg" },
                new Product { CategoryId = 2, ProductId = 2, Title = "World History Volume I", Price = 250, Description = "A detailed account of ancient civilizations and their impact on modern society.", Quantity = 8, ImagePath = "/images/books/history_vol1.jpg" },
                new Product { CategoryId = 2, ProductId = 3, Title = "Shakespeare's Sonnets", Price = 780, Description = "A collection of Shakespeare’s sonnets, exploring themes of love, time, and beauty.", Quantity = 20, ImagePath = "/images/books/shakespeare_sonnets.jpg" },
                new Product { CategoryId = 1, ProductId = 4, Title = "Chemistry Experiments", Price = 2800, Description = "Hands-on chemistry experiments designed for high school students.", Quantity = 12, ImagePath = "/images/books/chemistry_experiments.jpg" },
                new Product { CategoryId = 2, ProductId = 5, Title = "The Great Gatsby", Price = 450, Description = "F. Scott Fitzgerald's classic novel set in the Roaring Twenties.", Quantity = 7, ImagePath = "/images/books/great_gatsby.jpg" },
                new Product { CategoryId = 1, ProductId = 6, Title = "Physics Principles", Price = 1500, Description = "A foundational textbook covering basic physics laws and principles.", Quantity = 5, ImagePath = "/images/books/physics_principles.jpg" },
        };

            var _Users = new List<User>
            {
                new User { UserId = 1, FirstName = "Ramy", LastName = "Ahmed",  Email = "Ramy.Ahmed@School.com", Password = "12345" },
                new User {UserId = 2, FirstName = "Ali", LastName = "Saied", Email = "Ali.Saied@School.com", Password = "22345" },
                new User {UserId = 3, FirstName = "Mohamed", LastName= "Moussa", Email = "Mohammed.Moussa@School.com", Password = "32345" },
                new User {UserId = 4, FirstName = "Ahmed", LastName = "Sayed", Email = "Ahmed.Sayed@School.com", Password = "42345" },
                new User {UserId = 5, FirstName = "Hala", LastName = "Mahmoud", Email = "Hala.Mohmoudd@School.com", Password = "52345" },
                new User {UserId = 6, FirstName = "Mai", LastName = "Sami", Email = "Mai.Sami@School.com", Password = "62345" },
                new User {UserId = 7, FirstName = "Omar", LastName = "Sabry", Email =   "Omar.Sabry@School.com", Password = "72345" },
                new User {UserId = 8, FirstName = "Sara", LastName = "Ali", Email = "Sara.Ali@School.com", Password = "82345" },
                new User {UserId = 9, FirstName = "Mostafa", LastName = "Nabil" , Email = "Mostafa.Nabil@School.com", Password = "92345" },
                new User {UserId = 10, FirstName = "Nour", LastName = "Gerges", Email = "Nour.Gerges@School.com", Password = "02345" },
            };

            modelBuilder.Entity<Category>().HasData(_Categories);
            modelBuilder.Entity<Product>().HasData(_Products);
            modelBuilder.Entity<User>().HasData(_Users);
        }
            public virtual DbSet<Category> Categories { get; set; }
            public virtual DbSet<Product> Products { get; set; }
            public virtual DbSet<User> Users { get; set; }

    }  }

