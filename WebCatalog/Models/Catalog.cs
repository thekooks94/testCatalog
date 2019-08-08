using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCatalog.Models
{
    public class Catalog
    {
        [JsonProperty(PropertyName = "products")]
        public IDictionary<string, Product> Products { get; set; }
    }
}