﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Unity;
using Prism;
using Prism.Ioc;

namespace mexico.Droid
{
    [Activity(Label = "mexico", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
       protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.FormsMaps.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }
        public class AndroidInitializer: IPlatformInitializer
        {
        public void RegisterTypes(IContainerRegistry containerRegistry)
            {
                
            }
        }
    }
}

