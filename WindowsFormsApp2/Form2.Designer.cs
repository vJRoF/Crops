namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cbGaussian = new System.Windows.Forms.CheckBox();
            this.cbCanny = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(518, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Чё вышло";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 497);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(525, 47);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(394, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbGaussian
            // 
            this.cbGaussian.AutoSize = true;
            this.cbGaussian.Location = new System.Drawing.Point(525, 90);
            this.cbGaussian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGaussian.Name = "cbGaussian";
            this.cbGaussian.Size = new System.Drawing.Size(74, 19);
            this.cbGaussian.TabIndex = 3;
            this.cbGaussian.Text = "Gaussian";
            this.cbGaussian.UseVisualStyleBackColor = true;
            this.cbGaussian.CheckedChanged += new System.EventHandler(this.cbGaussian_CheckedChanged);
            // 
            // cbCanny
            // 
            this.cbCanny.AutoSize = true;
            this.cbCanny.Location = new System.Drawing.Point(525, 135);
            this.cbCanny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCanny.Name = "cbCanny";
            this.cbCanny.Size = new System.Drawing.Size(59, 19);
            this.cbCanny.TabIndex = 5;
            this.cbCanny.Text = "Canny";
            this.cbCanny.UseVisualStyleBackColor = true;
            this.cbCanny.CheckedChanged += new System.EventHandler(this.cbCanny_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.cbCanny);
            this.Controls.Add(this.cbGaussian);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox cbGaussian;
        private System.Windows.Forms.CheckBox cbCanny;
        private Controls.IntTextBox ntbGaussianKernelSize;
        private Controls.DoubleTextBox dtbCannyThreshold1;
        private Controls.DoubleTextBox dtbCannyThreshold2;
    }
}