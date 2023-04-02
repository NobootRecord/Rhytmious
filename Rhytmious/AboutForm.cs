using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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

		private void OKButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AuthorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://nobootrecord.github.io");
		}

		private void SrcLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/NobootRecord/Rhytmious");
		}

		private void LicenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/NobootRecord/Rhytmious/blob/main/LICENSE");
		}
	}
}
