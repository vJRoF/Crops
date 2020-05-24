using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        ImageProcessor _imageProcessor;
        ImageProcessorRender _imageProcessorRender;

        public Form2()
        {
            InitializeComponent();

            
            //tbGaussKernel

            _imageProcessor = new ImageProcessor();
            _imageProcessorRender = new ImageProcessorRender(_imageProcessor);

            cbGaussian.Checked = _imageProcessor.Gaussian;

            ntbGaussianKernelSize.Value = _imageProcessor.GaussianKernelSize;
            ntbGaussianKernelSize.ValueChanged += TbGaussKernel_ValueChanged;

            cbCanny.Checked = _imageProcessor.Canny;

            dtbCannyThreshold1.Value = _imageProcessor.Threshold1;
            dtbCannyThreshold1.ValueChanged += DtbCannyThreshold1_ValueChanged;

            dtbCannyThreshold2.Value = _imageProcessor.Threshold2;
            dtbCannyThreshold2.ValueChanged += DtbCannyThreshold2_ValueChanged;
        }

        private void DtbCannyThreshold2_ValueChanged(object? sender, double e)
        {
            _imageProcessor.Threshold2 = e;
            InvalidateRenderContainer();
        }

        private void DtbCannyThreshold1_ValueChanged(object? sender, double e)
        {
            _imageProcessor.Threshold1 = e;
            InvalidateRenderContainer();
        }

        private void TbGaussKernel_ValueChanged(object? sender, int e)
        {
            _imageProcessor.GaussianKernelSize = e;
            InvalidateRenderContainer();
        }

        private Control GetRenderContainer()
        {
            return panel1;
        }

        private void InvalidateRenderContainer()
        {
            var container = GetRenderContainer();
            container.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _imageProcessor.Open(@"C:\Users\MisterVovan\Documents\cards\raw\Scan_20170820 (36).tiff");
            //_imageProcessor.Open(@"C:\Users\vladi\Pictures\Saved Pictures\om2j_txb1e2yqhvmjeoi-cydtgo.png");
            _imageProcessorRender.Fit(GetRenderContainer().Size);
            InvalidateRenderContainer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            _imageProcessorRender.Draw(e.Graphics);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar trackbar)
            {
                _imageProcessorRender.Scale = (float) trackbar.Value / 30 ;

                 InvalidateRenderContainer();
            }
        }

        private void cbGaussian_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cbGaussian)
            {
                _imageProcessor.Gaussian = cbGaussian.Checked;

                InvalidateRenderContainer();
            }
        }

        private void cbCanny_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cbCanny)
            {
                _imageProcessor.Canny = cbCanny.Checked;

                InvalidateRenderContainer();
            }
        }
    }
}
