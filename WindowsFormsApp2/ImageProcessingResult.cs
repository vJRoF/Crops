using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ImageProcessingResult
    {
        public Bitmap Image { get; internal set; }
        public LineSegment2D[] Lines { get; internal set; }

        public ImageProcessingResult(Bitmap image, LineSegment2D[] lines)
        {
            Image = image;
            Lines = lines;
        }
    }
}
