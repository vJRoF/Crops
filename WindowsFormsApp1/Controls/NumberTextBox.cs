using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApp1.Tools;

namespace WindowsFormsApp1.Controls
{
    public partial class NumberTextBox<TValue> : UserControl
    {
        [Description("Test text displayed in the textbox"), Category("Data")]
        public TValue Value
        {
            get
            {
                try
                {
                    return (TValue)Convert.ChangeType(tbValue.Text, typeof(TValue));
                }
                catch { return default; }
            }
            set
            {
                tbValue.Text = (string)Convert.ChangeType(value, typeof(string));
            }
        }

        public event EventHandler<TValue> ValueChanged;

        [Description("Test text displayed in the textbox"), Category("Data")]
        public string ValueName { 
            get { return lbName.Text; } 
            set { lbName.Text = value; } 
        }

        public NumberTextBox()
        {
            InitializeComponent();

            tbValue.MouseWheel += TbValue_MouseWheel;
        }

        private void TbValue_MouseWheel(object sender, MouseEventArgs e)
        {
            var delta = (TValue)Convert.ChangeType(e.Delta / SystemInformation.MouseWheelScrollDelta, typeof(TValue));
            var calc = Calculators.GetInstance<TValue>();
            Value = calc.Add(Value, delta);

            ValueChanged?.Invoke(this, Value);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Size = new Size(this.tbValue.Width + this.lbName.Width + 5, Math.Max(this.tbValue.Height, this.lbName.Height));
            base.OnPaint(e);
        }
    }
}
