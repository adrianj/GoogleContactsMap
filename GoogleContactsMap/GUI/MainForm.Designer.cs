namespace GoogleContactsMap.GUI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openButton = new System.Windows.Forms.ToolStripMenuItem();
			this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
			this.importButton = new System.Windows.Forms.ToolStripMenuItem();
			this.viewButton = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.connectedLabel = new System.Windows.Forms.Label();
			this.mapLink = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.distBox = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.visitedView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet = new GoogleContactsMap.DataSet();
			this.comboBoxList1 = new GoogleContactsMap.GUI.ComboBoxList();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem1});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(374, 24);
			this.menuStrip.TabIndex = 5;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.importButton,
            this.viewButton});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openButton
			// 
			this.openButton.Name = "openButton";
			this.openButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openButton.Size = new System.Drawing.Size(263, 22);
			this.openButton.Text = "Open Contacts...";
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Name = "saveButton";
			this.saveButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveButton.Size = new System.Drawing.Size(263, 22);
			this.saveButton.Text = "Save Contacts...";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// importButton
			// 
			this.importButton.Name = "importButton";
			this.importButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.importButton.Size = new System.Drawing.Size(263, 22);
			this.importButton.Text = "Import Contacts From Google...";
			this.importButton.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
			// 
			// viewButton
			// 
			this.viewButton.Name = "viewButton";
			this.viewButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.viewButton.Size = new System.Drawing.Size(263, 22);
			this.viewButton.Text = "View Contacts...";
			this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem1,
            this.indexToolStripMenuItem1,
            this.searchToolStripMenuItem1,
            this.toolStripSeparator11,
            this.aboutToolStripMenuItem1});
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem1.Text = "&Help";
			// 
			// contentsToolStripMenuItem1
			// 
			this.contentsToolStripMenuItem1.Name = "contentsToolStripMenuItem1";
			this.contentsToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
			this.contentsToolStripMenuItem1.Text = "&Contents";
			// 
			// indexToolStripMenuItem1
			// 
			this.indexToolStripMenuItem1.Name = "indexToolStripMenuItem1";
			this.indexToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
			this.indexToolStripMenuItem1.Text = "&Index";
			// 
			// searchToolStripMenuItem1
			// 
			this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
			this.searchToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
			this.searchToolStripMenuItem1.Text = "&Search";
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(115, 6);
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
			this.aboutToolStripMenuItem1.Text = "&About...";
			// 
			// connectedLabel
			// 
			this.connectedLabel.AutoSize = true;
			this.connectedLabel.Location = new System.Drawing.Point(12, 32);
			this.connectedLabel.Name = "connectedLabel";
			this.connectedLabel.Size = new System.Drawing.Size(82, 13);
			this.connectedLabel.TabIndex = 6;
			this.connectedLabel.Text = "Not Connected!";
			// 
			// mapLink
			// 
			this.mapLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mapLink.AutoSize = true;
			this.mapLink.Location = new System.Drawing.Point(12, 507);
			this.mapLink.MaximumSize = new System.Drawing.Size(350, 150);
			this.mapLink.Name = "mapLink";
			this.mapLink.Size = new System.Drawing.Size(121, 13);
			this.mapLink.TabIndex = 12;
			this.mapLink.TabStop = true;
			this.mapLink.Text = "http://maps.google.com";
			this.mapLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mapLink_LinkClicked);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 481);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Distance";
			// 
			// distBox
			// 
			this.distBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.distBox.Location = new System.Drawing.Point(64, 478);
			this.distBox.Name = "distBox";
			this.distBox.Size = new System.Drawing.Size(302, 20);
			this.distBox.TabIndex = 11;
			// 
			// calcButton
			// 
			this.calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.calcButton.Location = new System.Drawing.Point(15, 445);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(351, 23);
			this.calcButton.TabIndex = 8;
			this.calcButton.Text = "&Calculate Route";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// visitedView
			// 
			this.visitedView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.visitedView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.visitedView.Location = new System.Drawing.Point(15, 523);
			this.visitedView.Name = "visitedView";
			this.visitedView.Size = new System.Drawing.Size(350, 56);
			this.visitedView.TabIndex = 13;
			this.visitedView.UseCompatibleStateImageBehavior = false;
			this.visitedView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Route";
			this.columnHeader1.Width = 230;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Distance";
			this.columnHeader2.Width = 55;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Map Link";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.routesBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(15, 197);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(347, 150);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// routeDataGridViewTextBoxColumn
			// 
			this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
			this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
			this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
			this.routeDataGridViewTextBoxColumn.Width = 61;
			// 
			// distanceDataGridViewTextBoxColumn
			// 
			this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
			this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
			this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
			this.distanceDataGridViewTextBoxColumn.Width = 74;
			// 
			// linkDataGridViewTextBoxColumn
			// 
			this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
			this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
			this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
			this.linkDataGridViewTextBoxColumn.Width = 52;
			// 
			// routesBindingSource
			// 
			this.routesBindingSource.DataMember = "Routes";
			this.routesBindingSource.DataSource = this.dataSet;
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSet1";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBoxList1
			// 
			this.comboBoxList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxList1.AutoSize = true;
			this.comboBoxList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.comboBoxList1.BoxHeight = 20;
			this.comboBoxList1.BoxWidth = 350;
			this.comboBoxList1.ChangedIndex = 0;
			this.comboBoxList1.DataSource = ((System.Collections.Generic.List<object>)(resources.GetObject("comboBoxList1.DataSource")));
			this.comboBoxList1.EnsureDataValid = false;
			this.comboBoxList1.Location = new System.Drawing.Point(15, 59);
			this.comboBoxList1.Margin = new System.Windows.Forms.Padding(0);
			this.comboBoxList1.Name = "comboBoxList1";
			this.comboBoxList1.Rows = 2;
			this.comboBoxList1.Size = new System.Drawing.Size(350, 52);
			this.comboBoxList1.TabIndex = 7;
			this.comboBoxList1.SelectedValueChanged += new System.EventHandler(this.comboBoxList1_SelectedValueChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(374, 579);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.visitedView);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.distBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mapLink);
			this.Controls.Add(this.connectedLabel);
			this.Controls.Add(this.comboBoxList1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Google Contacts Map";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.Label connectedLabel;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importButton;
		private ComboBoxList comboBoxList1;
		private System.Windows.Forms.LinkLabel mapLink;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox distBox;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.ListView visitedView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripMenuItem openButton;
		private System.Windows.Forms.ToolStripMenuItem saveButton;
		private GoogleContactsMap.DataSet dataSet;
		private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource routesBindingSource;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem viewButton;
	}
}

