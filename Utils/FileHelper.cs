using System;
using System.IO;

namespace RYHME.Utils
{
    public static class FileHelper
    {
        public static string UploadFile(string filePath, string destinationFolder)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(destinationFolder))
            {
                throw new ArgumentException("File path and destination folder cannot be null or empty.");
            }

            var fileName = Path.GetFileName(filePath);
            var destinationPath = Path.Combine(destinationFolder, fileName);

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            File.Copy(filePath, destinationPath, true);

            return destinationPath;
        }

        public static void DeleteFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.");
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
