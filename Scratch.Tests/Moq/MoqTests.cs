using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Scratch.Tests.Moq
{
    [TestClass]
    public class MoqTests
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Our Mock Products Repository for use in testing
        /// </summary>
        public readonly IProductRepository MockProductsRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        public MoqTests()
        {
            // Create Products
            IList<Product> products = new List<Product>
            {
                new Product { ProductId = 1, Name = "C# Unleashed", Description = "Short description here", Price = 49.99 },
                new Product { ProductId = 2, Name = "ASP.Net Unleashed", Description = "Short description here", Price = 59.99 },
                new Product { ProductId = 3, Name = "Silverlight Unleashed", Description = "Short description here", Price = 29.99 }
            };

            // Mock the Products Repository using Moq
            Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();

            // Return all the products
            mockProductRepository.Setup(mr => mr.FindAll()).Returns(products);

            // return a product by Id
            mockProductRepository.Setup(mr => mr.FindById(It.IsAny<int>())).Returns((int i) => products.Where(x => x.ProductId == i).Single());

            // return a product by Name
            mockProductRepository.Setup(mr => mr.FindByName(It.IsAny<string>())).Returns((string s) => products.Where(x => x.Name == s).Single());

            // Allows us to test saving a product

            mockProductRepository.Setup(mr => mr.Save(It.IsAny<Product>())).Returns(
                (Product target) =>
                {
                    DateTime now = DateTime.Now;

                    if (target.ProductId.Equals(default(int)))
                    {
                        target.DateCreated = now;
                        target.DateModified = now;
                        target.ProductId = products.Count() + 1;
                        products.Add(target);
                    }
                    else
                    {
                        var original = products.Where(q => q.ProductId == target.ProductId).Single();

                        if (original == null)
                        {
                            return false;
                        }

                        original.Name = target.Name;
                        original.Price = target.Price;
                        original.Description = target.Description;
                        original.DateModified = now;
                    }
                    return true;

                });

            // Complete the setup of our Mock Product Repository
            this.MockProductsRepository = mockProductRepository.Object;
        }

        /// <summary>
        /// Can we return a product By Id?
        /// </summary>
        [TestMethod]
        public void CanReturnProductById()
        {
            // Try finding a product by id
            Product testProduct = this.MockProductsRepository.FindById(2);

            Assert.IsNotNull(testProduct); // Test if null

            Assert.IsInstanceOfType(testProduct, typeof(Product)); // Test type

            Assert.AreEqual("ASP.Net Unleashed", testProduct.Name); // Verify it is the right product

        }
    }
}
