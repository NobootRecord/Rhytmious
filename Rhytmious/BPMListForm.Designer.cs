namespace Rhytmious
{
	partial class BPMListForm
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
			this.BPMListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// BPMListBox
			// 
			this.BPMListBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BPMListBox.FormattingEnabled = true;
			this.BPMListBox.ItemHeight = 23;
			this.BPMListBox.Items.AddRange(new object[] {
            "Grave\t\t< 40",
            "Lento\t\t40 - 55",
            "Largo\t\t45 - 65",
            "Adagio\t\t55 - 75",
            "Andante\t\t75 - 105",
            "Moderato\t105 - 120",
            "Allegro\t\t120 - 160",
            "Vivace\t\t150 - 170",
            "Presto\t\t170 - 210",
            "Prestissimo\t> 210"});
			this.BPMListBox.Location = new System.Drawing.Point(12, 12);
			this.BPMListBox.Name = "BPMListBox";
			this.BPMListBox.Size = new System.Drawing.Size(260, 234);
			this.BPMListBox.TabIndex = 0;
			// 
			// BPMListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.BPMListBox);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BPMListForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BPM List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BPMListForm_FormClosing);
			this.Load += new System.EventHandler(this.BPMListForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox BPMListBox;

	}
}