using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms.Platform.UWP;
using MvvmCross.Core.Views;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Presenter.WindowsUWP;

namespace XFMCSample.UWP
{
    public sealed partial class MainPage : WindowsPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Mvx.Resolve<IMvxAppStart>().Start();

            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsWindowsUWPPagePresenter;
            LoadApplication(presenter.MvxFormsApp);
        }
    }
}
