using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Guard_profiler.Properties
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		internal static Bitmap accounts
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("accounts", Resources.resourceCulture);
			}
		}

		internal static Bitmap arrrrr
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("arrrrr", Resources.resourceCulture);
			}
		}

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

		internal static Bitmap hr_icon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("hr_icon", Resources.resourceCulture);
			}
		}

		internal static Bitmap image_placeholder
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("image_placeholder", Resources.resourceCulture);
			}
		}

		internal static Bitmap loginimg
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("loginimg", Resources.resourceCulture);
			}
		}

		internal static Bitmap loginimg1
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("loginimg1", Resources.resourceCulture);
			}
		}

		internal static Bitmap reports
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("reports", Resources.resourceCulture);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					Resources.resourceMan = new System.Resources.ResourceManager("Guard_profiler.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		internal static Bitmap user_admin_1
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("user-admin-1", Resources.resourceCulture);
			}
		}

		internal static Bitmap wages
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("wages", Resources.resourceCulture);
			}
		}

		internal Resources()
		{
		}
	}
}