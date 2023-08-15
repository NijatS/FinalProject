using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Helpers
{
    public class Helper
    {
        public static bool isImage(IFormFile file)
        {
            return file.ContentType.Contains("image");
        }
        public static bool isSizeOk(IFormFile file, int size)
        {
            return file.Length / 1024 / 1024 <= size;
        }
        public static void RemoveImage(string root, string path, string image)
        {
            string FullPath = Path.Combine(root, path, image);
            if (File.Exists(FullPath))
            {
                File.Delete(FullPath);
            }

        }
    }
}
