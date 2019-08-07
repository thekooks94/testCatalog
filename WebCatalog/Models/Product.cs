using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCatalog.Models
{
    public class Product : EntityBase
    {
        public string ProductName { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public string LinkImage { get; set; }
    }
}