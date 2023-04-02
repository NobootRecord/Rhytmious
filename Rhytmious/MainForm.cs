using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.IO;

namespace Rhytmious
{
	public partial class MainForm : Form
	{
		[DllImport("user32.dll")]
		public static extern bool FlashWindow(IntPtr hWnd, bool bInvert);

		public MainForm()
		{
			InitializeComponent();
		}

		// Save program configuration

		private void SaveConfig()
		{
			StreamWriter sw = File.CreateText("Rhytmious.ini");
			
			sw.WriteLine("[Metronome]");
			sw.WriteLine();

			sw.Write("FlashWindow=");
			if (FlashWinCheck.Checked) sw.WriteLine("1"); else sw.WriteLine("0");
			sw.Write("PlayDownbeat=");
			if (DownSoundCheck.Checked) sw.WriteLine("1"); else sw.WriteLine("0");
			sw.Write("PlayUpbeat=");
			if (UpSoundCheck.Checked) sw.WriteLine("1"); else sw.WriteLine("0");

			sw.WriteLine();
			sw.WriteLine("[Interface]");
			sw.WriteLine();

			sw.Write("Opacity=");
			sw.Write(Convert.ToInt32(this.Opacity * 255));
			
			sw.Close();
		}

		// Load program configuration

		private void LoadConfig()
		{
			if (!File.Exists("Rhytmious.ini")) return;
			StreamReader sr = File.OpenText("Rhytmious.ini");
			string fl = "";

			while (!sr.EndOfStream)
			{
				fl = sr.ReadLine();

				if (fl.StartsWith("FlashWindow=")) FlashWinCheck.Checked = fl.EndsWith("1");
				if (fl.StartsWith("PlayDownbeat=")) DownSoundCheck.Checked = fl.EndsWith("1");
				if (fl.StartsWith("PlayUpbeat=")) UpSoundCheck.Checked = fl.EndsWith("1");

				if (fl.StartsWith("Opacity=")) OpacityNumeric.Value = Convert.ToDecimal(fl.Substring("Opacity=".Length));
			};

			sr.Close(); fl = "";
		}

		// Other forms

		AboutForm aboutf = null;
		BPMListForm bpmf = null;

		// BPM -> Milliseconds (as timer interval)

		int BPMToMS(decimal BPM) { return Convert.ToInt32(1000 / (float)(BPM / 60)); }
		
		// Change BPM (beats per minute) value on numeric or trackbar

		private void BPMTrackBar_Scroll(object sender, EventArgs e)
		{
			BPMNumeric.Value = BPMTrackBar.Value;
		}

		private void BPMNumeric_ValueChanged(object sender, EventArgs e)
		{
			BPMTrackBar.Value = Convert.ToInt32(BPMNumeric.Value);
		}

		// Metronome loop

		SoundPlayer TickPlayer = new SoundPlayer(Rhytmious.Properties.Resources.Tick);
		SoundPlayer TickDPlayer = new SoundPlayer(Rhytmious.Properties.Resources.TickD);
		int beatNum = 0;

		private void Metronome_Tick(object sender, EventArgs e)
		{

			// Change ticking interval
			Metronome.Interval = BPMToMS(BPMNumeric.Value);

			// Play tick sound

			if (beatNum == 4) beatNum = 1; else beatNum++;
			if (beatNum == 1)
			{
				if (DownSoundCheck.Checked) {
					TickDPlayer.Play();
				} else {
					if (UpSoundCheck.Checked) TickPlayer.Play();
				};
			} else {
				if (UpSoundCheck.Checked) TickPlayer.Play();
			};

			// Flash window

			if (FlashWinCheck.Checked) FlashWindow(this.Handle, true);

		}

		// Start/stop metronome

		private void StartStopButton_Click(object sender, EventArgs e) { Metronome.Enabled = !Metronome.Enabled; }

		// Expand/shrink window

		int winESCoeff = -4;
		private void ConfigButton_Click(object sender, EventArgs e) { winESCoeff = -winESCoeff; WinExpandTimer.Enabled = true; }

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Icon = Rhytmious.Properties.Resources.Icon;

			aboutf = new AboutForm(this);
			bpmf = new BPMListForm(this);

			LoadConfig();
		}

		private void BPMListButton_Click(object sender, EventArgs e)
		{
			bpmf.Show();
		}

		private void AboutButton_Click(object sender, EventArgs e)
		{
			aboutf.Show();
		}

		private void WinExpandTimer_Tick(object sender, EventArgs e)
		{
			this.Height = this.Height + winESCoeff;
			if (this.Height == this.MinimumSize.Height || this.Height == this.MaximumSize.Height) WinExpandTimer.Enabled = false;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveConfig();
			Application.ExitThread();
		}

		private void OpacityNumeric_ValueChanged(object sender, EventArgs e)
		{
			this.Opacity = Convert.ToDouble(OpacityNumeric.Value) / 255;
		}
	}
}
