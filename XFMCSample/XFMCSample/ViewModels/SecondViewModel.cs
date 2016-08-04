using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;
using XFMCSample.Res;
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

        public class ListItem
        {
            public string Name { get; set; }
            public ImageSource Image { get; set; }
        }

        private ObservableCollection<ListItem> sampleList = new ObservableCollection<ListItem>();
        public ObservableCollection<ListItem> SampleList
        {
            get { return sampleList; }
            set { sampleList = value; }
        }

        public SecondViewModel()
        {
            sampleList.Add(new ListItem() { Name = "路上の子猫", Image = GetResourceImage.Get("cat1.jpg") });
            sampleList.Add(new ListItem() { Name = "黒猫 クロネコ", Image = GetResourceImage.Get("cat2.jpg") });
            sampleList.Add(new ListItem() { Name = "寝転ぶ子猫", Image = GetResourceImage.Get("cat3.jpg") });
        }
    }
}
