using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCatalog.Models
{
    public class Product : EntityBase
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}