using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ImageProcessingResult
    {
        public Bitmap Image { get; internal set; }
        public LineSegment2D[] Lines { get; internal set; }
    }
}
