using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoogleContactsMap.GUI
{
	public partial class ContactsViewForm : Form
	{
        public object DataSource { get { return this.dataGridView1.DataSource; } set { this.dataGridView1.DataSource = value; } }


		public ContactsViewForm()
		{
			InitializeComponent();
		}
	}
}
