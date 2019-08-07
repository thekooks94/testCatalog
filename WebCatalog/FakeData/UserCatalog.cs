using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCatalog.Models;

namespace WebCatalog.FakeData
{
    public class UserCatalog
    {
        //key = email
        public Dictionary<string, Catalog> userCatalog { get; set; }

        public UserCatalog()
        {
            userCatalog = new Dictionary<string, Catalog>();
        }
    }
}