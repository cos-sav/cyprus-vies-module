using System;
using System.Data.Odbc;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SageDataObject150;
using SageDataObject160;
using SageDataObject170;
using SageDataObject180;
using SageDataObject190;
using SageDataObject200;
using SageDataObject210;
using SageDataObject220;
using SageDataObject230;
using SageDataObject240;
using SageDataObject250;
using SageDataObject260;
using SageDataObject270;
using SageDataObject280;
using SageDataObject290;
using SageDataObject300;
using SageDataObject310;
using SageDataObject320;
using SageDataObject330;
using xSageDataObjects.My;

namespace xSageDataObjects;

/// <summary>
///
/// </summary>
/// <remarks></remarks>
public class Engine
{
	private SdoVersion _SdoVersion;

	private object _SdoEngine;

	private object _SdoWorkspace;

	private string _DataPath;

	private string _Username;

	private string _Password;

	private bool _IsInitialized;

	private bool _IsConnected;

	private const string _WorkspaceName = "SDO_WorkSpace";

	public static bool Is64BitProcess => false;

	/// <summary>
	/// </summary>	
	public object ActiveWorkSpace => _SdoWorkspace;

	/// <summary>
	///
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public bool IsInitialized => _IsInitialized;

	/// <summary>
	///
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public bool IsConnected => _IsConnected;

	/// <summary>
	///
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public string LastErrorText => Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(_SdoEngine, null, "LastError", new object[0], null, null, null), null, "Text", new object[0], null, null, null));

	/// <summary>
	///
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public string LastErrorCode => Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(_SdoEngine, null, "LastError", new object[0], null, null, null), null, "Code", new object[0], null, null, null));

	/// <summary>
	///
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public string ConnectionString => "Driver={Sage Line 50 v" + Conversions.ToString((int)_SdoVersion) + "};uid=" + _Username + ";pwd=" + _Password + ";dir=" + _DataPath;

	/// <summary>
	///
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public OdbcConnection OdbcConnection => new OdbcConnection(ConnectionString);

	/// <param name="Version">
	/// Sage Line50 SDO version
	/// </param>    
	public Engine(SdoVersion Version)
	{
		if (Is64BitProcess)
		{
			Interaction.MsgBox("xSAD application does not support 64-bit. Please recompile for x86.");
		}
		_SdoVersion = Version;
		_IsInitialized = true;
		_IsConnected = false;
		_DataPath = "";
		_Username = "";
		_Password = "";
		try
		{
			switch (_SdoVersion)
			{
			case SdoVersion.v15:
				_SdoEngine = (SageDataObject150.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("A29354FB-35FA-4CD4-8261-DAD864982348")));
				break;
			case SdoVersion.v16:
				_SdoEngine = (SageDataObject160.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("81F4150A-2F39-44B8-A4DC-666CD0C1FB67")));
				break;
			case SdoVersion.v17:
				_SdoEngine = (SageDataObject170.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("0C42A671-A0E4-4326-8AC8-7D451A89F1BC")));
				break;
			case SdoVersion.v18:
				_SdoEngine = (SageDataObject180.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("3CCA7768-E5C4-420E-B75D-754E0477A028")));
				break;
			case SdoVersion.v19:
				_SdoEngine = (SageDataObject190.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("9C08F1D2-7215-4A33-A445-24EBD1067F4E")));
				break;
			case SdoVersion.v20:
				_SdoEngine = (SageDataObject200.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("3813CB51-2EE9-4317-AD16-D2AA2F09B360")));
				break;
			case SdoVersion.v21:
				_SdoEngine = (SageDataObject210.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("32F9466C-D217-481E-933C-C898F8D9A9D4")));
				break;
			case SdoVersion.v22:
				_SdoEngine = (SageDataObject220.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("822F6971-7E17-4C51-9CBC-A01B25D534C1")));
				break;
			case SdoVersion.v23:
				_SdoEngine = (SageDataObject230.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("7697C990-F754-44DF-8552-8AD965F726E6")));
				break;
			case SdoVersion.v24:
				_SdoEngine = (SageDataObject240.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00D8968C-64D5-4FD5-9457-ADDABC8E03BB")));
				break;
			case SdoVersion.v25:
				_SdoEngine = (SageDataObject250.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("221A2522-FCDB-4416-85F8-7715495DAA76")));
				break;
			case SdoVersion.v26:
				_SdoEngine = (SageDataObject260.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("313C6D6D-211B-426F-A3FE-9143E6A50EDC")));
				break;
			case SdoVersion.v27:
				_SdoEngine = (SageDataObject270.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("12F6D4FB-4554-4166-BB3A-7CD513353952")));
				break;
			case SdoVersion.v28:
				_SdoEngine = (SageDataObject280.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("D6C9924D-3E18-45D7-B2B4-09238BF37087")));
				break;
			case SdoVersion.v29:
				_SdoEngine = (SageDataObject290.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("663048C4-DAEA-4125-9F02-4F1DFB8F4666")));
				break;
			case SdoVersion.v30:
				_SdoEngine = (SageDataObject300.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("966F2F86-3663-4D34-9AFE-06A255594BCF")));
				break;
			case SdoVersion.v31:
				_SdoEngine = (SageDataObject310.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("43A0ABC0-2A7F-48B8-A410-F6FE91A3C611")));
				break;
			case SdoVersion.v32:
				_SdoEngine = (SageDataObject320.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("2CCBA24E-16DD-4F45-9DA9-C32AD42DF091")));
				break;
			case SdoVersion.v33:
				_SdoEngine = (SageDataObject330.SDOEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("41BCBD11-32F8-4254-82B9-471DE0A904FA")));
				break;
			default:
				throw new ArgumentOutOfRangeException("Version", Version, "Supplied Sage version is not supported.");
			}
			if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(_SdoEngine, null, "IsRegistered", new object[0], null, null, null))))
			{
				NewLateBinding.LateCall(_SdoEngine, null, "Register", new object[5]
				{
					SdoKeys.SerialNumber(Version),
					SdoKeys.ActivationKey(Version),
					string.Empty,
					string.Empty,
					10
				}, null, null, null, IgnoreReturn: true);
				if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(_SdoEngine, null, "IsRegistered", new object[0], null, null, null))))
				{
					throw new Exception("SageDataObjects failed to register with supplied keys.");
				}
			}
			_SdoWorkspace = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_SdoEngine, null, "Workspaces", new object[0], null, null, null), null, "Add", new object[1] { "SDO_WorkSpace" }, null, null, null));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			_SdoEngine = null;
			_SdoWorkspace = null;
			_IsInitialized = false;
			throw;
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="SplitNumber"></param>
	/// <remarks></remarks>
	public bool SetTransactionFlag_VATReconciled(int SplitNumber, bool ReconciledFlag, DateTime ReconciledDate)
	{
		if (!IsInitialized)
		{
			throw new Exception("Engine is not initialized.");
		}
		if (!IsConnected)
		{
			throw new Exception("Engine is not connected to a Sage company dataset.");
		}
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(_SdoWorkspace, null, "CreateObject", new object[1] { "SplitData" }, null, null, null));
			NewLateBinding.LateCall(objectValue, null, "MoveFirst", new object[0], null, null, null, IgnoreReturn: true);
			object instance = objectValue;
			object[] obj = new object[1] { SplitNumber };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(instance, null, "Read", obj, null, null, obj2, IgnoreReturn: true);
			if (array2[0])
			{
				SplitNumber = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "VAT_FLAG" }, null, null, null), null, "Value", new object[1] { ReconciledFlag }, null, null, OptimisticSet: false, RValueBase: true);
			if (ReconciledFlag)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "VAT_RECONCILED_DATE" }, null, null, null), null, "Value", new object[1] { ReconciledDate }, null, null, OptimisticSet: false, RValueBase: true);
			}
			object value = NewLateBinding.LateGet(objectValue, null, "Write", array = new object[1] { SplitNumber }, null, null, array2 = new bool[1] { true });
			if (array2[0])
			{
				SplitNumber = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			return Conversions.ToBoolean(value);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool flag = false;
			throw ex2;
		}
		finally
		{
			object objectValue = null;
		}
	}

	/// <summary>
	/// Connects active workspace to the selected company.
	/// </summary>
	public bool Connect(string DataPath, string Username, string Password, ref string Out_LastError)
	{
		if (!IsInitialized)
		{
			throw new Exception("Engine is not initialized.");
		}
		try
		{
			_DataPath = DataPath;
			_Username = Username;
			_Password = Password;
			if (_DataPath.EndsWith("\\"))
			{
				_DataPath = _DataPath.Remove(_DataPath.LastIndexOf("\\"), 1);
			}
			if (!_DataPath.ToUpper().EndsWith("ACCDATA"))
			{
				_DataPath += "\\ACCDATA";
			}
			object sdoWorkspace = _SdoWorkspace;
			object[] array = new object[4];
			ref string dataPath = ref _DataPath;
			array[0] = dataPath;
			ref string username = ref _Username;
			array[1] = username;
			ref string password = ref _Password;
			array[2] = password;
			array[3] = MyProject.Computer.Name;
			object[] array2 = array;
			bool[] array3;
			object value = NewLateBinding.LateGet(sdoWorkspace, null, "Connect", array, null, null, array3 = new bool[4] { true, true, true, false });
			if (array3[0])
			{
				dataPath = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
			if (array3[1])
			{
				username = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
			}
			if (array3[2])
			{
				password = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[2]), typeof(string));
			}
			_IsConnected = Conversions.ToBoolean(value);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(_SdoEngine, null, "LastError", new object[0], null, null, null), null, "Text", new object[0], null, null, null), "", TextCompare: false))
			{
				Out_LastError = "";
			}
			else
			{
				Out_LastError = Conversions.ToString(Operators.ConcatenateObject("Logon Failed Due to: ", NewLateBinding.LateGet(NewLateBinding.LateGet(_SdoEngine, null, "LastError", new object[0], null, null, null), null, "Text", new object[0], null, null, null)));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			_IsConnected = false;
			throw ex2;
		}
		return _IsConnected;
	}

	/// <summary>
	/// </summary>
	public void Disconnect()
	{
		if (IsInitialized)
		{
			NewLateBinding.LateCall(_SdoWorkspace, null, "Disconnect", new object[0], null, null, null, IgnoreReturn: true);
			_IsConnected = false;
		}
	}
}
