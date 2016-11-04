using System.Web.Optimization;

namespace ListenFirst.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{

			#region Shared Bundles. CorpSite and Dash.
			bundles.Add(new ScriptBundle("~/bundles/jsShared")
				.Include("~/Content/js/plugins/jquery/jquery-2.2.4.js"));
			#endregion


			#region CorpSite Bundles.  Originally from TemplateMonster template.  I bundled them.  Need to update versions where needed.  
			bundles.Add(new ScriptBundle("~/bundles/jsCorp").Include(
						"~/site/js/jquery-migrate-1.2.1.js",
						"~/site/js/jquery.equalheights.js",
						"~/site/js/jquery.mobile.customized.min.js",
						"~/site/js/camera.js",
						"~/site/js/wow/wow.js",
						"~/site/js/script.js",
						"~/site/js/modal.js",
						"~/site/js/TMForm.js"));

			bundles.Add(new StyleBundle("~/bundles/cssCorp").Include(
					  "~/site/css/grid.css",
					  "~/site/css/camera.css",
					  "~/site/css/contact-form.css",
					  "~/site/css/animate.css",
					  "~/site/css/style.css"));
			#endregion


			#region Non-CorpSite Bundles.  Dashboard Bundles.  
			bundles.Add(new StyleBundle("~/bundles/cssDash")
				.Include("~/Content/css/bootstrap.css")
				.Include("~/Content/css/select2.css")
				.Include("~/Content/css/datepicker3.css")
				.Include("~/Content/css/AdminLTE.css")
				.Include("~/Content/css/skins/skin-blue.css"));

			bundles.Add(new ScriptBundle("~/bundles/jsDash")
				.Include("~/Content/js/plugins/bootstrap/bootstrap.js")
				.Include("~/Content/js/plugins/fastclick/fastclick.js")
				.Include("~/Content/js/plugins/slimscroll/jquery.slimscroll.js")
				.Include("~/Content/js/plugins/select2/select2.full.js")
				.Include("~/Content/js/plugins/moment/moment.js")
				.Include("~/Content/js/plugins/datepicker/bootstrap-datepicker.js")
				.Include("~/Content/js/plugins/icheck/icheck.js")
				.Include("~/Content/js/app.js")
				.Include("~/Content/js/init.js"));
			#endregion


#if DEBUG
			BundleTable.EnableOptimizations = false;
#else
			BundleTable.EnableOptimizations = true;
#endif
		}
	}
}