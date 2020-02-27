using System;
using System.Drawing;

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
