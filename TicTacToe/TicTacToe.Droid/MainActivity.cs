﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Acr.UserDialogs;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace TicTacToe.Droid
{
	[Activity (Label = "Tic-Tac-Toe", 
        Icon = "@drawable/icon", 
        MainLauncher = true, 
        ConfigurationChanges = 
        ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
    {
		protected override void OnCreate (Bundle bundle)
		{
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate (bundle);

			Forms.Init (this, bundle);
            //MobileCenter.Start("b8de5ec5-a200-4250-b470-5d542f365fed",
            //       typeof(Analytics), typeof(Crashes));
         
            MobileCenter.Configure("b8de5ec5-a200-4250-b470-5d542f365fed");
            LoadApplication(new App ());

            UserDialogs.Init(this);
		}
	}
}

