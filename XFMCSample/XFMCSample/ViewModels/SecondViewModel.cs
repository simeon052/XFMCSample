using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace XFMCSample.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public ICommand BackToFirst
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<FirstViewModel>());
            }
        }
    }
}
