using System;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
public class GClass0 : ProgressBar
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000005 RID: 5 RVA: 0x000020D4 File Offset: 0x000002D4
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.Style |= 4;
			return createParams;
		}
	}
}
