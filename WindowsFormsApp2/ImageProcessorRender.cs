#nullable enable

using System;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApp2
{
    class ImageProcessorRender
    {
        private readonly ImageProcessor _imageProcessor;

        public float Scale { get; set; } = 1;

        public ImageProcessorRender(ImageProcessor imageProcessor)
        {
            _imageProcessor = imageProcessor ?? throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            var result = _imageProcessor.GetResultImage();
            if (result == null)
                return;

            var drawSize = new RectangleF(0, 0, result.Image.Width * Scale, result.Image.Height * Scale);
            g.DrawImage(result.Image, drawSize);

            DrawLines(g);
        }

        private void DrawLines(Graphics g)
        {
            foreach(var line in _imageProcessor.GetLines()
                                               .OrderByDescending(l => l.Length)
                                               .Take(_imageProcessor.GetLines().Length / 10))
            {
                g.DrawLine(Pens.Green, ToDisplay(line.P1), ToDisplay(line.P2));
            }
        }

        private Point ToDisplay(Point p)
        {
            return new Point(Convert.ToInt32(p.X * Scale), Convert.ToInt32(p.Y * Scale));
        }

        internal void Fit(Size size)
        {
            var result = _imageProcessor.GetResultImage();

            var scaleX = (float) size.Width / result.Image.Width;
            var scaleY = (float)size.Height / result.Image.Height;

            Scale = Math.Min(scaleX, scaleY);
        }
    }
}
