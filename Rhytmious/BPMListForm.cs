using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rhytmious
{
	public partial class BPMListForm : Form
	{
		MainForm mainf;

		public BPMListForm(MainForm owner)
		{
			this.Owner = mainf = owner;
			InitializeComponent();
		}

		private void BPMListForm_Load(object sender, EventArgs e)
		{

		}

		private void BPMListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true; this.Hide();
		}
	}
}
