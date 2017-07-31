using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace Project1.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
      

        
            BundleTable.EnableOptimizations = true;

            StyleBundle StyleSheet = new StyleBundle("~/Style/Style");
             StyleSheet.Include("~/Style/StyleSheet1.css");

        }


    }
}