using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000007 RID: 7
public class GClass1 : ProgressBar
{
	// Token: 0x0600002A RID: 42 RVA: 0x00003E18 File Offset: 0x00002018
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00003E2C File Offset: 0x0000202C
	public void method_1(int int_4)
	{
		if (int_4 > this.int_1)
		{
			int_4 = this.int_1;
		}
		if (int_4 < this.int_2)
		{
			int_4 = this.int_2;
		}
		this.int_3 = this.int_0;
		this.int_0 = int_4;
		this.method_17();
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600002C RID: 44 RVA: 0x000020D4 File Offset: 0x000002D4
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.Style |= 4;
			return createParams;
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00003E78 File Offset: 0x00002078
	public int method_2()
	{
		return this.int_1;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003E8C File Offset: 0x0000208C
	public void method_3(int int_4)
	{
		if (int_4 <= this.int_2)
		{
			int_4 = checked(this.int_2 + 1);
		}
		if (int_4 < this.int_0)
		{
			this.int_0 = int_4;
		}
		this.int_1 = int_4;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003EC8 File Offset: 0x000020C8
	public int method_4()
	{
		return this.int_2;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003EDC File Offset: 0x000020DC
	public void method_5(int int_4)
	{
		if (int_4 < 0)
		{
			int_4 = 0;
		}
		if (int_4 >= this.int_1)
		{
			int_4 = checked(this.int_1 - 1);
		}
		if (int_4 > this.int_0)
		{
			this.int_0 = int_4;
		}
		this.int_2 = int_4;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00003F20 File Offset: 0x00002120
	public int method_6()
	{
		return checked((int)Math.Round(unchecked(checked((double)(this.int_0 - this.int_2) / (double)(this.int_1 - this.int_2)) * 100.0)));
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00003F5C File Offset: 0x0000215C
	public Color method_7()
	{
		return this.color_0;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003F70 File Offset: 0x00002170
	public void method_8(Color color_3)
	{
		this.color_0 = color_3;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003F84 File Offset: 0x00002184
	public Color method_9()
	{
		return this.color_1;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003F98 File Offset: 0x00002198
	public void method_10(Color color_3)
	{
		this.color_1 = color_3;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003FAC File Offset: 0x000021AC
	public Color method_11()
	{
		return this.color_2;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003FC0 File Offset: 0x000021C0
	public void method_12(Color color_3)
	{
		this.color_2 = color_3;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003FD4 File Offset: 0x000021D4
	public bool method_13()
	{
		return this.bool_1;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003FE8 File Offset: 0x000021E8
	public void method_14(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003FFC File Offset: 0x000021FC
	public GClass1.GEnum0 method_15()
	{
		return (GClass1.GEnum0)this.linearGradientMode_0;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00004010 File Offset: 0x00002210
	public void method_16(GClass1.GEnum0 genum0_0)
	{
		this.linearGradientMode_0 = (LinearGradientMode)genum0_0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00004024 File Offset: 0x00002224
	public GClass1()
	{
		this.bool_0 = false;
		this.panel_0 = new Panel();
		this.int_0 = 0;
		this.int_1 = 100;
		this.int_2 = 0;
		this.color_0 = Color.LimeGreen;
		this.color_1 = Color.LightPink;
		this.color_2 = Color.BlanchedAlmond;
		this.bool_1 = true;
		this.linearGradientMode_0 = LinearGradientMode.Horizontal;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00004090 File Offset: 0x00002290
	private void method_17()
	{
		if (this.int_0 == 0)
		{
			this.panel_0.Refresh();
			return;
		}
		double num = (double)this.int_0;
		int num2 = this.int_2;
		int num3 = this.int_1;
		checked
		{
			int num4 = (int)Math.Round(unchecked(checked((num - (double)num2) / (double)(num3 - num2)) * (double)this.panel_0.Width));
			RectangleF rect = new RectangleF(0f, 0f, (float)num4, (float)this.panel_0.Height);
			LinearGradientBrush brush = new LinearGradientBrush(rect, this.color_0, this.color_1, this.linearGradientMode_0);
			this.panel_0.Refresh();
			Graphics graphics = this.panel_0.CreateGraphics();
			graphics.FillRectangle(brush, rect);
			if (this.bool_1)
			{
				byte b = 10;
				Font font = new Font("Times New Roman", (float)10, FontStyle.Bold);
				SolidBrush brush2 = new SolidBrush(this.color_2);
				string text;
				if (this.bool_0)
				{
					text = Conversions.ToString(this.method_6()) + "%";
				}
				else
				{
					text = Conversions.ToString(this.method_6());
				}
				int num5 = (int)Math.Round(unchecked((double)this.panel_0.Width / 2.0 - (double)(checked(text.Length * (int)b)) / 2.0));
				int num6 = (int)Math.Round(unchecked((double)this.panel_0.Height / 2.0 - (double)b));
				graphics.DrawString(text, font, brush2, (float)num5, (float)num6);
			}
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004200 File Offset: 0x00002400
	public void method_18(int int_4 = 1)
	{
		checked
		{
			this.int_0 += int_4;
			if (this.int_0 > this.int_1)
			{
				this.int_0 = this.int_1;
			}
			if (this.int_0 < this.int_2)
			{
				this.int_0 = this.int_2;
			}
			this.method_17();
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00004258 File Offset: 0x00002458
	public void method_19(int int_4 = 1)
	{
		this.int_0 = int_4;
		if (this.int_0 > this.int_1)
		{
			this.int_0 = this.int_1;
		}
		if (this.int_0 < this.int_2)
		{
			this.int_0 = this.int_2;
		}
		this.method_17();
	}

	// Token: 0x0400002E RID: 46
	public bool bool_0;

	// Token: 0x0400002F RID: 47
	public Panel panel_0;

	// Token: 0x04000030 RID: 48
	private int int_0;

	// Token: 0x04000031 RID: 49
	private int int_1;

	// Token: 0x04000032 RID: 50
	private int int_2;

	// Token: 0x04000033 RID: 51
	private Color color_0;

	// Token: 0x04000034 RID: 52
	private Color color_1;

	// Token: 0x04000035 RID: 53
	private Color color_2;

	// Token: 0x04000036 RID: 54
	private int int_3;

	// Token: 0x04000037 RID: 55
	private bool bool_1;

	// Token: 0x04000038 RID: 56
	private LinearGradientMode linearGradientMode_0;

	// Token: 0x02000008 RID: 8
	public enum GEnum0
	{
		// Token: 0x0400003A RID: 58
		Horizontal,
		// Token: 0x0400003B RID: 59
		Vertical,
		// Token: 0x0400003C RID: 60
		ForwardDiagonal,
		// Token: 0x0400003D RID: 61
		BackwardDiagonal
	}
}
