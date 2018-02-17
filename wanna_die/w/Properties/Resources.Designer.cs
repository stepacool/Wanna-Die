using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace w.Properties
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000020B4 File Offset: 0x000002B4
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002802 File Offset: 0x00000A02
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("w.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000282E File Offset: 0x00000A2E
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002835 File Offset: 0x00000A35
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000283D File Offset: 0x00000A3D
		internal static byte[] _img
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("_img", Resources.resourceCulture);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002858 File Offset: 0x00000A58
		internal static byte[] d
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("d", Resources.resourceCulture);
			}
		}

		// Token: 0x04000009 RID: 9
		private static ResourceManager resourceMan;

		// Token: 0x0400000A RID: 10
		private static CultureInfo resourceCulture;
	}
}
