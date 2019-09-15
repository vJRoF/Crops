using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panAndZoomPictureBox1.Image = Image.FromFile("hqdefault.jpg");
        }

        private void Transform()
        {
            if (_corners.Count != 4)
                return;

            using (Image<Bgr, Byte> src = new Image<Bgr, byte>(new Bitmap(panAndZoomPictureBox1.Image)))
            using (Image<Bgr, Byte> dst = new Image<Bgr, byte>(GetSizeFromCorners()))
            {
                var transformationMatrix = CvInvoke.GetPerspectiveTransform(
                    new PointF[] { _corners[0], _corners[1], _corners[2], _corners[3] },
                    new PointF[] { new PointF(0, 0), new PointF(dst.Width, 0), new PointF(dst.Width, dst.Height), new PointF(0, dst.Height) });
                CvInvoke.WarpPerspective(src, dst, transformationMatrix, dst.Size);

                ibDst.Image = dst;
            }
        }

        private List<PointF> _corners = new List<PointF>();

        private Size GetSizeFromCorners()
        {
            var topLength = GetLength(_corners[1], _corners[0]);
            var rightLengt = GetLength(_corners[2], _corners[1]);
            var bottomLengt = GetLength(_corners[3], _corners[2]);
            var leftLengt = GetLength(_corners[0], _corners[3]);
            return new Size(Convert.ToInt32((topLength + bottomLengt) / 2), Convert.ToInt32((rightLengt + leftLengt) / 2));
        }

        private float GetLength(PointF point1, PointF point2)
        {
            return Convert.ToSingle(
                Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2)));
        }

        private static float _radius = 5.0f;
        private static Pen _scaffoldsPen = new Pen(Color.FromArgb(128, Color.Red), 1);
        private void DrawScaffolding(System.Drawing.Graphics g)
        {
            foreach (var corner in _corners)
            {
                g.DrawEllipse(_scaffoldsPen, corner.X - _radius / 2, corner.Y - _radius / 2, _radius, _radius);
            }

            for (int i = 1; i < _corners.Count + 1; i++)
                g.DrawLine(_scaffoldsPen, _corners[(i - 1) % _corners.Count], _corners[i % _corners.Count]);
        }

        private void PanAndZoomPictureBox1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = (MouseEventArgs)e;
            //_corners.Add(new PointF(mouseEventArgs.X, mouseEventArgs.Y));
            _corners.Add(GetRealPoint(mouseEventArgs.X, mouseEventArgs.Y));
            panAndZoomPictureBox1.Invalidate();
        }

        private RectangleF _clipBounds;

        private void PanAndZoomPictureBox1_Paint(object sender, PaintEventArgs e)
        {
            _clipBounds = e.Graphics.ClipBounds;
            DrawScaffolding(e.Graphics);
            PrintCoordinates();
            Transform();
        }

        private void PrintCoordinates()
        {
            for (int i = 0; i < 4; i++)
                if(_corners.Count > i )
                {
                    this.Controls[$"tbX{i}"].Text = Convert.ToString(_corners[i].X);
                    this.Controls[$"tbY{i}"].Text = Convert.ToString(_corners[i].Y);
                }
        }

        private PointF GetRealPoint(int x, int y)
        {
            var realX = x / panAndZoomPictureBox1.ZoomScale + _clipBounds.X;
            var realY = y / panAndZoomPictureBox1.ZoomScale + _clipBounds.Y;

            return new PointF((float)realX, (float)realY);
        }

        private void TbX_TextChanged(object sender, EventArgs e)
        {
            var control = sender as Control;
            if (string.IsNullOrWhiteSpace(control?.Text))
                return;

            var index = int.Parse(Regex.Match(control?.Name, @"\d+").Value);
            var value = float.Parse(Regex.Match(control?.Text, @"\d+").Value);
            _corners[index] = new PointF(value, _corners[index].Y);
            panAndZoomPictureBox1.Invalidate();
        }

        private void TbY_TextChanged(object sender, EventArgs e)
        {
            var control = sender as Control;
            if (string.IsNullOrWhiteSpace(control?.Text))
                return;

            var index = int.Parse(Regex.Match(control?.Name, @"\d+").Value);
            var value = float.Parse(Regex.Match(control?.Text, @"\d+").Value);
            _corners[index] = new PointF(_corners[index].X, value);
            panAndZoomPictureBox1.Invalidate();
        }
    }
}
