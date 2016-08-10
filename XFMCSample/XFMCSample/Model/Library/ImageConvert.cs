using PCLStorage;
using Splat;
using System.IO;
using System.Threading.Tasks;

namespace XFMCSample.Model.Library
{
    public class ImageConvert
    {
        public static async Task<bool> convert(string src, string dst)
        {
            var TargetFormat = CompressedBitmapFormat.Png;

            IFolder folder = await FileSystem.Current.GetFolderFromPathAsync(Path.GetDirectoryName(src));
            IFile file = await folder.GetFileAsync(Path.GetFileName(src));
            var stream = await file.OpenAsync(FileAccess.Read);
            var image = await BitmapLoader.Current.Load(stream, null, null);
            IFile dstfile = await folder.CreateFileAsync(Path.GetFileName(dst), CreationCollisionOption.ReplaceExisting);
            var ws = await dstfile.OpenAsync(FileAccess.ReadAndWrite);
            await image.Save(TargetFormat, 1.0f, ws);
            return true;
        }
    }
}
