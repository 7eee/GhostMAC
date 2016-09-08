using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace GhostMAC.My
{
	// Token: 0x02000005 RID: 5
	[StandardModule, HideModuleName, GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000003 RID: 3
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			// Token: 0x06000008 RID: 8 RVA: 0x00002108 File Offset: 0x00000308
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			// Token: 0x06000009 RID: 9 RVA: 0x00002114 File Offset: 0x00000314
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		[HelpKeyword("My.User")]
		internal static User User
		{
			// Token: 0x0600000A RID: 10 RVA: 0x00002120 File Offset: 0x00000320
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000006 RID: 6
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			// Token: 0x0600000B RID: 11 RVA: 0x0000212C File Offset: 0x0000032C
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000007 RID: 7
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			// Token: 0x0600000C RID: 12 RVA: 0x00002138 File Offset: 0x00000338
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000006 RID: 6
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000007 RID: 7
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000008 RID: 8
		[EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x0600003F RID: 63 RVA: 0x00002FFC File Offset: 0x000011FC
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				T result;
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						try
						{
							result = Activator.CreateInstance<T>();
							return result;
						}
						object arg_74_0;
						TargetInvocationException expr_79 = arg_74_0 as TargetInvocationException;
						int arg_93_0;
						if (expr_79 == null)
						{
							arg_93_0 = 0;
						}
						else
						{
							ProjectData.SetProjectError(expr_79);
							TargetInvocationException ex = expr_79;
							arg_93_0 = (((ex.InnerException != null) > false) ? 1 : 0);
						}
						endfilter(arg_93_0);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				result = Instance;
				return result;
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00003100 File Offset: 0x00001300
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00002178 File Offset: 0x00000378
			[DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x06000042 RID: 66 RVA: 0x00003115 File Offset: 0x00001315
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00003123 File Offset: 0x00001323
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000044 RID: 68 RVA: 0x0000312B File Offset: 0x0000132B
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000045 RID: 69 RVA: 0x00003137 File Offset: 0x00001337
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000016 RID: 22
			public MainForm MainForm
			{
				// Token: 0x06000046 RID: 70 RVA: 0x0000313F File Offset: 0x0000133F
				get
				{
					this.m_MainForm = MyProject.MyForms.Create__Instance__<MainForm>(this.m_MainForm);
					return this.m_MainForm;
				}
				// Token: 0x06000047 RID: 71 RVA: 0x00003158 File Offset: 0x00001358
				set
				{
					if (value != this.m_MainForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MainForm>(ref this.m_MainForm);
					}
				}
			}

			// Token: 0x04000017 RID: 23
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04000018 RID: 24
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MainForm m_MainForm;
		}

		// Token: 0x02000009 RID: 9
		[EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x06000048 RID: 72 RVA: 0x00003115 File Offset: 0x00001315
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000049 RID: 73 RVA: 0x00003123 File Offset: 0x00001323
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600004A RID: 74 RVA: 0x0000317D File Offset: 0x0000137D
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600004B RID: 75 RVA: 0x00003137 File Offset: 0x00001337
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600004C RID: 76 RVA: 0x0000318C File Offset: 0x0000138C
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				T result;
				if (instance == null)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x0600004D RID: 77 RVA: 0x000031AC File Offset: 0x000013AC
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x0600004E RID: 78 RVA: 0x00002178 File Offset: 0x00000378
			[DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x0200000A RID: 10
		[EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000017 RID: 23
			internal T GetInstance
			{
				// Token: 0x0600004F RID: 79 RVA: 0x000031B5 File Offset: 0x000013B5
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000050 RID: 80 RVA: 0x00002178 File Offset: 0x00000378
			[DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04000019 RID: 25
			[CompilerGenerated, ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
