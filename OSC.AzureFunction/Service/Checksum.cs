using System;
using System.IO;
using System.Security.Cryptography;

namespace OSC.AzureFunction.Service
{
    public class Checksum
    {
        public static void CreateSHA512File(string path, string fileName)
        {
            FileInfo file = Checksum.GetFile(path, fileName);
            string SHA512String = Checksum.GetSHA512(file);
            Checksum.CreateSHA512File(file.DirectoryName, file.Name, SHA512String);
        }

        public static string GetSHA512FileString(byte[] sourceBytes)
        {
            string SHA512 = string.Empty;
            using (SHA512 sha512Hash = System.Security.Cryptography.SHA512.Create())
            {
                //From String to byte array
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                SHA512 = BitConverter.ToString(hashBytes).Replace("-", " ").ToLower();
            }
            return SHA512;
        }

        private static FileInfo GetFile(string path, string fileName)
        {
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles($"{fileName}.*");
            FileInfo result = null;

            foreach (FileInfo file in Files)
            {
                result = file;
            }
            return result;
        }
        private static string GetSHA512(FileInfo file)
        {
            byte[] sourceBytes;
            string SHA512 = string.Empty;
            string filename = file.FullName;
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(filename);
                fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                sourceBytes = bytes;
            }

            using (SHA512 sha512Hash = System.Security.Cryptography.SHA512.Create())
            {
                //From String to byte array
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                SHA512 = BitConverter.ToString(hashBytes).Replace("-", " ").ToLower();
            }
            return SHA512;
        }
        private static void CreateSHA512File(string path, string fileName, string SHA512String)
        {
            fileName = $"{fileName}.SHA512";
            path = path + "\\" + fileName;
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(SHA512String);
                }
            }
        }
    }
}
