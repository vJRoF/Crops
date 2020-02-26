using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    class ImageProcessor : IDisposable
    {
        private Image<Bgr, Byte> _src;

        public void Open(string path)
        {
            _src = new Image<Bgr, byte>(path);
        }

        public Bitmap GetResultImage()
        {
            return _src.ToBitmap();
        }
        
        public void Dispose()
        {
            if (_src!= null)
            {
                _src.Dispose();
                _src = null;
            }
        }
    }
}
