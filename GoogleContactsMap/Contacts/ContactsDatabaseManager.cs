using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using ElencySolutions.CsvHelper;

namespace GoogleContactsMap.Contacts
{
	public class ContactsDatabaseManager
	{
		public void SaveDatabase(DataTable data, string destFile)
		{
			CsvFile file = new CsvFile();
			foreach (DataColumn col in data.Columns)
				file.Headers.Add(col.ColumnName);
			int nCols = data.Columns.Count;
			foreach (DataRow row in data.Rows)
			{
				CsvRecord record = new CsvRecord();
				for (int i = 0; i < nCols; i++)
					record.Fields.Add(row[i].ToString());
				file.Records.Add(record);
			}
			using (CsvWriter writer = new CsvWriter())
			{
				writer.WriteCsv(file, destFile);
			}
		}

		public void LoadDatabase(DataTable data, string srcFile)
		{
			using (CsvReader reader = new CsvReader(srcFile))
			{
				reader.ReadNextRecord();
				if (reader.FieldCount != data.Columns.Count)
					throw new DataException("CSV file " + srcFile + " has incorrect number of columns.");
				data.Clear();
				while (reader.ReadNextRecord())
				{
					DataRow row = data.NewRow();
					for (int i = 0; i < data.Columns.Count; i++ )
						row[i] = reader.Fields[i];
					data.Rows.Add(row);
				}
			}
		}
	}
}
