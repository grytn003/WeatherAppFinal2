using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Prism.Unity;
using Microsoft.Practices.Unity;
using Android.Webkit;
using Week9PrismExampleApp.ViewModels;
using System.IO;
using Android.Content.Res;

namespace Week9PrismExampleApp.Droid
{

    [Activity(Label = "Week9PrismExampleApp.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            /*
            string content;
            AssetManager assets = this.Assets;

            using (StreamReader sr = new StreamReader(Assets.Open("map.html")))
            {
                content = sr.ReadToEnd();
            }

            WebView webView = new WebView(content);*/

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}
