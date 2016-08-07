using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace XFMCSample.ViewModels
{
    public class ThirdViewModel : MvxViewModel
    {
        public ICommand RefreshUrl
        {
            get
            {
                return new MvxCommand(() => RaisePropertyChanged(() => Url));
            }
        }

        private string url = @"http://www.xamarin.com";
        public string Url
        {
            get { return url; }
            set
            {
                url = value;
            }
        }
    }
}
