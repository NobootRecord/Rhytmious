namespace Rhytmious
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
			this.BPMTrackBar = new System.Windows.Forms.TrackBar();
			this.StartStopButton = new System.Windows.Forms.Button();
			this.ConfigButton = new System.Windows.Forms.Button();
			this.Metronome = new System.Windows.Forms.Timer(this.components);
			this.BPMNumeric = new System.Windows.Forms.NumericUpDown();
			this.AboutButton = new System.Windows.Forms.Button();
			this.BPMListButton = new System.Windows.Forms.Button();
			this.MetronomeGroup = new System.Windows.Forms.GroupBox();
			this.DownSoundCheck = new System.Windows.Forms.CheckBox();
			this.UpSoundCheck = new System.Windows.Forms.CheckBox();
			this.FlashWinCheck = new System.Windows.Forms.CheckBox();
			this.InterfaceGroup = new System.Windows.Forms.GroupBox();
			this.OpacityNumeric = new System.Windows.Forms.NumericUpDown();
			this.OpacityLabel = new System.Windows.Forms.Label();
			this.WinExpandTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.BPMTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BPMNumeric)).BeginInit();
			this.MetronomeGroup.SuspendLayout();
			this.InterfaceGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OpacityNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// BPMTrackBar
			// 
			this.BPMTrackBar.AutoSize = false;
			this.BPMTrackBar.Location = new System.Drawing.Point(96, 12);
			this.BPMTrackBar.Maximum = 218;
			this.BPMTrackBar.Minimum = 24;
			this.BPMTrackBar.Name = "BPMTrackBar";
			this.BPMTrackBar.Size = new System.Drawing.Size(366, 45);
			this.BPMTrackBar.TabIndex = 4;
			this.BPMTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.BPMTrackBar.Value = 24;
			this.BPMTrackBar.Scroll += new System.EventHandler(this.BPMTrackBar_Scroll);
			// 
			// StartStopButton
			// 
			this.StartStopButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartStopButton.Location = new System.Drawing.Point(12, 63);
			this.StartStopButton.Name = "StartStopButton";
			this.StartStopButton.Size = new System.Drawing.Size(78, 29);
			this.StartStopButton.TabIndex = 6;
			this.StartStopButton.Text = "Start/Stop";
			this.StartStopButton.UseVisualStyleBackColor = true;
			this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
			// 
			// ConfigButton
			// 
			this.ConfigButton.Location = new System.Drawing.Point(306, 63);
			this.ConfigButton.Name = "ConfigButton";
			this.ConfigButton.Size = new System.Drawing.Size(75, 29);
			this.ConfigButton.TabIndex = 7;
			this.ConfigButton.Text = "Configure...";
			this.ConfigButton.UseVisualStyleBackColor = true;
			this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
			// 
			// Metronome
			// 
			this.Metronome.Tick += new System.EventHandler(this.Metronome_Tick);
			// 
			// BPMNumeric
			// 
			this.BPMNumeric.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BPMNumeric.Location = new System.Drawing.Point(12, 12);
			this.BPMNumeric.Maximum = new decimal(new int[] {
            218,
            0,
            0,
            0});
			this.BPMNumeric.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.BPMNumeric.Name = "BPMNumeric";
			this.BPMNumeric.Size = new System.Drawing.Size(78, 43);
			this.BPMNumeric.TabIndex = 8;
			this.BPMNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.BPMNumeric.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.BPMNumeric.ValueChanged += new System.EventHandler(this.BPMNumeric_ValueChanged);
			// 
			// AboutButton
			// 
			this.AboutButton.Location = new System.Drawing.Point(387, 63);
			this.AboutButton.Name = "AboutButton";
			this.AboutButton.Size = new System.Drawing.Size(75, 29);
			this.AboutButton.TabIndex = 9;
			this.AboutButton.Text = "About...";
			this.AboutButton.UseVisualStyleBackColor = true;
			this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
			// 
			// BPMListButton
			// 
			this.BPMListButton.Location = new System.Drawing.Point(225, 63);
			this.BPMListButton.Name = "BPMListButton";
			this.BPMListButton.Size = new System.Drawing.Size(75, 29);
			this.BPMListButton.TabIndex = 10;
			this.BPMListButton.Text = "BPM List";
			this.BPMListButton.UseVisualStyleBackColor = true;
			this.BPMListButton.Click += new System.EventHandler(this.BPMListButton_Click);
			// 
			// MetronomeGroup
			// 
			this.MetronomeGroup.Controls.Add(this.DownSoundCheck);
			this.MetronomeGroup.Controls.Add(this.UpSoundCheck);
			this.MetronomeGroup.Controls.Add(this.FlashWinCheck);
			this.MetronomeGroup.Location = new System.Drawing.Point(12, 98);
			this.MetronomeGroup.Name = "MetronomeGroup";
			this.MetronomeGroup.Size = new System.Drawing.Size(200, 100);
			this.MetronomeGroup.TabIndex = 11;
			this.MetronomeGroup.TabStop = false;
			this.MetronomeGroup.Text = "Metronome";
			// 
			// DownSoundCheck
			// 
			this.DownSoundCheck.Checked = true;
			this.DownSoundCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DownSoundCheck.Location = new System.Drawing.Point(6, 66);
			this.DownSoundCheck.Name = "DownSoundCheck";
			this.DownSoundCheck.Size = new System.Drawing.Size(188, 17);
			this.DownSoundCheck.TabIndex = 2;
			this.DownSoundCheck.Text = "Play downbeat sound";
			this.DownSoundCheck.UseVisualStyleBackColor = true;
			// 
			// UpSoundCheck
			// 
			this.UpSoundCheck.Checked = true;
			this.UpSoundCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.UpSoundCheck.Location = new System.Drawing.Point(6, 43);
			this.UpSoundCheck.Name = "UpSoundCheck";
			this.UpSoundCheck.Size = new System.Drawing.Size(188, 17);
			this.UpSoundCheck.TabIndex = 1;
			this.UpSoundCheck.Text = "Play upbeat sound";
			this.UpSoundCheck.UseVisualStyleBackColor = true;
			// 
			// FlashWinCheck
			// 
			this.FlashWinCheck.Location = new System.Drawing.Point(6, 20);
			this.FlashWinCheck.Name = "FlashWinCheck";
			this.FlashWinCheck.Size = new System.Drawing.Size(188, 17);
			this.FlashWinCheck.TabIndex = 0;
			this.FlashWinCheck.Text = "Flash window";
			this.FlashWinCheck.UseVisualStyleBackColor = true;
			// 
			// InterfaceGroup
			// 
			this.InterfaceGroup.Controls.Add(this.OpacityNumeric);
			this.InterfaceGroup.Controls.Add(this.OpacityLabel);
			this.InterfaceGroup.Location = new System.Drawing.Point(218, 98);
			this.InterfaceGroup.Name = "InterfaceGroup";
			this.InterfaceGroup.Size = new System.Drawing.Size(244, 100);
			this.InterfaceGroup.TabIndex = 12;
			this.InterfaceGroup.TabStop = false;
			this.InterfaceGroup.Text = "Interface";
			// 
			// OpacityNumeric
			// 
			this.OpacityNumeric.Location = new System.Drawing.Point(118, 20);
			this.OpacityNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.OpacityNumeric.Name = "OpacityNumeric";
			this.OpacityNumeric.Size = new System.Drawing.Size(120, 21);
			this.OpacityNumeric.TabIndex = 1;
			this.OpacityNumeric.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.OpacityNumeric.ValueChanged += new System.EventHandler(this.OpacityNumeric_ValueChanged);
			// 
			// OpacityLabel
			// 
			this.OpacityLabel.Location = new System.Drawing.Point(6, 17);
			this.OpacityLabel.Name = "OpacityLabel";
			this.OpacityLabel.Size = new System.Drawing.Size(232, 23);
			this.OpacityLabel.TabIndex = 0;
			this.OpacityLabel.Text = "Opacity:";
			this.OpacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WinExpandTimer
			// 
			this.WinExpandTimer.Interval = 4;
			this.WinExpandTimer.Tick += new System.EventHandler(this.WinExpandTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(474, 99);
			this.Controls.Add(this.InterfaceGroup);
			this.Controls.Add(this.MetronomeGroup);
			this.Controls.Add(this.BPMListButton);
			this.Controls.Add(this.AboutButton);
			this.Controls.Add(this.BPMNumeric);
			this.Controls.Add(this.ConfigButton);
			this.Controls.Add(this.StartStopButton);
			this.Controls.Add(this.BPMTrackBar);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(480, 236);
			this.MinimumSize = new System.Drawing.Size(480, 128);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rhytmious";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.BPMTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BPMNumeric)).EndInit();
			this.MetronomeGroup.ResumeLayout(false);
			this.InterfaceGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.OpacityNumeric)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Button AboutButton;
		public System.Windows.Forms.Button BPMListButton;
		public System.Windows.Forms.TrackBar BPMTrackBar;
		public System.Windows.Forms.Button StartStopButton;
		public System.Windows.Forms.Button ConfigButton;
		public System.Windows.Forms.Timer Metronome;
		public System.Windows.Forms.NumericUpDown BPMNumeric;
		private System.Windows.Forms.GroupBox MetronomeGroup;
		private System.Windows.Forms.CheckBox DownSoundCheck;
		private System.Windows.Forms.CheckBox UpSoundCheck;
		private System.Windows.Forms.CheckBox FlashWinCheck;
		private System.Windows.Forms.GroupBox InterfaceGroup;
		private System.Windows.Forms.NumericUpDown OpacityNumeric;
		private System.Windows.Forms.Label OpacityLabel;
		private System.Windows.Forms.Timer WinExpandTimer;


	}
}