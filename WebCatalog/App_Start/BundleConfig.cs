using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace WebCatalog
{
    public class BundleConfig
    {
        // Per altre informazioni sulla creazione di bundle, vedere https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Content/js/catalogController.js",
                "~/Content/js/addProductController.js",
                "~/Content/js/module.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/css/header.css"));
        }
    }
}
