using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using xSAD_VIES.GUI;

namespace xSAD_VIES;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		try
		{
			RunX();
		}
		catch (Exception ex)
		{
			MessageBox.Show("L0: " + ex.Message + Environment.NewLine + ex.StackTrace);
		}
	}

	private static void RunX()
	{
		if (!Isx86())
		{
			MessageBox.Show("The program needs to be compiled for the x86 platform");
			return;
		}
		string fileName = Path.GetFileName(Application.ExecutablePath);
		bool createdNew;
		using (new Mutex(initiallyOwned: true, fileName, out createdNew))
		{
			if (createdNew)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(defaultValue: false);
				Application.Run(new frmMain());
			}
		}
	}

	private static bool Isx86()
	{
		return IntPtr.Size == 4;
	}
}
