using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;

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
            var resourceAsm = Assembly.Load(new AssemblyName("XFMCSample.Res"));
            sampleList.Add(new ListItem() { Name = "Person1", Image = ImageSource.FromResource("XFMCSample.Res.cat1.jpg", resourceAsm) });
            sampleList.Add(new ListItem() { Name = "Person2", Image = ImageSource.FromResource("XFMCSample.Res.cat2.jpg", resourceAsm) });
            sampleList.Add(new ListItem() { Name = "Person3", Image = ImageSource.FromResource("XFMCSample.Res.cat3.jpg", resourceAsm) });
        }
    }
}
