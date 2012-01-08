using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;

namespace GoogleContactsMap.GUI
{
	public class RouteTable : DataTable
	{
		public RouteRow this[int index] { get { return (RouteRow)Rows[index]; } }

		public RouteTable()
		{
			Columns.Add(new DataColumn("Route", typeof(string)));
			Columns.Add(new DataColumn("Distance", typeof(double)));
			Columns.Add(new DataColumn("Link", typeof(string)));
		}

		public void Add(RouteRow row) { Rows.Add(row); }
		public void Remove(RouteRow row) { Rows.Remove(row); }
		public RouteRow GetNewRow() { return (RouteRow)NewRow(); }

		protected override Type GetRowType()
		{
			return typeof(RouteRow);
		}
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new RouteRow(builder);
		}
	}

	public class RouteRow : DataRow
	{
		public string Route { get { return (string)base["Route"]; } set { base["Route"] = value; } }
		public double Distance { get { return (double)base["Distance"]; } set { base["Distance"] = value; } }
		public string Link { get { return (string)base["Link"]; } set { base["Link"] = value; } }

		internal RouteRow(DataRowBuilder builder) : base(builder) {
			Route = "";
			Distance = 0;
			Link = "";
		}
	}
}
