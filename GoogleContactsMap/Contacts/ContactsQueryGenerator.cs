using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;
using Google.Contacts;

namespace GoogleContactsMap.Contacts
{
	public class ContactsQueryGenerator
	{
		public static ContactList GetAddressListFromGoogle(string username, string password)
		{
			ContactList list = new ContactList();
			list.Username = username;

			string appName = "adrianj-GoogleContactsMap-1";
			ContactsService service = CreateService(username, password, appName);

			int contactsPerQuery = 50;
			int maxTotal = 32000;
			ContactsQuery query = new ContactsQuery(ContactsQuery.CreateContactsUri("default"));
			query.NumberToRetrieve = contactsPerQuery;

			for (int index = 0; index < maxTotal; index += contactsPerQuery)
			{
				query.StartIndex = index;
				ContactsFeed feed = GetContactsFeed(query, service);
				list.ValidCredentials = true;
				list.AddFromFeed(feed);
				if (feed.Entries.Count < contactsPerQuery)
					break;
			}

			return list;
		}


		private static ContactsFeed GetContactsFeed(ContactsQuery query, ContactsService service)
		{
			ContactsFeed feed = service.Query(query);
			return feed;
		}

		private static ContactsService CreateService(string username, string password, string appName)
		{
			ContactsService service = new ContactsService(appName);
			service.setUserCredentials(username, password);
			return service;
		}

	}
}
