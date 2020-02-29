using Emgu.CV;
using Emgu.CV.Structure;
using JetBrains.Annotations;
using System;
using System.Diagnostics;
using System.Drawing;

namespace WindowsFormsApp1
{
    class ImageProcessor : IDisposable
    {
        private Image<Bgr, Byte> _src;
        private Image<Gray, Byte> _dst;

        public bool Gaussian { get; internal set; } = true;
        public int GaussianKernelSize { get; internal set; } = 5;


        public bool Canny { get; internal set; } = true;

        public void Open(string path)
        {
            _src = new Image<Bgr, byte>(path);
        }

        [CanBeNull]
        public Bitmap GetResultImage()
        {
            try
            {
                if (_src == null)
                    return null;

                var dstTemp = new Image<Gray, Byte>(_src.Size);

                dstTemp = _src.Convert<Gray, byte>();

                if (Gaussian)
                    dstTemp = dstTemp.SmoothGaussian(GaussianKernelSize, GaussianKernelSize, 0, 0);

                if (Canny)
                    CvInvoke.Canny(dstTemp, dstTemp, 50, 150);

                _dst = dstTemp;
                return _dst.ToBitmap();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return _dst?.ToBitmap();
        }
        
        public void Dispose()
        {
            if (_src != null)
            {
                _src.Dispose();
                _src = null;
            }

            if (_dst != null)
            {
                _dst.Dispose();
                _dst = null;
            }
        }
    }
}
