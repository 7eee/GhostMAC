namespace GhostMAC
{
	// Token: 0x02000007 RID: 7
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000021A0 File Offset: 0x000003A0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002448 File Offset: 0x00000648
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::GhostMAC.MainForm));
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label_mactext = new global::System.Windows.Forms.Label();
			this.combo_network = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.bt_defaultmac = new global::System.Windows.Forms.Button();
			this.bt_update = new global::System.Windows.Forms.Button();
			this.mac_text = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.blogURLLinkLabel = new global::System.Windows.Forms.LinkLabel();
			this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.label_mactext);
			this.GroupBox1.Controls.Add(this.combo_network);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Location = new global::System.Drawing.Point(8, 1);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(279, 166);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.label_mactext.Location = new global::System.Drawing.Point(131, 111);
			this.label_mactext.Name = "label_mactext";
			this.label_mactext.Size = new global::System.Drawing.Size(142, 16);
			this.label_mactext.TabIndex = 2;
			this.combo_network.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo_network.Location = new global::System.Drawing.Point(11, 69);
			this.combo_network.Name = "combo_network";
			this.combo_network.Size = new global::System.Drawing.Size(256, 21);
			this.combo_network.TabIndex = 0;
			this.Label1.Location = new global::System.Drawing.Point(8, 50);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(152, 16);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Select Network Adapter:";
			this.Label3.Location = new global::System.Drawing.Point(8, 111);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(136, 16);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Physical Address (MAC):";
			this.GroupBox2.Controls.Add(this.bt_defaultmac);
			this.GroupBox2.Controls.Add(this.bt_update);
			this.GroupBox2.Controls.Add(this.mac_text);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Location = new global::System.Drawing.Point(293, 1);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(276, 166);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.bt_defaultmac.Location = new global::System.Drawing.Point(11, 106);
			this.bt_defaultmac.Name = "bt_defaultmac";
			this.bt_defaultmac.Size = new global::System.Drawing.Size(120, 24);
			this.bt_defaultmac.TabIndex = 3;
			this.bt_defaultmac.Text = "Reset Default MAC";
			this.bt_update.Location = new global::System.Drawing.Point(137, 106);
			this.bt_update.Name = "bt_update";
			this.bt_update.Size = new global::System.Drawing.Size(128, 24);
			this.bt_update.TabIndex = 2;
			this.bt_update.Text = "Update MAC";
			this.mac_text.Location = new global::System.Drawing.Point(11, 55);
			this.mac_text.Name = "mac_text";
			this.mac_text.Size = new global::System.Drawing.Size(256, 20);
			this.mac_text.TabIndex = 1;
			this.mac_text.Text = "04:C0:0B:EC:B7:9A";
			this.Label2.Location = new global::System.Drawing.Point(8, 35);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(128, 16);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "New Physical Address:";
			this.Label4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new global::System.Drawing.Point(52, 203);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Label4.Size = new global::System.Drawing.Size(139, 16);
			this.Label4.TabIndex = 2;
			this.Label4.Text = "Developed by Mihai Oprean";
			this.blogURLLinkLabel.AutoSize = true;
			this.blogURLLinkLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.blogURLLinkLabel.Location = new global::System.Drawing.Point(340, 218);
			this.blogURLLinkLabel.Name = "blogURLLinkLabel";
			this.blogURLLinkLabel.Size = new global::System.Drawing.Size(189, 16);
			this.blogURLLinkLabel.TabIndex = 9;
			this.blogURLLinkLabel.TabStop = true;
			this.blogURLLinkLabel.Text = "http://ghostmac.fevermedia.ro/";
			this.Label5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new global::System.Drawing.Point(354, 190);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new global::System.Drawing.Size(152, 16);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "Because your privacy matters!";
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(576, 260);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.blogURLLinkLabel);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "MainForm";
			this.Text = "GhostMAC 2";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components;
	}
}
