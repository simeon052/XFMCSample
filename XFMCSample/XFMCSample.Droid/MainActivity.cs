using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Presenter.Core;
using MvvmCross.Forms.Presenter.Droid;
using MvvmCross.Platform;
using MvvmCross.Core.Views;
using MvvmCross.Core.ViewModels;

namespace XFMCSample.Droid
{
    [Activity(Label = "XFMCSample", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            new Setup(this.ApplicationContext)
                .Initialize();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsDroidPagePresenter;
            presenter.MvxFormsApp = new MvxFormsApp();

            LoadApplication(presenter.MvxFormsApp);

            Mvx.Resolve<IMvxAppStart>().Start();
        }
    }
}

