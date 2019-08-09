using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCatalog.Models;

namespace WebCatalog.FakeData
{
    public static class FakeCatalog
    {
        public static Catalog Catalog = new Catalog
            {
                Products = new Dictionary<string, Product>() {
                {"seagate expansion portable", new Product { Name = "Seagate Expansion Portable", Description = "", Quantity = 8 }},
                {"google home", new Product { Name = "Google Home", Description = "L'Assistente Google per la casa con controllo vocale.", Quantity = 11 }},
                {"canon eos 4000d kit fotocamere", new Product { Name = "Canon EOS 4000D Kit fotocamere", Description = "", Quantity = 2 }},
                {"samsung galaxy", new Product { Name = "Samsung Galaxy", Description = "", Quantity = 1 }},
                {"ninebot by segway", new Product { Name = "Ninebot by Segway", Description = "Continua ad esplorare ovunque tu vada.", Quantity = 5 }},
                {"electroline set di valigie trolley", new Product { Name = "Electroline set di valigie trolley", Description = "Ginza Set Trolley Rigide c/TSA Lock Pic + Med + Gr Blue. Set trolley rigidi", Quantity = 6 }}
                }
            };
    }
}