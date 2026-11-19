namespace xSageDataObjects;

/// <summary>
///
/// </summary>
/// <remarks></remarks>
internal class SdoKeys
{
	/// <summary>
	///
	/// </summary>
	/// <param name="Version"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static string SerialNumber(SdoVersion Version)
	{
		switch (Version)
		{
		case SdoVersion.v10:
			return "";
		case SdoVersion.v11:
			return "SD09333";
		case SdoVersion.v12:
			return "SD45078";
		case SdoVersion.v13:
			return "SD45078";
		case SdoVersion.v14:
			return "SD78793";
		case SdoVersion.v15:
			return "SD81862";
		case SdoVersion.v16:
			return "SD94406";
		case SdoVersion.v17:
		case SdoVersion.v18:
			return "DEVELOP";
		case SdoVersion.v19:
			return "SD35447";
		case SdoVersion.v20:
			return "SD43485";
		case SdoVersion.v21:
			return "H694754";
		case SdoVersion.v22:
			return "SAGESDO";
		case SdoVersion.v23:
			return "SAGESDO";
		case SdoVersion.v24:
			return "SAGESDO";
		default:
			return string.Empty;
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="Version"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static string ActivationKey(SdoVersion Version)
	{
		switch (Version)
		{
		case SdoVersion.v10:
			return "";
		case SdoVersion.v11:
			return "JDFJHGK";
		case SdoVersion.v12:
			return "LFDDYGJ";
		case SdoVersion.v13:
			return "TEDCQZZ";
		case SdoVersion.v14:
			return "YCFFMHH";
		case SdoVersion.v15:
			return "UKDCCTJ";
		case SdoVersion.v16:
			return "CLVRDKM";
		case SdoVersion.v17:
			return "GFBPXLR";
		case SdoVersion.v18:
			return "GABIAMA";
		case SdoVersion.v19:
			return "REIBXDB";
		case SdoVersion.v20:
			return "KHEUCLQ";
		case SdoVersion.v21:
			return "HGWBNBE";
		case SdoVersion.v22:
			return "EAHDFBL";
		case SdoVersion.v23:
			return "RCYLSWK";
		case SdoVersion.v24:
			return "ZHIEKPK";
		case SdoVersion.v25:
		case SdoVersion.v26:
		case SdoVersion.v27:
		case SdoVersion.v28:
			return "EAHDFBL";
		default:
			return "";
		}
	}
}
