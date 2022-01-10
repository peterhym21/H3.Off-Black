using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repositories;
using Off_Black.Repository.Entities;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;
using Off_Black.Service.Services;
using Service.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTest
{
    public class UnitTest1
    {
        //#region Get All Product
        //[Fact]
        //public async Task Get_All_Products()
        //{
        //    // Arrange
        //    OffBlackContext testDb = GetTestDb();
        //    await InsertExampleDataProduct(testDb);

        //    IProductService service = GetTestServiceProduct(testDb);

        //    // Act
        //    List<ProductDTO> result = await service.GetAll();

        //    // Assert
        //    Assert.Equal(40, result.Count);
        //}
        //#endregion

        //#region Get All Product Sorted By Price
        //[Fact]
        //public async Task Get_All_Products_Sortet_By_Price()
        //{
        //    // Arrange
        //    OffBlackContext testDb = GetTestDb();
        //    await InsertExampleDataProduct(testDb);

        //    IProductService service = GetTestServiceProduct(testDb);

        //    // Act
        //    List<ProductDTO> result = await service.GetAllSortetPriceASC();

        //    // Assert
        //    Assert.Equal(10, result.First().Price);
        //    Assert.Equal(200, result.Last().Price);
        //}
        //#endregion

        //#region Get One Product By Id
        //[Fact]
        //public async Task Get_One_Product_By_Id()
        //{
        //    // Arrange
        //    OffBlackContext testDb = GetTestDb();
        //    await InsertExampleDataProduct(testDb);

        //    IProductService service = GetTestServiceProduct(testDb);

        //    // Act
        //    ProductDTO result = await service.GetById(5);

        //    // Assert
        //    Assert.Equal(5, result.ProductID);
        //}
        //#endregion

        //#region Get One Customer By Id
        //[Fact]
        //public async Task Get_One_Customer_By_Id()
        //{
        //    // Arrange
        //    OffBlackContext testDb = GetTestDb();
        //    await InsertExampleDataCustomer(testDb);

        //    ICustomerService service = GetTestServiceCustomer(testDb);

        //    // Act
        //    CustomerDTO result = await service.GetById(5);

        //    // Assert
        //    Assert.Equal(5, result.CustomerID);
        //}
        //#endregion

        //#region Get On Customer By Id And Check FirstName Contains SampelData
        //[Fact]
        //public async Task Get_One_Customer_By_Id_FirstName_Contains_SampelData()
        //{
        //    // Arrange
        //    OffBlackContext testDb = GetTestDb();
        //    await InsertExampleDataCustomer(testDb);

        //    ICustomerService service = GetTestServiceCustomer(testDb);

        //    // Act
        //    CustomerDTO result = await service.GetById(13);

        //    // Assert
        //    Assert.Contains("FirstName 13", result.FirstName);
        //}
        //#endregion


        //#region Helper Mehtods

        //#region Insert Exsampel data
        //private static async Task InsertExampleDataProduct(OffBlackContext testDb)
        //{
        //    for (int i = 1; i <= 20; i++)
        //    {
        //        testDb.Add(new Product()
        //        {
        //            ProductName = $"Product {i}",
        //            Price = i * 10
        //        });
        //    }

        //    await testDb.SaveChangesAsync();
        //}

        //private static async Task InsertExampleDataCustomer(OffBlackContext testDb)
        //{
        //    for (int i = 1; i <= 20; i++)
        //    {
        //        testDb.Add(new Customer()
        //        {
        //            FirstName = $"FirstName {i}",
        //            LastName = $"LastName {i}",
        //            Email = $"Email {i}"
        //        });
        //    }

        //    await testDb.SaveChangesAsync();
        //}
        //#endregion

        //#region GetServicesTest
        //private static IProductService GetTestServiceProduct(OffBlackContext testDb)
        //{
        //    IProductRepository repos = new ProductRepository(testDb);
        //    var mapper = new MappingService();
        //    return new ProductService(repos, mapper);
        //}

        //private static ICustomerService GetTestServiceCustomer(OffBlackContext testDb)
        //{
        //    ICustomerRepository repos = new CustomerRepository(testDb);
        //    var mapper = new MappingService();
        //    return new CustomerService(repos, mapper);
        //}

        //#endregion

        //private static OffBlackContext GetTestDb()
        //{
        //    DbContextOptions optionsBuilder = new DbContextOptionsBuilder().UseInMemoryDatabase("Test").Options;
        //    OffBlackContext testDb = (DbContextOptions<OffBlackContext>) optionsBuilder;
        //    return testDb;
        //}

        //#endregion
    }
}
