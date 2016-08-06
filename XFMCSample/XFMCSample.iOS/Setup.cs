using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Presenter.Core;
using MvvmCross.Forms.Presenter.iOS;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using UIKit;
using Xamarin.Forms;

namespace XFMCSample.iOS
{
    public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate appDelegate, UIWindow window)
			:base(appDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            Forms.Init();

            return new MvxFormsIosPagePresenter(Window, new MvxFormsApp());

        }
    }
}
