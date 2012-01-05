using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GoogleContactsMap.GUI
{
	public partial class ComboBoxList : UserControl
	{
		public event EventHandler SelectedValueChanged;
		public int ChangedIndex { get; set; }
		public bool EnsureDataValid { get; set; }

		List<object> dSource = new List<object>(new string[]{""});
		public List<object> DataSource
		{
			get { return dSource; }
			set
			{
				if (value == null || value.Count < 1) throw new ArgumentException("DataSource cannot be null or empty."); ;
				dSource = value;
				foreach (ComboBox c in boxes)
				{
					UpdateDataSource(c);
				}
			}
		}

		private void UpdateDataSource(ComboBox c)
		{
			c.SelectedValueChanged -= new EventHandler(newBox_SelectedValueChanged);
			c.Items.Clear();
			c.Items.AddRange(dSource.ToArray());
			c.SelectedIndex = 0;
			c.SelectedValueChanged += new EventHandler(newBox_SelectedValueChanged);
		}

		public List<object> SelectedValues
		{
			get
			{
				List<object> ret = new List<object>();
				foreach (ComboBox c in boxes)
				{
					ret.Add(c.SelectedItem);
				}
				return ret;
			}
		}

		List<ComboBox> boxes = new List<ComboBox>();

		int boxHeight = 25;
		public int BoxHeight
		{
			get { return boxHeight; }
			set
			{
				if (value < 15) return;
				boxHeight = value;
				UpdateBoxSizes();
			}
		}

		int boxWidth = 150;
		public int BoxWidth
		{
			get { return boxWidth; }
			set
			{
				if (value < 10) return;
				boxWidth = value;
				UpdateBoxSizes();
			}
		}

		public int Rows
		{
			get { return boxes.Count; }
			set
			{
				if (value < 1) { throw new ArgumentOutOfRangeException("Minimum number of boxes is 1."); }
				while (this.Rows < value)
					AddRow();
				while (this.Rows > value)
					RemoveRow();
			}
		}

		public ComboBoxList()
		{
			InitializeComponent();
			AddRow();
		}

		public void AddRow()
		{
			ComboBox newBox = new ComboBox();
			newBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			newBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			newBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			UpdateDataSource(newBox);
			boxes.Add(newBox);
			this.Controls.Add(newBox);
			newBox.Validating += new CancelEventHandler(newBox_Validating);
			UpdateBoxSizes();
		}

		void newBox_Validating(object sender, CancelEventArgs e)
		{
			ValidateComboBox(sender as ComboBox);
		}

		public void RemoveRow()
		{
			if (boxes.Count <= 0) return;
			ComboBox last = boxes[boxes.Count - 1];
			boxes.Remove(last);
			this.Controls.Remove(last);
			UpdateBoxSizes();
		}

		void newBox_SelectedValueChanged(object sender, EventArgs e)
		{
			ValidateComboBox(sender as ComboBox);
			ChangedIndex = boxes.FindIndex(p => p == sender);
			FireSelectedValueChangedEvent();
		}

		void ValidateComboBox(ComboBox cb)
		{
			if (EnsureDataValid)
			{
				if (!DataSource.Contains(cb.SelectedItem))
				{
					cb.SelectedIndex = 0;
					return;
				}
			}
			if (cb.SelectedItem == null)
				cb.SelectedIndex = 0;
		}

		void FireSelectedValueChangedEvent()
		{
			if (SelectedValueChanged != null)
				SelectedValueChanged(this, EventArgs.Empty);
		}

		private void ComboBoxList_SizeChanged(object sender, EventArgs e)
		{
			this.Width = boxWidth;
		}

		void UpdateBoxSizes()
		{
			for (int i = 0; i < boxes.Count; i++)
			{
				boxes[i].Top = (boxHeight + 6) * i;
				boxes[i].Left = 0;
				boxes[i].Width = boxWidth;
				SetComboHeight(boxes[i], boxHeight);
			}
			this.Height = (boxHeight + 6) * Rows;
		}

		[DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
		public static extern int SendMessage(IntPtr hwnd, uint Msg, int wParam, int lParam);



		private void SetComboHeight(ComboBox ctrl, int iNewHeight)
		{
			const uint CB_SETITEMHEIGHT = 0x153;
			SendMessage(ctrl.Handle, CB_SETITEMHEIGHT, -1, iNewHeight);
			ctrl.Refresh();
		}

		
	}
}
