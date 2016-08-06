using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Presenter.Core;
using MvvmCross.Forms.Presenter.WindowsUWP;
using MvvmCross.Platform;
using MvvmCross.WindowsUWP.Platform;
using MvvmCross.WindowsUWP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Xamarin.Forms;

namespace XFMCSample.UWP
{
    public class Setup : MvxWindowsSetup
    {
        private readonly LaunchActivatedEventArgs _launchActivatedEventArgs;

        public Setup(Windows.UI.Xaml.Controls.Frame rootFrame, LaunchActivatedEventArgs e) : base(rootFrame)
        {
            _launchActivatedEventArgs = e;
        }

        protected override IMvxApplication CreateApp()
        {
            return new XFMCSample.App();
        }

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            Forms.Init(_launchActivatedEventArgs);

            var xamarinFormsApp = new MvxFormsApp();
            var presenter = new MvxFormsWindowsUWPPagePresenter(  rootFrame, xamarinFormsApp);
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }
    }
}
