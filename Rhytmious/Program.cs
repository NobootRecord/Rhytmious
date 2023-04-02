using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Rhytmious
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
			Application.Run(new MainForm());
		}

		static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			// Generate exception information message

			string ExceptionInfo = "";

			ExceptionInfo += "=== BEGIN BUG REPORT ===" + Environment.NewLine;
			ExceptionInfo += Environment.NewLine;

			ExceptionInfo += "::: Program executable file :::" + Environment.NewLine;
			ExceptionInfo += Environment.NewLine;

			ExceptionInfo += "Product name: " + Application.ProductName + Environment.NewLine;
			ExceptionInfo += "Product version: " + Application.ProductVersion.Substring(0, 3) + Environment.NewLine;
			ExceptionInfo += "Product manufacturer: " + Application.CompanyName + Environment.NewLine;
			ExceptionInfo += "File creation date/time: " + File.GetLastWriteTime(Application.ExecutablePath) + Environment.NewLine;
			ExceptionInfo += "Command line: " + Environment.CommandLine + Environment.NewLine;
			ExceptionInfo += Environment.NewLine;

			ExceptionInfo += "::: System information :::" + Environment.NewLine;
			ExceptionInfo += Environment.NewLine;

			ExceptionInfo += "Windows NT version: " + Environment.OSVersion.ToString() + Environment.NewLine;
			ExceptionInfo += "CLR environment version: " + Environment.Version.ToString() + Environment.NewLine;
			ExceptionInfo += "Physical memory: " + Environment.WorkingSet.ToString() + Environment.NewLine;
			ExceptionInfo += Environment.NewLine;

			ExceptionInfo += "::: Exception details :::" + Environment.NewLine;
			ExceptionInfo += Environment.NewLine;

			ExceptionInfo += e.Exception.ToString() + Environment.NewLine;
			ExceptionInfo += Environment.NewLine;

			ExceptionInfo += "=== END BUG REPORT === ";

			// Generate bug report file

			string fn = Application.ProductName + "_BugReport_" + DateTime.Now.ToShortDateString().Replace(".", "") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "") + ".log";
			StreamWriter sw = File.CreateText(fn); sw.Write(ExceptionInfo); sw.Close();

			// Show message box and exit

			MessageBox.Show("It looks like something has gone wrong. The program will be closed and all unsaved data will be lost." + Environment.NewLine + "You can contact your system administrator or the program developer for more details." + Environment.NewLine + Environment.NewLine + "Bug report has been successfully generated and can be seen at: " + fn, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			Application.ExitThread(); 
		}
	}
}
