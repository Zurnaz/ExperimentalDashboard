﻿using System.Web;
using System.Web.Optimization;

namespace ExperimentalDashboard
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

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
                      "~/Content/multirange.css"));

            bundles.Add(new ScriptBundle("~/bundles/multirange").Include(
                      "~/Scripts/multirange.js"));

            bundles.Add(new ScriptBundle("~/bundles/react").Include(
                      "~/Scripts/react/react.js"));

            bundles.Add(new ScriptBundle("~/bundles/raphael").Include(
                      "~/Scripts/raphael.js"));

            bundles.Add(new ScriptBundle("~/bundles/treemap").Include(
                      "~/Scripts/treemap-squared-0.5.min.js"));

        } 
    }
}
