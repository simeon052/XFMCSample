using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;
using XFMCSample.Res;
using Plugin.Media;
using System.IO;

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

        public ICommand ItemTapped
        {
            get
            {
                return new  MvxCommand<ListItem>((i) =>
                {
                    System.Diagnostics.Debug.WriteLine(i.Name);
                }
                );
            }
        }

        public class ListItem
        {
            public string Name { get; set; }
            public string Detail { get; set; }
            public ImageSource Image { get; set; }
        }

        private ObservableCollection<ListItem> sampleList = new ObservableCollection<ListItem>();
        public ObservableCollection<ListItem> SampleList
        {
            get { return sampleList; }
            set {
                sampleList = value;
            }
        }

        public ICommand PickPicture
        {
            get
            {
                return new MvxAsyncCommand(async () => {
                    var file = await CrossMedia.Current.PickPhotoAsync();
                    SampleList.Add(new ListItem() { Name = Path.GetFileName(file.Path), Detail= file.AlbumPath, Image = ImageSource.FromStream(() => file.GetStream()) });
                });
            }
        }


        public SecondViewModel()
        {
            sampleList.Add(new ListItem() { Name = "路上の子猫", Detail="A", Image = GetResourceImage.Get("cat1.jpg") });
            sampleList.Add(new ListItem() { Name = "黒猫 クロネコ", Detail="B", Image = GetResourceImage.Get("cat2.jpg") });
            sampleList.Add(new ListItem() { Name = "寝転ぶ子猫", Detail="C", Image = GetResourceImage.Get("cat3.jpg") });
        }
    }
}
