﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebCatalog.Startup))]

namespace WebCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
