using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCatalog.Models
{
    public abstract class EntityBase
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}