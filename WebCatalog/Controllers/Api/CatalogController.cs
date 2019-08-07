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
        public CatalogController()
        {
            catalogRepository = new CatalogRepository();
        }

        [HttpGet]
        [Route("take")]
        public IEnumerable<string> Get()
        {
            var products = catalogRepository.GetAllEntity();
            return products.Select(p => p.Name);
        }

    }
}
