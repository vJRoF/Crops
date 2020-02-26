﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        ImageProcessor _imageProcessor;

        public Form2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if( _imageProcessor!= null )
                e.Graphics.DrawImage(_imageProcessor.GetResultImage(), 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _imageProcessor = new ImageProcessor();
            _imageProcessor.Open(@"C:\Users\vladi\Pictures\Saved Pictures\om2j_txb1e2yqhvmjeoi-cydtgo.png");

            groupBox1.Invalidate();
        }
    }
}
