namespace GoogleContactsMap.GUI
{
	partial class ContactsViewForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.address1FormattedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet = new GoogleContactsMap.DataSet();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.address1FormattedDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.contactsBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(398, 334);
			this.dataGridView1.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 60;
			// 
			// address1FormattedDataGridViewTextBoxColumn
			// 
			this.address1FormattedDataGridViewTextBoxColumn.DataPropertyName = "Address 1 - Formatted";
			this.address1FormattedDataGridViewTextBoxColumn.HeaderText = "Address 1 - Formatted";
			this.address1FormattedDataGridViewTextBoxColumn.Name = "address1FormattedDataGridViewTextBoxColumn";
			this.address1FormattedDataGridViewTextBoxColumn.Width = 124;
			// 
			// contactsBindingSource
			// 
			this.contactsBindingSource.DataMember = "Contacts";
			this.contactsBindingSource.DataSource = this.dataSet;
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ContactsViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 334);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ContactsViewForm";
			this.Text = "ContactsViewForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn address1FormattedDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource contactsBindingSource;
		private DataSet dataSet;
	}
}