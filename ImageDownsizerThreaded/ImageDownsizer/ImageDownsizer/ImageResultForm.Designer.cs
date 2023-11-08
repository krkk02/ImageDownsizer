namespace ImageDownsizer
{
	partial class ImageResultForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageResultForm));
			imageResultBox = new PictureBox();
			((System.ComponentModel.ISupportInitialize)imageResultBox).BeginInit();
			SuspendLayout();
			// 
			// imageResultBox
			// 
			imageResultBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			imageResultBox.Location = new Point(3, 3);
			imageResultBox.Margin = new Padding(0);
			imageResultBox.Name = "imageResultBox";
			imageResultBox.Size = new Size(114, 38);
			imageResultBox.SizeMode = PictureBoxSizeMode.CenterImage;
			imageResultBox.TabIndex = 0;
			imageResultBox.TabStop = false;
			// 
			// ImageResultForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(120, 44);
			Controls.Add(imageResultBox);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "ImageResultForm";
			Padding = new Padding(3);
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Image Downsizer";
			WindowState = FormWindowState.Maximized;
			Load += ImageResultForm_Load;
			((System.ComponentModel.ISupportInitialize)imageResultBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		public PictureBox imageResultBox;
	}
}