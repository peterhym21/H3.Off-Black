using Microsoft.EntityFrameworkCore;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repositories;
using Off_Black.Repository.Entities;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using Off_Black.Services.Services;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        #region Get All Product
        // /*
        [Fact]
        public async Task Get_All_Products()
        {
            // Arrange
            OffBlackContext testDb = GetTestDb();
            await InsertExampleData(testDb);

            IProductService service = GetTestService(testDb);

            // Act
            List<ProductDTO> result = await service.GetAll();

            // Assert
            Assert.Equal(20, result.Count);
        }
        // */
        #endregion

        #region Get On Product By Id
        // /*
        [Fact]
        public async Task Get_One_Product_By_Id()
        {
            // Arrange
            OffBlackContext testDb = GetTestDb();
            await InsertExampleData(testDb);

            IProductService service = GetTestService(testDb);

            // Act
            ProductDTO result = await service.GetById(5);

            // Assert
            Assert.Equal(5, result.ProductID);
        }
        // */
        #endregion

        #region Helper Mehtods

        private static async Task InsertExampleData(OffBlackContext testDb)
        {
            for (int i = 1; i <= 20; i++)
            {
                testDb.Add(new Product()
                {
                    ProductName = $"Product {i}",
                    Price = i * 10
                });
            }
            await testDb.SaveChangesAsync();
        }
        private static OffBlackContext GetTestDb()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("Test").Options;
            OffBlackContext testDb = new(options);
            return testDb;
        }
        private static IProductService GetTestService(OffBlackContext testDb)
        {
            IProductRepository repos = new ProductRepository(testDb);
            var mapper = new MappingService();
            return new ProductService(repos, mapper);
        }

        #endregion
    }
}
