using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace ConsoleApplication2
{
    class Program
    {
        public static readonly byte[] SALT = new byte[]
        {
            45,
            46,
            38,
            4,
            19,
            0,
            7,
            62
        };
        private static byte[] passwordBytes = new byte[]
        {
            36,
            235,
            31,
            35,
            82,
            85,
            192,
            173
        };

        private static byte[] AESDecryptBytes(byte[] cryptBytes)
        {
            byte[] clearBytes = null;

            // create a key from the password and salt, use 32K iterations
            var key = new Rfc2898DeriveBytes(passwordBytes, SALT, 1000);

            using (Aes aes = new AesManaged())
            {
                // set the key size to 256
                aes.KeySize = 256;
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cryptBytes, 0, cryptBytes.Length);
                        cs.Close();
                    }
                    clearBytes = ms.ToArray();
                }
            }
            return clearBytes;
        }
       static string[] array = new string[]
            {
                Environment.GetFolderPath(Environment.SpecialFolder.Recent),
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Environment.GetFolderPath(Environment.SpecialFolder.Favorites),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory),
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
        static void decryptDir(string location)
        {
            string[] files = Directory.GetFiles(location);
            string[] directories = Directory.GetDirectories(location);
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                if (extension.Contains("wndie"))
                {
                    String file = files[i].Replace(".wndie", "");
                    File.WriteAllBytes(file, Program.AESDecryptBytes(File.ReadAllBytes(files[i])));
                }
            }
            for (int j = 0; j < directories.Length; j++)
            {
                Program.decryptDir(directories[j]);
            }
        }
        static void Main(string[] args)
        {
            foreach (string dir in array)
            {
                try
                {
                    decryptDir(dir);
                }
                catch(Exception e)
                {

                }
                
            }
            array = Directory.GetLogicalDrives();
            foreach (string dir in array)
            {
                try
                {
                    decryptDir(dir);
                }
                catch (Exception e)
                {

                }
            }
            //File.WriteAllBytes("dec.txt", AESDecryptBytes(File.ReadAllBytes("eula.txt.wndie")));   
        }
    }
}
