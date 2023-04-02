using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Rhytmious
{
	public partial class AboutForm : Form
	{
		MainForm mainf;

		public AboutForm(MainForm owner)
		{
			this.Owner = mainf = owner;
			InitializeComponent();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			VersionLabel.Text = "Version " + Application.ProductVersion.Substring(0, 3) + " (" + File.GetLastWriteTime(Application.ExecutablePath) + ")";
		}

		private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true; this.Hide();
		}

		private void WebLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(WebLinkLabel.Text); // Open developer's website >:)))
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
