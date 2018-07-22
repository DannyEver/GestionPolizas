using System.Web;
using System.Web.Optimization;

namespace WebAPIPoliza
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
        "~/Scripts/jquery-ui-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css",
                      "~/Content/Datepicker/bootstrap-datepicker3.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
               "~/Content/themes/base/all.css", "~/Content/Datepicker/bootstrap-datepicker3.css"));

           /* bundles.Add(new StyleBundle("~/Content/datepicker").Include(
               "~/Content/Datepicker/bootstrap-datepicker3.css"));*/

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                "~/Scripts/DataTables/jquery.dataTables.js", "~/Scripts/DataTables/dataTables.tableTools.js",
             "~/Scripts/DataTables/dataTables.scroller.min.js",
             "~/Scripts/DataTables/dataTables.bootstrap.js"
             ));

            bundles.Add(new ScriptBundle("~/bundles/datepicker").Include(
                "~/Scripts/Datepicker/bootstrap-datepicker.min.js", "~/Scripts/Datepicker/bootstrap-datepicker.tr.min.js",
             "~/Scripts/Datepicker/moment.min.js"
             ));



        }
    }
}
