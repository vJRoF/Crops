﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Diagnostics;
using System.Drawing;
using WindowsFormsApp2.Tools;

namespace WindowsFormsApp2
{
    class ImageProcessor : IDisposable
    {
        private Image<Bgr, Byte>? _src;
        private Image<Gray, Byte>? _dst;
        private LineSegment2D[]? _lines;

        public bool Gaussian { get; internal set; } = true;
        public int GaussianKernelSize { get; internal set; } = 5;


        public bool Canny { get; internal set; } = true;
        public double Threshold1 { get; internal set; } = 50;
        public double Threshold2 { get; internal set; } = 150;

        public bool HoughLines { get; internal set; } = true;


        public double MaskLowerHue { get; internal set; } = 30;
        public double MaskLowerSaturation { get; internal set; } = 5;
        public double MaskLowerValue { get; set; } = 200;

        public double MaskUpperHue { get; internal set; } = 40;
        public double MaskUpperSaturation { get; internal set; } = 10;
        public double MaskUpperValue { get; set; } = 220;

        public void Open(string path)
        {
            _src = new Image<Bgr, byte>(path);
        }

        public ImageProcessingResult? GetResultImage()
        {
            if (_src == null)
                    return null;

            _dst = _src
                .ToHsv()
                .Mask(
                    true,
                    new Hsv(MaskLowerHue, MaskLowerSaturation, MaskLowerValue),
                    new Hsv(MaskUpperHue, MaskUpperSaturation, MaskUpperValue));

            try
            {
                var dstTemp = new Image<Gray, Byte>(_src.Size);


                //dstTemp = _src.Convert<Gray, byte>();

                if (Gaussian)
                    dstTemp = dstTemp.SmoothGaussian(GaussianKernelSize, GaussianKernelSize, 0, 0);

                if (Canny)
                    CvInvoke.Canny(dstTemp, dstTemp, Threshold1, Threshold2);

                //CvInvoke.HoughLines(dstTemp, dstTemp, 1, Math.PI / 180, 150, 0, 0);
                _lines = CvInvoke.HoughLinesP(
                                       dstTemp,
                                       1, //Distance resolution in pixel-related units
                                       Math.PI / 45.0, //Angle resolution measured in radians.
                                       20, //threshold
                                       30, //min Line width
                                       10); //gap between lines

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return new ImageProcessingResult(_dst.ConvertToBitmap(), new LineSegment2D[0]);
            return new ImageProcessingResult(_dst.ConvertToBitmap(), _lines ?? Array.Empty<LineSegment2D>());
        }

        public LineSegment2D[] GetLines()
        {
            return _lines;
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
