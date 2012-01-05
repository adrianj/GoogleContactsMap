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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectedLabel = new System.Windows.Forms.Label();
			this.mapLink = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.distBox = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.comboBoxList1 = new GoogleContactsMap.GUI.ComboBoxList();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(373, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.loginToolStripMenuItem.Text = "Login";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
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
			this.mapLink.Location = new System.Drawing.Point(12, 185);
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
			this.label1.Location = new System.Drawing.Point(12, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Distance";
			// 
			// distBox
			// 
			this.distBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.distBox.Location = new System.Drawing.Point(64, 156);
			this.distBox.Name = "distBox";
			this.distBox.Size = new System.Drawing.Size(300, 20);
			this.distBox.TabIndex = 11;
			// 
			// calcButton
			// 
			this.calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.calcButton.Location = new System.Drawing.Point(15, 123);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(350, 23);
			this.calcButton.TabIndex = 8;
			this.calcButton.Text = "Calculate Route";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
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
			this.ClientSize = new System.Drawing.Size(373, 257);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.distBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mapLink);
			this.Controls.Add(this.connectedLabel);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.comboBoxList1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Google Contacts Map";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label connectedLabel;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
		private ComboBoxList comboBoxList1;
		private System.Windows.Forms.LinkLabel mapLink;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox distBox;
		private System.Windows.Forms.Button calcButton;
	}
}

