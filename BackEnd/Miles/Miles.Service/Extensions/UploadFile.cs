using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Extensions
{
    public static class UploadFile
    {
        public static string CreateImage(this IFormFile file, string root, string path)
        {
            string FileName = Guid.NewGuid().ToString() + file.FileName;
            string FullPath = Path.Combine(root, path, FileName);
            using (FileStream stream = new FileStream(FullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return FileName;
        }
    }
}
