using System.Web;
using System.Web.Optimization;

namespace StateTemplateV5
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            

            bundles.Add(new ScriptBundle("~/bundles/stateTemplateJs").Include(
                     "~/js/cagov.core.min.js",
                     "~/js/search.js"));

            bundles.Add(new StyleBundle("~/Content/stateTemplateCss").Include(
                      "~/css/cagov.core.min.css",
                      "~/css/colorscheme-oceanside.min.css",
                      "~/Content/site.css"));
        }
    }
}
