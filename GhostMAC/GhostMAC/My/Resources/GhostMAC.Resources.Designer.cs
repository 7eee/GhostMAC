using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GhostMAC.My.Resources
{
	// Token: 0x02000003 RID: 3
	[StandardModule, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated, HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x17000001 RID: 1
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			// Token: 0x06000004 RID: 4 RVA: 0x000020BF File Offset: 0x000002BF
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					Resources.resourceMan = new ResourceManager("GhostMAC.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			// Token: 0x06000005 RID: 5 RVA: 0x000020F1 File Offset: 0x000002F1
			get
			{
				return Resources.resourceCulture;
			}
			// Token: 0x06000006 RID: 6 RVA: 0x000020F8 File Offset: 0x000002F8
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static ResourceManager resourceMan;

		// Token: 0x04000002 RID: 2
		private static CultureInfo resourceCulture;
	}
}
