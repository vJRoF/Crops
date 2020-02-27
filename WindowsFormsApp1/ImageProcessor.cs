using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    class ImageProcessor : IDisposable
    {
        private Image<Bgr, Byte> _src;
        private Image<Gray, Byte> _dst;

        public bool Gaussian { get; internal set; }

        public void Open(string path)
        {
            _src = new Image<Bgr, byte>(path);
        }

        public Bitmap GetResultImage()
        {
            if (_src == null)
                return null;

            _dst = _src.Convert<Gray, byte>();

            if (Gaussian)
                _dst = _dst.SmoothGaussian(5, 5, 0, 0);

            CvInvoke.Canny(_dst, _dst, 50, 150);

            return _dst.ToBitmap();
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
