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
            var resourceInfo = typeof(GetResourceImage).GetTypeInfo().Assembly.FullName.Split(',');
            return ImageSource.FromResource($"{ resourceInfo[0]}.{key}");
        } 
    }
}
