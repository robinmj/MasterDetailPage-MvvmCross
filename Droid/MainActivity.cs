using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using MvvmCross.Forms.Presenter.Core;
using Cirrious.MvvmCross.Views;
using MvvmCross.Forms.Presenter.Droid;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;

namespace MasterDetailPageNavigation.Droid
{
	[Activity (Label = "MasterDetailPageNavigation.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			Forms.Init(this, bundle);
			var mvxFormsApp = new MvxFormsApp();
			LoadApplication(mvxFormsApp);

			var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsDroidPagePresenter;
			presenter.MvxFormsApp = mvxFormsApp;

			Mvx.Resolve<IMvxAppStart>().Start();
		}
	}
}

