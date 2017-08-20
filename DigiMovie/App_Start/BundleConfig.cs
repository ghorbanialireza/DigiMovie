using System.Web;
using System.Web.Optimization;

namespace DigiMovie
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery", "//ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Theme-bootstrap/Drakly-bootstrap.css",
                      "~/Content/Theme-bootstrap/Slate-bootstrap.css",
                      "~/Content/Theme-bootstrap/Solar-bootstrap.css",
                      "~/Content/Theme-bootstrap/Superhero-bootstrap.css",
                      "~/Content/Theme-bootstrap/United-bootstrap.css",
                      "~/Content/Theme-bootstrap/font-awesome.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css-admin").Include(
                
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
        }
    }
}
