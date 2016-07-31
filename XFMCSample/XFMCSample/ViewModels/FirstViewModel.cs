using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace XFMCSample.ViewModels
{
    class FirstViewModel : MvxViewModel
    {
        private int count;

        private string countlabel;
        public string CountLabel
        {
            get { return countlabel; }
            set
            {
                countlabel = value;
                RaisePropertyChanged(() => CountLabel);
            }
        }

        public ICommand Button1_ClickedEvent
        {
            get
            {
                return new MvxCommand(() =>
            {
                this.CountLabel = $"Button is clicked [{++count}]" + (count == 1 ? " time" : " times") + "!!!!";
            });
            }
        }

        public ICommand MoveToSecond
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<SecondViewModel>();
                }
                );
            }
        }
    }
}
