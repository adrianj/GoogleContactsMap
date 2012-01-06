using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoogleContactsMap.Contacts;

namespace GoogleContactsMap.GUI
{
	public partial class LoginForm : Form
	{
		public string Username { get { return addressBox.Text; } set { addressBox.Text = value; } }
		ContactList addresses = new ContactList();
		public ContactList Addresses { get { return addresses; } set { addresses = value; } }

		public LoginForm()
		{
			InitializeComponent();
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			SetWaitState(true, "Downloading contacts from Google...");
			try
			{
				ContactList addresses = ContactsQueryGenerator.GetAddressListFromGoogle(Username, passwordBox.Text);
				Addresses = addresses;
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			catch (NotImplementedException ex) { MessageBox.Show("" + ex); }
			PreviousAddressManager.StoreAddress(Username);
			SetWaitState(false);
		}


		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void LoginForm_Shown(object sender, EventArgs e)
		{
			addressBox.Items.Clear();
			addressBox.Items.AddRange(PreviousAddressManager.ReadPreviousAddresses());
			if (addressBox.Items.Count > 0)
				Username = addressBox.Items[0] as string;
			if (!string.IsNullOrWhiteSpace(Username))
				passwordBox.Focus();
		}

		void SetWaitState(bool isWaiting) { SetWaitState(isWaiting, "Login"); }
		void SetWaitState(bool isWaiting, string message)
		{
			this.Text = message;
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
