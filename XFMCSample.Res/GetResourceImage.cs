using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFMCSample.Res
{
    public class GetResourceImage
    {

        public static ImageSource Get(string key)
        {
            var assembly = typeof(GetResourceImage).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
            }
            return ImageSource.FromResource(key);
        } 
    }
}
