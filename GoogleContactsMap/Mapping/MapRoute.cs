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
	public class MapRoute : Contacts.ContactList
	{
		public double Distance { get; set; }
		public string MapURL { get; set; }

		public void CalculateRoute()
		{
			Distance = 0;
			MapURL = "http://maps.google.com/"; 
			FilterEmptyNames();

			if (this.Count == 0)
				return;

			DirectionsRequest req = new DirectionsRequest();
			req.Origin = this[0].Address;
			req.Destination = this[this.Count - 1].Address;

			MapURL += "?saddr=" + req.Origin;
			MapURL += "&daddr=";

			foreach (Contacts.Contact c in this)
			{
				Console.WriteLine("" + c.Name + ", " + c.Address);
			}

			if (this.Count > 2)
			{
				List<string> waypoints = new List<string>();
				for (int i = 1; i < this.Count - 1; i++)
				{
					MapURL += this[i].Address+"+to:";
					waypoints.Add(this[i].Address);
				}
				req.Waypoints = waypoints.ToArray();
			}
			MapURL += req.Destination;
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
			MapURL = MapURL.Replace(Environment.NewLine, ",");
			MapURL = MapURL.Replace("\n", ",");
			MapURL = MapURL.Replace("\r", "");

			Console.WriteLine("" + MapURL);
		}


		private void FilterEmptyNames()
		{

			this.RemoveAll(p => string.IsNullOrWhiteSpace(p.Name));
		}

	}
}
