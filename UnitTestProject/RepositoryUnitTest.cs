using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCatalog.Models;
using WebCatalog.Repositories;

namespace UnitTestProject
{
    [TestClass]
    public class RepositoryUnitTest
    {
        [TestMethod]
        public void AddAndGetProduct()
        {
            var testObject = new Product() { Name = "nametestproduct", Description = "this is a test", Quantity = 2 };

            var repository = new CatalogRepository();
            repository.Create(testObject);

            //Assert
            var product = repository.GetByName(testObject.Name);
            Assert.IsNotNull(product);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Prodotto con stesso nome, già presente nel catalogo")]
        public void AddDuplicateProducts()
        {
            var testObject = new Product() { Name = "nametestproduct", Description = "this is a test", Quantity = 1 };

            var repository = new CatalogRepository();
            repository.Create(testObject);

            //Assert
            var product = repository.GetByName(testObject.Name);
            Assert.IsNotNull(product);

            repository.Create(testObject);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Campi inseriti non validi")]
        public void AddProductWithoutQuantity()
        {
            var testObject = new Product() { Name = "nametestproduct", Description = "this is a test" };

            var repository = new CatalogRepository();
            repository.Create(testObject);
        }


        [TestMethod]
        public void GetExistingProduct()
        {
            var repository = new CatalogRepository();

            //Assert
            var product = repository.GetByName("google home");
            Assert.IsNotNull(product);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Prodotto non presente nel catalogo")]
        public void GetNotExistingProduct()
        {
            var repository = new CatalogRepository();

            //Assert
            var product = repository.GetByName("testtest");
            Assert.IsNotNull(product);
        }
    }
}
