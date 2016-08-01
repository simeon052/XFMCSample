using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public class ListItem
        {
            public string Name { get; set; }
            public string Image { get; set; }
        }

        private ObservableCollection<ListItem> sampleList = new ObservableCollection<ListItem>();
        public ObservableCollection<ListItem> SampleList
        {
            get { return sampleList; }
            set { sampleList = value; }
        }

        public SecondViewModel()
        {
            sampleList.Add(new ListItem() { Name = "Person1", Image = "Image1.jpg" });
            sampleList.Add(new ListItem() { Name = "Person2", Image = "Image2.jpg" });
            sampleList.Add(new ListItem() { Name = "Person3", Image = "Image2.jpg" });
            sampleList.Add(new ListItem() { Name = "Person4", Image = "Image3.jpg" });
        }
    }
}
