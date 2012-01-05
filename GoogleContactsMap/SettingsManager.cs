using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GoogleContactsMap
{
	public class SettingsManager
	{
		public static string PreviousEmailAddress
		{
			get
			{
				return GoogleContactsMap.Properties.Settings.Default.PreviousEmailAddress;
			}
			set
			{
				GoogleContactsMap.Properties.Settings.Default.PreviousEmailAddress = value;
				GoogleContactsMap.Properties.Settings.Default.Save();
			}
		}
	}
}
