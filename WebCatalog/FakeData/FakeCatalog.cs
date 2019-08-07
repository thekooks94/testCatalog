using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCatalog.Models;

namespace WebCatalog.FakeData
{
    public class FakeCatalog
    {
        public Catalog catalog { get; set; }

        public FakeCatalog()
        {
            catalog = new Catalog { Products = new List<Product>() {
                new Product { Id = "000", Category = Category.TV, ProductName = "", Description = "", LinkImage = "" },
                new Product { Id = "001", Category = Category.TV , ProductName = "", Description = "", LinkImage = "" }
            }};
        }
    }
}