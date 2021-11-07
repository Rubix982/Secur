using System.Web.Optimization;

namespace SecurWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
            {
                CdnPath = null,
                CdnFallbackExpression = null,
                Orderer = null,
                Builder = null,
                EnableFileExtensionReplacements = false,
                ConcatenationToken = null
            }.Include(
                "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
            {
                CdnPath = null,
                CdnFallbackExpression = null,
                Orderer = null,
                Builder = null,
                EnableFileExtensionReplacements = false,
                ConcatenationToken = null
            }.Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
            {
                CdnPath = null,
                CdnFallbackExpression = null,
                Orderer = null,
                Builder = null,
                EnableFileExtensionReplacements = false,
                ConcatenationToken = null
            }.Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css")
            {
                CdnPath = null,
                CdnFallbackExpression = null,
                Orderer = null,
                Builder = null,
                EnableFileExtensionReplacements = false,
                ConcatenationToken = null
            }.Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));
        }
    }
}