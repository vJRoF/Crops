using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ResultForm : Form
    {
        public Image Image
        {
            get
            {
                return panAndZoomPictureBox1.Image;
            }
            set
            {
                panAndZoomPictureBox1.Image = value;
            }
        }

        public ResultForm()
        {
            InitializeComponent();
        }

        private void OnSave_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "Изображения tiff:|*.tiff";
            dlg.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dlg.FileName))
            {
                this.panAndZoomPictureBox1.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Tiff);
            }
        }
    }
}
