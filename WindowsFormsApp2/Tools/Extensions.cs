using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.IO;

namespace WindowsFormsApp2.Tools
{
    static class Extensions
    {
        internal static Bitmap ConvertToBitmap(this Image<Gray, Byte> image)
        {
            var vector = new VectorOfByte();
            CvInvoke.Imencode(".png", image, vector);
            using var ms = new MemoryStream(vector.ToArray());
            return new Bitmap(ms);
        }

        internal static Bitmap ConvertToBitmap(this Image<Hsv, Byte> image)
        {
            var vector = new VectorOfByte();
            CvInvoke.Imencode(".png", image, vector);
            using var ms = new MemoryStream(vector.ToArray());
            return new Bitmap(ms);
        }
    }
}
