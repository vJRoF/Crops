using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WindowsFormsApp1
{
    //[Designer(typeof(ScrollableControlDesigner), typeof(IRootDesigner))]
    public partial class IntTextBox : UserControl
    {
        public int Value {
            get
            {
                return Convert.ToInt32(textBox1.Text);
            }
            set
            {
                textBox1.Text = Convert.ToString(value);
            }
        }
        public event EventHandler<int> ValueChanged;
        public IntTextBox()
        {
            InitializeComponent();
            textBox1.MouseWheel += TextBox1_MouseWheel;
        }

        private void TextBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            Value += e.Delta / SystemInformation.MouseWheelScrollDelta;
            ValueChanged?.Invoke(this, Value);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Height = this.textBox1.Height;

            base.OnPaint(e);
        }
    }

    class ScrollableTextBoxDesigner : ControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
        }
    }
}
