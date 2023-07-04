using System.Web.Optimization;

namespace NycoinWebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var version = "3.4.1";
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        $"~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/nycoin").Include(
                        "~/Scripts/nycoin.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/buttons.css",
                      "~/Content/login/login.css",
                      "~/Content/login/signup.css",
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/site.css"));
        }
    }
}
