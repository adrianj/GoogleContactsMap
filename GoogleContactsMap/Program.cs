using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GoogleContactsMap
{
	static class Program
	{
		public static DataSet Data = new DataSet();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new GUI.MainForm());
		}
	}
}
