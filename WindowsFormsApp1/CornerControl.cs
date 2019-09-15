using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CornerControl : UserControl
    {
        private List<PointF> _corners;
        private int _index;

        public delegate void NeedInvalidateDelegate();

        public event NeedInvalidateDelegate NeedInvalidate;

        public CornerControl(List<PointF> corners, int index)
        {
            InitializeComponent();

            _corners = corners;
            _index = index;

            tbX.MouseWheel += TbX_MouseWheel;
            tbY.MouseWheel += TbY_MouseWheel;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            tbX.Text = _corners[_index].X.ToString();
            tbY.Text = _corners[_index].Y.ToString();

            base.OnPaint(e);
        }

        private void TbY_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 120;
            _corners[_index] = new PointF(_corners[_index].X, _corners[_index].Y + delta);
            NeedInvalidate();
        }

        private void TbX_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 120;
            _corners[_index] = new PointF(_corners[_index].X + delta, _corners[_index].Y);
            NeedInvalidate();
        }
    }
}
