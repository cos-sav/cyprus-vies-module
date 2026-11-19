using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace xSADReports.My.Resources;

/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class ActionImages
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	/// <summary>
	///   Returns the cached ResourceManager instance used by this class.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				resourceMan = new ResourceManager("xSADReports.ActionImages", typeof(ActionImages).Assembly);
			}
			return resourceMan;
		}
	}

	/// <summary>
	///   Overrides the current thread's CurrentUICulture property for all
	///   resource lookups using this strongly typed resource class.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap IconApplication_32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("IconApplication_32", resourceCulture));

	internal static Bitmap Preview => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Preview", resourceCulture));

	internal static Icon Preview1 => (Icon)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Preview1", resourceCulture));

	internal static Bitmap Preview32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Preview32", resourceCulture));

	internal static Bitmap Up24 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Up24", resourceCulture));

	internal ActionImages()
	{
	}
}
