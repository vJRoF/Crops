﻿#nullable enable

using System;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApp1
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
            var image = _imageProcessor.GetResultImage();
            if (image == null)
                return;

            var drawSize = new RectangleF(0, 0, image.Width * Scale, image.Height * Scale);
            g.DrawImage(image, drawSize);

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
            var image = _imageProcessor.GetResultImage();
            if (image == null)
                return;

            var scaleX = (float) size.Width / image.Width;
            var scaleY = (float)size.Height / image.Height;

            Scale = scaleX > scaleY ? scaleY : scaleX;
        }
    }
}
