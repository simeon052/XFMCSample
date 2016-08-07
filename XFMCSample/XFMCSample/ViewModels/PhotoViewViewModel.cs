using MvvmCross.Core.ViewModels;
using Xamarin.Forms;
using XFMCSample.Model.DataStore;

namespace XFMCSample.ViewModels
{
    public class PhotoViewViewModel : MvxViewModel
    {
        public ImageSource ImageViewSource
        {
            get
            {
                return DataStore.GI().PhotoViewImageSource;
            }
        }

        public string TitleLabel
        {
            get { return DataStore.GI().PhotoViewImageTitle; }
        }
    }
}
