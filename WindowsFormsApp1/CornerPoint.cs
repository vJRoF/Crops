using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class CornerPoint : Control
    {
        private readonly Pen _pen;
        private readonly PointF _center;
        public CornerPoint(Pen pen, PointF center, float radius)
        {
            _center = center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawEllipse()
        }
    }
}
