using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	public static MySettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Driver={Sage Line 50 v16};uid=manager;dir=C:\\DOCUMENTS AND SETTINGS\\ALL USERS\\APPLICATION DATA\\SAGE\\ACCOUNTS\\2010\\COMPANY.001\\ACCDATA")]
	public string Sage15_ConnectionString => Conversions.ToString(this["Sage15_ConnectionString"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Driver={Sage Line 50 v16};uid=manager;dir=C:\\Documents and Settings\\All Users\\Application Data\\Sage\\Accounts\\2010\\Demodata\\Accdata")]
	public string Sage16_ConnectionString => Conversions.ToString(this["Sage16_ConnectionString"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Driver={Sage Line 50 v17};uid=manager;dir=c:\\programdata\\sage\\accounts\\2011\\company.000\\ACCDATA")]
	public string ConnectionString => Conversions.ToString(this["ConnectionString"]);
}
