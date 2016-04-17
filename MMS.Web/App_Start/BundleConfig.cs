using System.Web;
using System.Web.Optimization;

namespace MMS.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/Vendors/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/Vendors/angular.js",
                "~/Scripts/Vendors/angular-route.js",
                "~/Scripts/Vendors/angular-cookies.js",
                "~/Scripts/Vendors/angular-validator.js",
                "~/Scripts/Vendors/angular-base64.js",
                "~/Scripts/Vendors/angular-animate.js",
                "~/Scripts/Vendors/angular-sanitize.js",
                "~/Scripts/Vendors/angucomplete-alt.min.js",
                "~/Scripts/Vendors/ui-bootstrap-tpls-0.13.1.js",
                "~/Scripts/Vendors/toaster.js",
                "~/Scripts/Vendors/select.js",
                "~/Scripts/Vendors/ngletteravatar.js",
                "~/Scripts/Vendors/ng-flow-standalone.js",
                "~/Scripts/Vendors/smart-table.js",
                "~/Scripts/Vendors/xeditable.js",
                "~/Scripts/Vendors/checklist-model.js",
                "~/Scripts/Vendors/moment.js",
                "~/Scripts/Vendors/angular-bootstrap-checkbox.js",
                "~/Scripts/Vendors/angular-local-storage.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/spa").Include(
                "~/Scripts/spa/modules/common.core.js",
                "~/Scripts/spa/modules/common.ui.js",
                "~/Scripts/spa/app.js",
                "~/Scripts/spa/services/apiService.js",
                "~/Scripts/spa/services/notificationService.js",
                "~/Scripts/spa/services/membershipService.js",
                "~/Scripts/spa/home/rootCtrl.js",
                "~/Scripts/spa/account/loginCtrl.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/content/css/awesome-bootstrap-checkbox.css",
                "~/content/css/bootstrap.css",
                "~/content/css/font-awesome.min.css",
                "~/content/css/root.css",
                "~/content/css/responsive.css",
                "~/content/css/shortcuts.css",
                "~/content/css/style.css",
                "~/content/css/toaster.css",
                "~/content/css/select.css",
                "~/content/css/xeditable.css",
                "~/content/css/summernote-bs3.css",
                "~/content/css/datatables.css"
                ));

            BundleTable.EnableOptimizations = false;
        }
    }
}
