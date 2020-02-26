using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ImageProcessor : IDisposable
    {
        private Image<Bgr, Byte> _src;

        public void Open(string path)
        {
            Image<Bgr, Byte> src = new Image<Bgr, byte>(path);
        }
        
        public void Dispose()
        {
            if (_src!= null)
            {
                _src.Dispose();
            }
        }
    }
}
