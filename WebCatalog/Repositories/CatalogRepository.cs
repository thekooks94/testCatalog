using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebCatalog.FakeData;
using WebCatalog.Models;

namespace WebCatalog.Repositories
{
    public class CatalogRepository : IRepository<Product>
    {
        private FakeCatalog data {get; set;} //Instead of using DB, there is a dictionary in memory
        public CatalogRepository()
        {
            data = new FakeCatalog();
        }

        public void Create(Product entity)
        {
            if(entity == null || string.IsNullOrEmpty(entity.Name) || entity.Quantity < 0)
            {
                throw new Exception("Campi inseriti non validi");
            }

            if (data.Catalog.Products.ContainsKey(entity.Name.ToLowerInvariant()))
            {
                throw new Exception("Prodotto con stesso nome, già presente nel catalogo");
            }

            data.Catalog.Products.Add(entity.Name.ToLowerInvariant(), entity);
            return;
        }

        public Product GetByName(string name)
        {
            data.Catalog.Products.TryGetValue(name.ToLowerInvariant(), out Product product);

            if (product == null)
            {
                throw new Exception("Prodotto non presente nel catalogo");
            }

            return product;
        }

        public IEnumerable<Product> GetAllEntity()
        {
            return data.Catalog.Products.Values;
        }
    }
}