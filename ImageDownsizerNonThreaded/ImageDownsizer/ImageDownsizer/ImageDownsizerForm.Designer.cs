namespace ImageDownsizer
{
	partial class ImageDownsizerForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDownsizerForm));
			browseImageBtn = new Button();
			downsizeImageBtn = new Button();
			browseImageDialog = new OpenFileDialog();
			downsizeScaleValue = new NumericUpDown();
			downsizeScaleLabel = new Label();
			((System.ComponentModel.ISupportInitialize)downsizeScaleValue).BeginInit();
			SuspendLayout();
			// 
			// browseImageBtn
			// 
			browseImageBtn.Location = new Point(10, 10);
			browseImageBtn.Name = "browseImageBtn";
			browseImageBtn.Size = new Size(110, 23);
			browseImageBtn.TabIndex = 0;
			browseImageBtn.Text = "Browse";
			browseImageBtn.UseVisualStyleBackColor = true;
			browseImageBtn.Click += browseImageBtn_Click;
			// 
			// downsizeImageBtn
			// 
			downsizeImageBtn.Location = new Point(247, 10);
			downsizeImageBtn.Name = "downsizeImageBtn";
			downsizeImageBtn.Size = new Size(110, 23);
			downsizeImageBtn.TabIndex = 2;
			downsizeImageBtn.Text = "Downsize";
			downsizeImageBtn.UseVisualStyleBackColor = true;
			downsizeImageBtn.Click += downsizeImageBtn_Click;
			// 
			// browseImageDialog
			// 
			browseImageDialog.FileName = "browseImageDialog";
			// 
			// downsizeScaleValue
			// 
			downsizeScaleValue.Location = new Point(196, 10);
			downsizeScaleValue.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
			downsizeScaleValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			downsizeScaleValue.Name = "downsizeScaleValue";
			downsizeScaleValue.Size = new Size(45, 23);
			downsizeScaleValue.TabIndex = 1;
			downsizeScaleValue.TextAlign = HorizontalAlignment.Right;
			downsizeScaleValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
			downsizeScaleValue.KeyDown += downsizeScaleValue_KeyDown;
			// 
			// downsizeScaleLabel
			// 
			downsizeScaleLabel.AutoSize = true;
			downsizeScaleLabel.Location = new Point(132, 13);
			downsizeScaleLabel.Name = "downsizeScaleLabel";
			downsizeScaleLabel.Size = new Size(58, 15);
			downsizeScaleLabel.TabIndex = 3;
			downsizeScaleLabel.Text = "Scale (%):";
			// 
			// ImageDownsizerForm
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(366, 44);
			Controls.Add(downsizeScaleLabel);
			Controls.Add(downsizeScaleValue);
			Controls.Add(downsizeImageBtn);
			Controls.Add(browseImageBtn);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "ImageDownsizerForm";
			Text = "Image Downsizer";
			TopMost = true;
			Load += ImageDownsizerForm_Load;
			((System.ComponentModel.ISupportInitialize)downsizeScaleValue).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button browseImageBtn;
		private Button downsizeImageBtn;
		private OpenFileDialog browseImageDialog;
		private NumericUpDown downsizeScaleValue;
		private Label downsizeScaleLabel;
	}
}