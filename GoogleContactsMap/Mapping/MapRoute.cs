using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.StaticMaps;
using GoogleMapsApi.StaticMaps.Entities;
using GoogleMapsApi.Entities.Common;

namespace GoogleContactsMap.Mapping
{
	public class MapRoute
	{
		public double Distance { get; set; }
		public string MapURL { get; set; }
		public List<string> NamesVisited { get; set; }

		public MapRoute()
		{
			Distance = 0;
			MapURL = "http://maps.google.com/";
			NamesVisited = new List<string>();
		}

		public void CalculateRoute(Contacts.ContactList contacts)
		{
			Distance = 0;
			contacts = FilterEmptyNames(contacts);
			MapURL = CreateURL(contacts);

			if (contacts.Count == 0)
				return;

			NamesVisited.Clear();
			foreach (Contacts.Contact con in contacts)
				NamesVisited.Add(con.Name);

			DirectionsRequest req = new DirectionsRequest();
			req.Origin = contacts[0].Address;
			req.Destination = contacts[contacts.Count - 1].Address;

			if (contacts.Count > 2)
			{
				List<string> waypoints = new List<string>();
				for (int i = 1; i < contacts.Count - 1; i++)
				{
					waypoints.Add(contacts[i].Address);
				}
				req.Waypoints = waypoints.ToArray();
			}
			double dist = 0;
			List<Location> locations = new List<Location>();
			
			DirectionsResponse resp = GoogleMapsApi.MapsAPI.GetDirections(req);



			foreach (Route r in resp.Routes)
			{
				foreach (Leg l in r.Legs)
				{
					locations.Add(l.StartLocation);
					locations.Add(l.EndLocation);
					dist += l.Distance.Value;
				}

			}
			Distance = dist / 1000;
		}

		public string CreateURL(Contacts.ContactList contacts)
		{
			contacts = FilterEmptyNames(contacts);
			MapURL = "http://maps.google.com/";
			if (contacts.Count == 0)
				return MapURL;
			MapURL += "?saddr=" + contacts[0].Address;
			MapURL += "&daddr=";
			if (contacts.Count > 2)
			{
				for (int i = 1; i < contacts.Count - 1; i++)
				{
					MapURL += contacts[i].Address + "+to:";
				}
			}
			MapURL += contacts[contacts.Count - 1].Address;
			MapURL = MapURL.Replace("\n", ",");
			return MapURL;
		}


		private Contacts.ContactList FilterEmptyNames(Contacts.ContactList contacts)
		{
			Contacts.ContactList ret = new Contacts.ContactList(contacts);
			ret.RemoveAll(p => string.IsNullOrWhiteSpace(p.Name));
			return ret;
		}

	}
}
