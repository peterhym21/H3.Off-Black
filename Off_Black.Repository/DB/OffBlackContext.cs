using Microsoft.EntityFrameworkCore;
using Off_Black.Repository.Entities;

namespace Off_Black.DB
{
    public class OffBlackContext : DbContext
    {
        public OffBlackContext() {}
        public OffBlackContext(DbContextOptions<OffBlackContext> optionsBuilder) : base(optionsBuilder) {}
        public OffBlackContext(DbContextOptions options) : base(options) {}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = OffBalckDB; Trusted_Connection = True; ");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(b => b.UserID);
            modelBuilder.Entity<Order>().HasKey(b => b.OrderID);
            modelBuilder.Entity<Customer>().HasKey(b => b.CustomerID);
            modelBuilder.Entity<OrderItem>().HasKey(b => b.OrderItmeID);
            modelBuilder.Entity<Product>().HasKey(b => b.ProductID);
            modelBuilder.Entity<Category>().HasKey(b => b.CategoryID);

            modelBuilder.Entity<User>().HasOne(b => b.Customer).WithOne(t => t.User).HasForeignKey<User>(x => x.FK_CustomerID);
            modelBuilder.Entity<Customer>().HasOne(b => b.User).WithOne(t => t.Customer).HasForeignKey<Customer>(x => x.FK_UserID);

            modelBuilder.Entity<Order>().HasOne(b => b.Customer).WithMany(t => t.Orders).HasForeignKey(i => i.FK_CustomerID);
            modelBuilder.Entity<Product>().HasOne(b => b.Catagory).WithMany(t => t.Products).HasForeignKey(i => i.FK_CategoryID);
            modelBuilder.Entity<OrderItem>().HasOne(b => b.Product).WithMany().HasForeignKey(i => i.FK_ProductID);
            modelBuilder.Entity<Order>().HasMany(b => b.OrderItems).WithOne().HasForeignKey(i => i.FK_OrderID);



            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, FirstName = "Peter", LastName = "Hymøller", Adress = "Test 1", ZipCode = "6400", Email = "Test1@test.com", PhoneNumber = "29045781", FK_UserID = 1 },
                new Customer { CustomerID = 2, FirstName = "Casper", LastName = "Koch", Adress = "Test 2", ZipCode = "6400", Email = "Test2@test.com", PhoneNumber = "29045782" },
                new Customer { CustomerID = 3, FirstName = "Nickolai", LastName = "Heuck", Adress = "Test 3", ZipCode = "6400", Email = "Test3@test.com", PhoneNumber = "29045783", FK_UserID = 2 },
                new Customer { CustomerID = 4, FirstName = "Jan", LastName = "Andersen", Adress = "Test 4", ZipCode = "6400", Email = "Test4@test.com", PhoneNumber = "29045784" });

            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, FK_CustomerID = 1},
                new User { UserID = 2, FK_CustomerID = 3 });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Sweaaters And Hoodies" },
                new Category { CategoryID = 2, Name = "Pants And Sweatpants" },
                new Category { CategoryID = 3, Name = "T-shirts" },
                new Category { CategoryID = 4, Name = "Jackets" });

            modelBuilder.Entity<Product>().HasData(
                // men
                new Product { ProductID = 1, ProductName = "Caravaggio Arrows Hoodie", Price = 3832.00m, Amount = 21, ManWoman = false, ProductImagePath = "~/Img/Men-Caravaggio-Hoodie.png", FK_CategoryID = 1, ProductDescription = "Long sleeves oversized hooded sweatshirt in black featuring Off logo on the front. Caravaggio arrows printed on the back. Crewneck collar. Rib knit collar, cuffs and hem. Kangaroo pocket." },
                new Product { ProductID = 2, ProductName = "Caravaggio Painting S/S T-Shirt", Price = 2316.00m, Amount = 50, ManWoman = false, ProductImagePath = "~/Img/Men-Caravaggio-tshirt.png", FK_CategoryID = 3, ProductDescription = "Short sleeves T-shirt in black featuring Caravaggio painting on the front. Crewneck collar. Slim fit." },
                new Product { ProductID = 3, ProductName = "Formal Pants", Price = 7073.00m, Amount = 12, ProductImagePath = "~/Img/Men-Formal-pants.jpg", ManWoman = false, FK_CategoryID = 2, ProductDescription = "Straight leg formal pants in black. Logo patch sewn at front. Pockets at back. Button closure. Zip-fly. Four-pocket styling." },
                new Product { ProductID = 4, ProductName = "Padded Leather Shirt", Price = 13430.00m, Amount = 26, ManWoman = false, ProductImagePath = "~/Img/Men-Padded-leather-shirt.png", FK_CategoryID = 4, ProductDescription = "Hybrid padded leather shirt in black featuring metallic swimming logo at chest and knitted sleeves. Rib knit collar cuffs and hem." },
                // woman
                new Product { ProductID = 5, ProductName = "Offkat Allover Spray Hoodie", Price = 5052.00m, Amount = 25, ManWoman = true,  ProductImagePath = "~/Img/Woman-Offkat-Allover-Spay-Hoodie.png", FK_CategoryID = 1, ProductDescription = "Long sleeves hooded sweatshirt with sprayed multicolor pattern allover. Elasticized hem and cuffs. Black strings." },
                new Product { ProductID = 6, ProductName = "Ribbed Bodysuit", Price = 2231.00m, Amount = 40, ManWoman = true, ProductImagePath = "~/Img/Woman-Ribbed-Bodysuit.png", FK_CategoryID = 3, ProductDescription = "Sleeveless bodysuit in black with OFF printed in white at chest." },
                new Product { ProductID = 7, ProductName = "Offkat Cady Pants", Price = 8715.00m, Amount = 30, ManWoman = true, ProductImagePath = "~/Img/Woman-Offkat-cady-Pants.png", FK_CategoryID = 2, ProductDescription = "Formal pant with multicolor pattern allover. Pockets at front and back. Zip fly. Belt loops." },
                new Product { ProductID = 8, ProductName = "Offkat Tomboy Jacket", Price = 15704.00m, ManWoman = true, Amount = 28, ProductImagePath = "~/Img/Woman-Offkat-tomboy-jacket.png", FK_CategoryID = 4, ProductDescription = "Tomboy jacket in multicolor pattern allover. Pockets at front. Breast pocket. Buttons closure" });

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Catagories { get; set; }
    }
}               