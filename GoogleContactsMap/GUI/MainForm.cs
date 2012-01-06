using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;
using GoogleContactsMap.Contacts;
using GoogleContactsMap.Mapping;

namespace GoogleContactsMap.GUI
{
	public partial class MainForm : Form
	{
		ContactList addresses = new ContactList();
		public ContactList Addresses { get { return addresses; } set { addresses = value; } }
		ContactsViewForm contactsView = new ContactsViewForm();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			comboBoxList1.DataSource = new List<object>(new string[] { "" });
			comboBoxList1.AddRow();

			CreateTestingAddresses();

			Login();
		}

		void Login()
		{
			LoginForm form = new LoginForm();
			if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				return;
			Addresses = form.Addresses;

			UpdateConnectionLabel();
			UpdateSources();
		}

		void UpdateConnectionLabel()
		{
			connectedLabel.Text = GetConnectionLabel();
		}

		string GetConnectionLabel()
		{
			if (Addresses == null || string.IsNullOrWhiteSpace(Addresses.Username))
				return "Not logged in";
			if (!Addresses.ValidCredentials)
				return "Invalid credentials for:  " + Addresses.Username;
			return "Successfully logged in as:  " + Addresses.Username;
		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void comboBoxList1_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateNumberOfRows();
			ContactList contacts = GetContactSequence();
			MapRoute route = new MapRoute();
			UpdateMapLink(route.CreateURL(contacts));
		}

		void UpdateNumberOfRows()
		{
			string last = comboBoxList1.SelectedValues[comboBoxList1.SelectedValues.Count - 1].ToString();
			string secondLast = comboBoxList1.SelectedValues[comboBoxList1.SelectedValues.Count - 2].ToString();
			if (comboBoxList1.Rows > 3 && string.IsNullOrWhiteSpace(last) && string.IsNullOrWhiteSpace(secondLast))
				comboBoxList1.RemoveRow();
			else if (!string.IsNullOrWhiteSpace(last))
			{
				comboBoxList1.AddRow();
			}
		}

		void UpdateSources()
		{
			List<object> names = new List<object>();
			foreach (Contact con in Addresses)
			{
				names.Add(con.Name);
			}
			comboBoxList1.DataSource = names;
		}

		private void mapLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string url = mapLink.Text;
			if (mapLink.Tag is string)
				url = mapLink.Tag as string;
			System.Diagnostics.Process.Start(mapLink.Text);
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			UpdateRoute();
		}

		void UpdateRoute()
		{
			SetWaitState(true, "Calculating Route...");
			try
			{
				ContactList contacts = GetContactSequence();
				MapRoute route = new MapRoute();
				route.CalculateRoute(contacts);
				distBox.Text = route.Distance.ToString("F1");
				UpdateMapLink(route.MapURL);
				AddRouteToTable(route);
			}
			catch (Exception ex) { MessageBox.Show("" + ex); }
			SetWaitState(false);
		}

		private void UpdateMapLink(string url)
		{
			mapLink.Text = url;
			mapLink.Tag = url;
		}

		void AddRouteToTable(MapRoute route)
		{
			if (route.NamesVisited.Count < 2) return;
			string names = route.NamesVisited[0];
			for (int i = 1; i < route.NamesVisited.Count; i++)
				names += "-" + route.NamesVisited[i];
			ListViewItem lvi = new ListViewItem(new string[] { names, "" + route.Distance, "" + route.MapURL });
			lvi.Name = names;
			ListViewItem [] lvis = visitedView.Items.Find(names, false);
			if (lvis == null || lvis.Length < 1)
				visitedView.Items.Add(lvi);
			DataSet.RoutesRow row = dataSet.Routes.NewRoutesRow();
			row.Distance = route.Distance;
			row.Route = names;
			row.Link = route.MapURL;
			dataSet.Routes.AddRoutesRow(row);
		}

		private ContactList GetContactSequence()
		{
			ContactList contacts = new ContactList();
			foreach (string name in comboBoxList1.SelectedValues)
			{
				Contact con = Addresses.Find(p => p.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
				if (con == null) continue;
				contacts.Add(con);
			}
			return contacts;
		}

		void CreateTestingAddresses()
		{
			Addresses.Add(new Contact() { Name = "Adrian", Address = "1/11 Kawerau Ave, Devonport, Auckland 0624" });
			Addresses.Add(new Contact() { Name = "Pranav", Address = "16 Balmain Road, Auckland" });
			Addresses.Add(new Contact() { Name = "Home", Address = "1/11 Kawerau Ave, Auckland" });
			UpdateSources();
		}

		void SetWaitState(bool isWaiting) { SetWaitState(isWaiting, "Calculate Route"); }
		void SetWaitState(bool isWaiting, string message)
		{
			this.calcButton.Text = message;
			if (isWaiting)
			{
				this.Cursor = Cursors.WaitCursor;
			}
			else
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.KeyCode == Keys.C)
				UpdateRoute();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int col = dataSet.Routes.Columns.IndexOf(dataSet.Routes.LinkColumn);
			if (e.RowIndex >= 0 && e.ColumnIndex == col)
				System.Diagnostics.Process.Start(dataSet.Routes[e.RowIndex].Link);
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			loadContacts();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			saveContacts();
		}

		void loadContacts()
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "CSV Files|*.csv|All Files|*.*";
			if (dlg.ShowDialog() != DialogResult.OK) return;
			Contacts.ContactsDatabaseManager mgr = new ContactsDatabaseManager();
			mgr.LoadDatabase(dataSet.Routes, dlg.FileName);
		}

		void saveContacts()
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "CSV Files|*.csv|All Files|*.*";
			if (dlg.ShowDialog() != DialogResult.OK) return;
			Contacts.ContactsDatabaseManager mgr = new ContactsDatabaseManager();
			mgr.SaveDatabase(dataSet.Routes, dlg.FileName);
		}

		private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
		{
			MessageBox.Show("setting data source " + dataSet + ", " + dataGridView1.DataSource);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Program.Data = this.dataSet;
		}

		private void viewButton_Click(object sender, EventArgs e)
		{
			showContacts();
		}

		void showContacts()
		{
			if (contactsView == null)
			{
				contactsView = new ContactsViewForm();
				contactsView.FormClosing += (o, e) => { e.Cancel = true; contactsView.Hide(); };
			}
			contactsView.Show();
		}
	}
}
