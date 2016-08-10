using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using Xamarin.Forms;
using XFMCSample.Model.DataStore;
using XFMCSample.Model.Library;

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

        public ICommand SaveAsPngButton
        {
            get
            {
                return new MvxAsyncCommand(async () => {
                    await ImageConvert.convert(DataStore.GI().PhotoViewImageFullPath, DataStore.GI().PhotoViewImageFullPath + ".PNG");
                });
            }
  
        }
    }
}
