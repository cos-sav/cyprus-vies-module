namespace xSageDataObjects;

public class SageConnectionProperties
{
	public string SageDataPath { get; set; }

	public string Username { get; set; }

	public string Password { get; set; }

	public SdoVersion SageVersion { get; set; }

	public SageConnectionProperties()
	{
	}

	public SageConnectionProperties(string sageDataPath, string username, string password, SdoVersion sageVersion)
		: this()
	{
		SageDataPath = sageDataPath;
		Username = username;
		Password = password;
		SageVersion = sageVersion;
	}
}
