using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace GoogleContactsMap.Contacts
{
	public static class PreviousAddressManager
	{
		public static int MaxAddressesToStore = 5;

        public static string ContactsFile
        {
            get { return GoogleContactsMap.Properties.Settings.Default.ContactsFilename; }
            set
            {
                GoogleContactsMap.Properties.Settings.Default.ContactsFilename = value;
                GoogleContactsMap.Properties.Settings.Default.Save();
            }
        }

		public static void StoreAddress(string address)
		{
			List<string> list = StringCollectionToList(GoogleContactsMap.Properties.Settings.Default.PreviousEmailAddresses);
			
			list.Insert(0, address);
			list = list.Distinct().ToList();
			if (list.Count > MaxAddressesToStore)
				list = list.GetRange(0, MaxAddressesToStore);
			GoogleContactsMap.Properties.Settings.Default.PreviousEmailAddresses = StringListToCollection(list);
			GoogleContactsMap.Properties.Settings.Default.Save();
		}

		public static string[] ReadPreviousAddresses()
		{
			return StringCollectionToArray(GoogleContactsMap.Properties.Settings.Default.PreviousEmailAddresses);
		}

		static StringCollection StringListToCollection(List<string> sl)
		{
			StringCollection sc = new StringCollection();
			sc.AddRange(sl.ToArray());
			return sc;
		}

		static string[] StringCollectionToArray(StringCollection sc)
		{
			string[] sl = new string[sc.Count];
			sc.CopyTo(sl, 0);
			return sl;
		}

		static List<string> StringCollectionToList(StringCollection sc)
		{
			return StringCollectionToArray(sc).ToList();
		}
	}
}
