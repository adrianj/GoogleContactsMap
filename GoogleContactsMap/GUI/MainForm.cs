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

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			comboBoxList1.AddRow();
			Login();
		}

		void Login()
		{
			string username = SettingsManager.PreviousEmailAddress;
			Addresses = LoginForm.LoginAndGetAddressList(Addresses, username);

			UpdateConnectionLabel();
			UpdateSources();
			SettingsManager.PreviousEmailAddress = Addresses.Username;
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
				MapRoute route = new MapRoute();
				foreach (string name in comboBoxList1.SelectedValues)
				{
					Contact con = Addresses.Find(p => p.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
					if (con == null) continue;
					route.Add(con);
				}
				route.CalculateRoute();
				distBox.Text = route.Distance.ToString("F1");
				mapLink.Text = route.MapURL;
				mapLink.Tag = route.MapURL;
			}
			catch (Exception ex) { MessageBox.Show("" + ex); }
			SetWaitState(false);
		}

		void CreateTestingAddresses()
		{
			Addresses.Add(new Contact() { Name = "Adrian", Address = "1/11 Kawerau Ave, Devonport, Auckland 0624" });
			Addresses.Add(new Contact() { Name = "Pranav", Address = "16 Balmain Road, Auckland" });
			Addresses.Add(new Contact() { Name = "Home", Address = "1/11 Kawerau Ave, Auckland" });
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
	}
}
