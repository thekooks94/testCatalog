using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCatalog.Models
{
    public class Catalog
    {
        public IDictionary<string, Product> Products { get; set; }
    }
}