using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageDownsizer
{
	public partial class ImageDownsizerForm : Form
	{

		private Bitmap originalImage;
		private Bitmap currentImage;
		private ImageResultForm imageResultForm;
		private Stopwatch sw = new Stopwatch();

		public ImageDownsizerForm()
		{
			InitializeComponent();
		}

		public void FileDialog()
		{
			OpenFileDialog browseImageDialog = new OpenFileDialog();
			browseImageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tiff";
			if (browseImageDialog.ShowDialog() == DialogResult.OK)
			{
				if (imageResultForm == null || imageResultForm.IsDisposed)
				{
					imageResultForm = new ImageResultForm();
					imageResultForm.Show();
				}

				originalImage = new Bitmap(browseImageDialog.FileName);
				currentImage = new Bitmap(originalImage);
				imageResultForm.imageResultBox.Image = currentImage;
			}
		}

		public void DownsizeImage()
		{
			int scale = Convert.ToInt32(downsizeScaleValue.Value);

			sw.Start();
			if (currentImage != null && scale >= 1 && scale < 100)
			{
				int newWidth = (int)(originalImage.Width * (100 - scale) / 100.0);
				int newHeight = (int)(originalImage.Height * (100 - scale) / 100.0);

				if (newWidth > 0 && newHeight > 0)
				{
					currentImage = new Bitmap(originalImage, newWidth, newHeight);
					imageResultForm.imageResultBox.Image = currentImage;
				}
			}
			sw.Stop();
			if (sw.Elapsed.TotalSeconds < 1.0)
			{
				MessageBox.Show($"Image successfully downscaled!", "Image Downsizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sw.Stop();
			}
			else
			{
				MessageBox.Show($"Image successfully downscaled!\nElapsed time: {sw.Elapsed.TotalSeconds:F2} seconds.", "Image Downsizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			sw.Reset();
		}

		private void ImageDownsizerForm_Load(object sender, EventArgs e)
		{

		}

		private void browseImageBtn_Click(object sender, EventArgs e)
		{
			FileDialog();
		}

		private void downsizeImageBtn_Click(object sender, EventArgs e)
		{
			DownsizeImage();
		}

		private void downsizeScaleValue_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				DownsizeImage();
				e.SuppressKeyPress = true;
			}
		}
	}
}