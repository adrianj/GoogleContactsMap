using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GoogleContactsMap.Contacts
{
	public class Contact
	{
		public string Name { get; set; }
		public string Address { get; set; }

		public override string ToString()
		{
			return Name;
		}

		public static Contact EmptyContact { get { return new Contact() { Name = "", Address = "" }; } }
	}
}
