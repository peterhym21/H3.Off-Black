using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Off_Black.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.DB
{
    public class OffBlackContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = OffBalckDB; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(b => b.UserID);
            modelBuilder.Entity<Order>().HasKey(b => b.OrderID);
            modelBuilder.Entity<Customer>().HasKey(b => b.CustomerID);
            modelBuilder.Entity<OrderItem>().HasKey(b => b.OrderItmeID);
            modelBuilder.Entity<Product>().HasKey(b => b.ProductID);
            modelBuilder.Entity<Catagory>().HasKey(b => b.CategoryID);

            modelBuilder.Entity<User>().HasOne(b => b.Customer).WithOne(t => t.User).HasForeignKey<User>(x => x.FK_CustomerID);
            modelBuilder.Entity<Customer>().HasOne(b => b.User).WithOne(t => t.Customer).HasForeignKey<Customer>(x => x.FK_UserID);

            modelBuilder.Entity<Order>().HasOne(b => b.Customer).WithMany(t => t.Orders).HasForeignKey(i => i.FK_CustomerID);



            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, FirstName = "Peter", LastName = "Hymøller", Adress = "Egedam 4", Email = "Test@test.com", PhoneNumber = "29045782" });

            modelBuilder.Entity<Catagory>().HasData(
                new Catagory { CategoryID = 1, Name = "Sweaaters And Hoodies" });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Caravaggio Arrows Hoodie", ProductDescription = "Long sleeves oversized hooded sweatshirt in black featuring Off logo on the front. Caravaggio arrows printed on the back. Crewneck collar. Rib knit collar, cuffs and hem. Kangaroo pocket.", Price = 4000.00m, Amount = 21, ProductImagePath = "", FK_CategoryID = 1 });

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
    }
}               