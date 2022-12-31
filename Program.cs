﻿/*
 * Created by Ranorex
 * User: thabangra
 * Date: 06/15/2021
 * Time: 15:18
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace ISATest
{
	class Program
	{
		[STAThread]
		public static int Main(string[] args)
		{
			// Uncomment the following 2 lines if you want to automate Windows apps
			// by starting the test executable directly
			/*     if (Util.IsRestartRequiredForWinAppAccess)
           { return Util.RestartWithUiAccess();} */
			Ranorex.Core.Configuration.Current.Adapter.DefaultUseEnsureVisible = false;
			
			Ranorex.Core.Configuration.Current.Plugins.Win32.EnableBitBridge = true;
			Ranorex.Controls.ProgressForm.Show();
			Configuration.Current.SaveToUserSettings();
			
			
			
			Keyboard.AbortKey = System.Windows.Forms.Keys.J;
			int error = 0;

			try
			{
				error = TestSuiteRunner.Run(typeof(Program), Environment.CommandLine);
			}
			catch (Exception e)
			{
				Report.Error("Unexpected exception occurred: " + e.ToString());
				error = -1;
			}
			return error;
		}
	}
}
