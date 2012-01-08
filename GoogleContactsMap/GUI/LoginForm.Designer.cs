namespace GoogleContactsMap.GUI
{
	partial class LoginForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.addressBox = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.passwordBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.submitButton, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.addressBox, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 98);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Email Address";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Password";
			// 
			// passwordBox
			// 
			this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.passwordBox, 2);
			this.passwordBox.Location = new System.Drawing.Point(100, 35);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(189, 20);
			this.passwordBox.TabIndex = 1;
			// 
			// submitButton
			// 
			this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.submitButton.Location = new System.Drawing.Point(11, 67);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 2;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(205, 67);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// addressBox
			// 
			this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.addressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.addressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.tableLayoutPanel1.SetColumnSpan(this.addressBox, 2);
			this.addressBox.FormattingEnabled = true;
			this.addressBox.Location = new System.Drawing.Point(100, 4);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(189, 21);
			this.addressBox.TabIndex = 10;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.submitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(292, 98);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Login";
			this.Shown += new System.EventHandler(this.LoginForm_Shown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ComboBox addressBox;
	}
}