using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace GhostMAC
{
	// Token: 0x02000007 RID: 7
	public partial class MainForm : Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002180 File Offset: 0x00000380
		public MainForm()
		{
			base.Load += new EventHandler(this.MainForm_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000008 RID: 8
		internal virtual GroupBox GroupBox1
		{
			// Token: 0x06000011 RID: 17 RVA: 0x000021BF File Offset: 0x000003BF
			get;
			// Token: 0x06000012 RID: 18 RVA: 0x000021C7 File Offset: 0x000003C7
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000009 RID: 9
		internal virtual ComboBox combo_network
		{
			// Token: 0x06000013 RID: 19 RVA: 0x000021D0 File Offset: 0x000003D0
			[CompilerGenerated]
			get
			{
				return this._combo_network;
			}
			// Token: 0x06000014 RID: 20 RVA: 0x000021D8 File Offset: 0x000003D8
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.combo_network_SelectedIndexChanged);
				ComboBox combo_network = this._combo_network;
				if (combo_network != null)
				{
					combo_network.SelectedIndexChanged -= value2;
				}
				this._combo_network = value;
				combo_network = this._combo_network;
				if (combo_network != null)
				{
					combo_network.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700000A RID: 10
		internal virtual Label Label1
		{
			// Token: 0x06000015 RID: 21 RVA: 0x0000221B File Offset: 0x0000041B
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			// Token: 0x06000016 RID: 22 RVA: 0x00002224 File Offset: 0x00000424
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		internal virtual Label Label3
		{
			// Token: 0x06000017 RID: 23 RVA: 0x00002267 File Offset: 0x00000467
			get;
			// Token: 0x06000018 RID: 24 RVA: 0x0000226F File Offset: 0x0000046F
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700000C RID: 12
		internal virtual Label label_mactext
		{
			// Token: 0x06000019 RID: 25 RVA: 0x00002278 File Offset: 0x00000478
			get;
			// Token: 0x0600001A RID: 26 RVA: 0x00002280 File Offset: 0x00000480
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700000D RID: 13
		internal virtual GroupBox GroupBox2
		{
			// Token: 0x0600001B RID: 27 RVA: 0x00002289 File Offset: 0x00000489
			get;
			// Token: 0x0600001C RID: 28 RVA: 0x00002291 File Offset: 0x00000491
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700000E RID: 14
		internal virtual Label Label2
		{
			// Token: 0x0600001D RID: 29 RVA: 0x0000229A File Offset: 0x0000049A
			get;
			// Token: 0x0600001E RID: 30 RVA: 0x000022A2 File Offset: 0x000004A2
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700000F RID: 15
		internal virtual Button bt_update
		{
			// Token: 0x0600001F RID: 31 RVA: 0x000022AB File Offset: 0x000004AB
			[CompilerGenerated]
			get
			{
				return this._bt_update;
			}
			// Token: 0x06000020 RID: 32 RVA: 0x000022B4 File Offset: 0x000004B4
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.bt_update_Click);
				Button bt_update = this._bt_update;
				if (bt_update != null)
				{
					bt_update.Click -= value2;
				}
				this._bt_update = value;
				bt_update = this._bt_update;
				if (bt_update != null)
				{
					bt_update.Click += value2;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		internal virtual TextBox mac_text
		{
			// Token: 0x06000021 RID: 33 RVA: 0x000022F7 File Offset: 0x000004F7
			get;
			// Token: 0x06000022 RID: 34 RVA: 0x000022FF File Offset: 0x000004FF
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000011 RID: 17
		internal virtual Button bt_defaultmac
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00002308 File Offset: 0x00000508
			[CompilerGenerated]
			get
			{
				return this._bt_defaultmac;
			}
			// Token: 0x06000024 RID: 36 RVA: 0x00002310 File Offset: 0x00000510
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.bt_defaultmac_Click);
				Button bt_defaultmac = this._bt_defaultmac;
				if (bt_defaultmac != null)
				{
					bt_defaultmac.Click -= value2;
				}
				this._bt_defaultmac = value;
				bt_defaultmac = this._bt_defaultmac;
				if (bt_defaultmac != null)
				{
					bt_defaultmac.Click += value2;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		private virtual LinkLabel blogURLLinkLabel
		{
			// Token: 0x06000025 RID: 37 RVA: 0x00002353 File Offset: 0x00000553
			[CompilerGenerated]
			get
			{
				return this._blogURLLinkLabel;
			}
			// Token: 0x06000026 RID: 38 RVA: 0x0000235C File Offset: 0x0000055C
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.blogURLLinkLabel_LinkClicked);
				LinkLabel blogURLLinkLabel = this._blogURLLinkLabel;
				if (blogURLLinkLabel != null)
				{
					blogURLLinkLabel.LinkClicked -= value2;
				}
				this._blogURLLinkLabel = value;
				blogURLLinkLabel = this._blogURLLinkLabel;
				if (blogURLLinkLabel != null)
				{
					blogURLLinkLabel.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		internal virtual BackgroundWorker BackgroundWorker1
		{
			// Token: 0x06000027 RID: 39 RVA: 0x0000239F File Offset: 0x0000059F
			get;
			// Token: 0x06000028 RID: 40 RVA: 0x000023A7 File Offset: 0x000005A7
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000014 RID: 20
		internal virtual Label Label5
		{
			// Token: 0x06000029 RID: 41 RVA: 0x000023B0 File Offset: 0x000005B0
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			// Token: 0x0600002A RID: 42 RVA: 0x000023B8 File Offset: 0x000005B8
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label5_Click_1);
				Label label = this._Label5;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		internal virtual Label Label4
		{
			// Token: 0x0600002B RID: 43 RVA: 0x000023FB File Offset: 0x000005FB
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			// Token: 0x0600002C RID: 44 RVA: 0x00002404 File Offset: 0x00000604
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002B80 File Offset: 0x00000D80
		private void FillNetworkAdapters()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(managementObject["IPEnabled"], true, false))
					{
						string item = managementObject["Caption"].ToString().Substring(11);
						this.combo_network.Items.Add(item);
					}
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002C1C File Offset: 0x00000E1C
		private void MainForm_Load(object sender, EventArgs e)
		{
			this.FillNetworkAdapters();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002C24 File Offset: 0x00000E24
		private string GetMACAddress(string Adapter)
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
			string result;
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(managementObject["IPEnabled"], true, false) && Operators.CompareString(managementObject["Caption"].ToString().Substring(11), Adapter, false) == 0)
					{
						result = managementObject["MacAddress"].ToString();
						break;
					}
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002CC8 File Offset: 0x00000EC8
		private void combo_network_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.label_mactext.Text = this.GetMACAddress(this.combo_network.SelectedItem.ToString());
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002CEC File Offset: 0x00000EEC
		private string DoPadding(string x)
		{
			string text = x;
			checked
			{
				if (Strings.Len(x) < 4)
				{
					int num = 4 - Strings.Len(x);
					for (int i = 1; i <= num; i++)
					{
						text = "0" + text;
					}
				}
				return text;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002D26 File Offset: 0x00000F26
		private void ShowRestart()
		{
			Interaction.MsgBox("Your MAC Address has been changed. In order to make the changes take effect, either restart your computer or enable and disable the changed Network Adapter.", MsgBoxStyle.Information, null);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002D38 File Offset: 0x00000F38
		private void bt_update_Click(object sender, EventArgs e)
		{
			if (this.IsOkay())
			{
				string root = this.GetRoot(this.combo_network.SelectedItem.ToString());
				Registry.LocalMachine.OpenSubKey(root, true).SetValue("NetworkAddress", this.mac_text.Text.Replace(":", ""));
				this.ShowRestart();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002D9C File Offset: 0x00000F9C
		private string GetRoot(string Adapter)
		{
			int num = 0;
			checked
			{
				string result;
				while (true)
				{
					string str = "SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\";
					string str2 = this.DoPadding(Conversions.ToString(num));
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(str + str2, true);
					try
					{
						if (Operators.CompareString(registryKey.GetValue("DriverDesc").ToString(), Adapter, false) == 0)
						{
							result = str + str2;
							break;
						}
					}
					catch (Exception arg_50_0)
					{
						ProjectData.SetProjectError(arg_50_0);
						ProjectData.ClearProjectError();
						break;
					}
					num++;
				}
				return result;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002E1C File Offset: 0x0000101C
		private bool IsOkay()
		{
			checked
			{
				bool result;
				if (Operators.CompareString(this.mac_text.Text, "", false) == 0)
				{
					Interaction.MsgBox("You didn't type a MAC Address", MsgBoxStyle.Critical, null);
					result = false;
				}
				else
				{
					string text = this.mac_text.Text.Replace(":", "");
					if (text.Length != 12)
					{
						Interaction.MsgBox("A MAC Address must have a length of 12", MsgBoxStyle.Critical, null);
						result = false;
					}
					else
					{
						try
						{
							if (Operators.CompareString(this.combo_network.SelectedItem.ToString(), "", false) == 0)
							{
								Interaction.MsgBox("No Network Adapter selected", MsgBoxStyle.Critical, null);
								result = false;
								return result;
							}
						}
						catch (Exception arg_99_0)
						{
							ProjectData.SetProjectError(arg_99_0);
							Interaction.MsgBox("No Network Adapter selected", MsgBoxStyle.Critical, null);
							result = false;
							ProjectData.ClearProjectError();
							return result;
						}
						int num = text.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (!this.IsHex(text.Substring(i, 1)))
							{
								Interaction.MsgBox("MAC Address in wrong format", MsgBoxStyle.Critical, null);
								result = false;
								return result;
							}
						}
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002F28 File Offset: 0x00001128
		private bool IsHex(string l)
		{
			string text = "0123456789ABCDEF";
			checked
			{
				int num = text.Length - 1;
				bool result;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(l, text.Substring(i, 1), false) == 0)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002F68 File Offset: 0x00001168
		private void bt_defaultmac_Click(object sender, EventArgs e)
		{
			if (this.IsOkay())
			{
				string root = this.GetRoot(this.combo_network.SelectedItem.ToString());
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(root, true);
				try
				{
					registryKey.DeleteValue("NetworkAddress");
				}
				catch (Exception arg_39_0)
				{
					ProjectData.SetProjectError(arg_39_0);
					ProjectData.ClearProjectError();
				}
				this.ShowRestart();
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002FD0 File Offset: 0x000011D0
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002FD0 File Offset: 0x000011D0
		private void Label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002FD0 File Offset: 0x000011D0
		private void Label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002FD0 File Offset: 0x000011D0
		private void emailAddressLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002FD4 File Offset: 0x000011D4
		private void blogURLLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string str = "http://ghostmac.fevermedia.ro";
			Interaction.Shell("explorer.exe " + str, AppWinStyle.NormalFocus, false, -1);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002FD0 File Offset: 0x000011D0
		private void Label5_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x04000009 RID: 9
		[CompilerGenerated, AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400000A RID: 10
		[CompilerGenerated, AccessedThroughProperty("combo_network")]
		private ComboBox _combo_network;

		// Token: 0x0400000B RID: 11
		[CompilerGenerated, AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400000C RID: 12
		[CompilerGenerated, AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400000D RID: 13
		[CompilerGenerated, AccessedThroughProperty("label_mactext")]
		private Label _label_mactext;

		// Token: 0x0400000E RID: 14
		[CompilerGenerated, AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400000F RID: 15
		[CompilerGenerated, AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000010 RID: 16
		[CompilerGenerated, AccessedThroughProperty("bt_update")]
		private Button _bt_update;

		// Token: 0x04000011 RID: 17
		[CompilerGenerated, AccessedThroughProperty("mac_text")]
		private TextBox _mac_text;

		// Token: 0x04000012 RID: 18
		[CompilerGenerated, AccessedThroughProperty("bt_defaultmac")]
		private Button _bt_defaultmac;

		// Token: 0x04000013 RID: 19
		[CompilerGenerated, AccessedThroughProperty("blogURLLinkLabel")]
		private LinkLabel _blogURLLinkLabel;

		// Token: 0x04000014 RID: 20
		[CompilerGenerated, AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		// Token: 0x04000015 RID: 21
		[CompilerGenerated, AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000016 RID: 22
		[CompilerGenerated, AccessedThroughProperty("Label4")]
		private Label _Label4;
	}
}
