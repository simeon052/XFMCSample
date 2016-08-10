using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFMCSample.Model.DataStore
{
    /// <summary>
    /// This class is used as data store to communicate each view models
    /// </summary>
    public class DataStore
    {
        public ImageSource PhotoViewImageSource {get;set;}
        public string PhotoViewImageTitle { get; set; }
        public string PhotoViewImageFullPath { get; set; }

        private DataStore()
        { }

        private static DataStore instance;
        public static DataStore GI()
        {
            return instance = instance ?? new DataStore();
        }
    }
}
