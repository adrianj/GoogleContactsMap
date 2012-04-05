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

        ContactsViewForm contactsView;

		public MainForm()
		{
			InitializeComponent();
            dataSet.Contacts.RowChanged += (o, e) => { UpdateSources(); };
            dataSet.Contacts.RowDeleted += (o, e) => { UpdateSources(); };
            dataSet.Contacts.TableNewRow += (o, e) => { UpdateSources(); };
		}

        private void MainForm_Shown(object sender, EventArgs e)
        {
            comboBoxList1.DataSource = new List<object>(new string[] { "" });
            comboBoxList1.AddRow();


            if (!string.IsNullOrWhiteSpace(PreviousAddressManager.ContactsFile))
                LoadContacts(PreviousAddressManager.ContactsFile);
            //CreateTestingAddresses();
            //Login();

        }

		void Login()
		{
			LoginForm form = new LoginForm();
			if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				return;
            ContactsDatabaseManager mgr = new ContactsDatabaseManager();
            mgr.LoadDatabaseFromContactList(dataSet.Contacts, form.Addresses);
			//Addresses = form.Addresses;

			UpdateSources();
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
            SetWaitState(true, "Updating Contacts Database.");
            
			List<string> names = new List<string>();
            names.Add("");
			foreach (DataSet.ContactsRow row in dataSet.Contacts.Rows)
			{
				names.Add(row.Name);
            }
            names.Sort((c1, c2) => { return c1.CompareTo(c2); });
			comboBoxList1.DataSource = names.Cast<object>().ToList();

            SetWaitState(false);
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
				AddRouteToTable(route);
			}
			catch (Exception ex) { MessageBox.Show("" + ex); }
			SetWaitState(false);
		}


		void AddRouteToTable(MapRoute route)
		{
			if (route.NamesVisited.Count < 2) return;
            string names = GetRouteName(route);
            DataSet.RoutesRow existing = dataSet.Routes.FindByRoute(names);
            if (existing != null) return;
			DataSet.RoutesRow row = dataSet.Routes.NewRoutesRow();
			row.Distance = route.Distance;
			row.Route = names;
			row.Link = route.MapURL;
			dataSet.Routes.AddRoutesRow(row);
		}

        private string GetRouteName(MapRoute route)
        {
            List<string> abbrevNames = new List<string>();
            foreach (string s in route.NamesVisited)
                abbrevNames.Add(AbbreviateName(s));
            string names = abbrevNames[0];
            for (int i = 1; i < abbrevNames.Count; i++)
                names += "-" + abbrevNames[i];
            return names;
        }

        string AbbreviateName(string name)
        {
            return name;
        }

		private ContactList GetContactSequence()
		{
			ContactList contacts = new ContactList();
			foreach (string name in comboBoxList1.SelectedValues)
			{
                DataSet.ContactsRow con = dataSet.Contacts.FindByName(name);
				if (con == null) continue;
                contacts.Add(new Contact() { Name = con.Name, Address = con._Address_1___Formatted });
			}
			return contacts;
		}

		void CreateTestingAddresses()
		{
            dataSet.Contacts.AddContactsRow("Adrian", "1/11 Kawerau Ave, Devonport, Auckland 0624");
			dataSet.Contacts.AddContactsRow("Pranav", "16 Balmain Road, Auckland");
			dataSet.Contacts.AddContactsRow("Home", "1/11 Kawerau Ave, Auckland");
			UpdateSources();
		}

		void SetWaitState(bool isWaiting) { SetWaitState(isWaiting, "Calculate Route"); }
		void SetWaitState(bool isWaiting, string message)
		{
            this.calcButton.Text = message;
            this.calcButton.Enabled = !isWaiting;
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
			LoadContacts();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrWhiteSpace(PreviousAddressManager.ContactsFile))
                SaveContacts();
            else
                SaveContacts(PreviousAddressManager.ContactsFile);
		}

        private void saveContactsAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveContacts();
        }

		void LoadContacts()
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "CSV Files|*.csv|All Files|*.*";
			if (dlg.ShowDialog() != DialogResult.OK) return;
            LoadContacts(dlg.FileName);
		}

        private void LoadContacts(string filename)
        {
            try
            {
                Contacts.ContactsDatabaseManager mgr = new ContactsDatabaseManager();
                mgr.LoadDatabaseFromFile(dataSet.Contacts, filename);
                UpdateSources();
                UpdateContactsFile(filename);
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

		void SaveContacts()
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "CSV Files|*.csv|All Files|*.*";
            if (dlg.ShowDialog() != DialogResult.OK) return; 
            SaveContacts(dlg.FileName);
            UpdateContactsFile(dlg.FileName);
		}

        private void SaveContacts(string filename)
        {
            Contacts.ContactsDatabaseManager mgr = new ContactsDatabaseManager();
            mgr.SaveDatabaseToFile(dataSet.Contacts, filename);
        }

        void UpdateContactsFile(string filename)
        {
            PreviousAddressManager.ContactsFile = filename;
            if (string.IsNullOrWhiteSpace(PreviousAddressManager.ContactsFile))
                statusLabel.Text = "No Contacts File!";
            else
                statusLabel.Text = "Contacts File: " + filename;
        }

		private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
		{
			//MessageBox.Show("setting data source " + dataSet + ", " + dataGridView1.DataSource);
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
                contactsView.DataSource = this.dataSet.Contacts;
			}
			contactsView.Show();
		}

        private void dataBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            //MessageBox.Show("Add new data: " + e.NewObject);
        }


	}
}
