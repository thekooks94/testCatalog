using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebCatalog.Models;
using WebCatalog.Repositories;

namespace WebCatalog.Controllers.Api
{
    [RoutePrefix("api/catalog")]
    public class CatalogController : ApiController
    {
        protected IRepository<Product> catalogRepository;

        public CatalogController(IRepository<Product> repository)
        {
            catalogRepository = repository;
        }

        [HttpGet]
        [Route("getAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            var products = catalogRepository.GetAllEntity();
            return products;
        }

        [HttpGet]
        [Route("getProductByName")]
        public Product GetProductByName(string name)
        {
            var product = catalogRepository.GetByName(name);
            return product;
        }

        [HttpPost]
        [Route("addProduct")]
        public Product AddProduct(Product product)
        {
            catalogRepository.Create(product);
            return product;
        }

    }
}
