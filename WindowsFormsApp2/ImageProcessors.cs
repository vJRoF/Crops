using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2
{
    public static class ImageProcessors
    {
        public static Image<Hsv, Byte> ToHsv(
            this Image<Bgr, byte> source)
        {
            var hsv = new Image<Hsv, Byte>(source.Size);
            CvInvoke.CvtColor(source, hsv, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            return hsv;
        }

        public static Image<Gray, Byte> Mask(
            this Image<Hsv, Byte> source,
            bool enable,
            Hsv lower,
            Hsv upper)
        {
            if (enable)
                return source.InRange(lower, upper);
            else
                throw new NotImplementedException();
        }
    }
}
