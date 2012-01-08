using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Google.GData.Contacts;

namespace GoogleContactsMap.Contacts
{
	public class ContactList : List<Contact>
	{
		public string Username { get; set; }
		public bool ValidCredentials { get; set; }

		public ContactList()
		{
			this.Reset();
		}

		public ContactList(IEnumerable<Contact> clone) : base(clone)
		{

		}

		public void AddFromFeed(ContactsFeed feed)
		{
			foreach (ContactEntry en in feed.Entries)
			{
				if (en.Name == null) continue;
				string addr = "";
				if (en.PrimaryPostalAddress != null)
					addr = en.PrimaryPostalAddress.FormattedAddress;
				else if (en.PostalAddresses.Count > 0)
					addr = en.PostalAddresses[0].FormattedAddress;

				if (string.IsNullOrWhiteSpace(addr)) continue;
				Contact con = new Contact();
				con.Name = en.Name.FullName;
				con.Address = addr;
				this.Add(con);
			}
		}

		void Reset()
		{
			this.Clear();
			this.Add(Contact.EmptyContact);
		}
	}
}
