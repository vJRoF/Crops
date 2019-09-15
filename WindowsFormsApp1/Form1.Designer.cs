namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.tbX0 = new System.Windows.Forms.TextBox();
            this.tbY0 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY3 = new System.Windows.Forms.TextBox();
            this.tbX3 = new System.Windows.Forms.TextBox();
            this.ibDst = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibDst)).BeginInit();
            this.SuspendLayout();
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(475, 450);
            this.panAndZoomPictureBox1.TabIndex = 0;
            this.panAndZoomPictureBox1.TabStop = false;
            this.panAndZoomPictureBox1.Click += new System.EventHandler(this.PanAndZoomPictureBox1_Click);
            this.panAndZoomPictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PanAndZoomPictureBox1_Paint);
            // 
            // tbX0
            // 
            this.tbX0.Location = new System.Drawing.Point(481, 12);
            this.tbX0.Name = "tbX0";
            this.tbX0.Size = new System.Drawing.Size(34, 22);
            this.tbX0.TabIndex = 1;
            this.tbX0.TextChanged += new System.EventHandler(this.TbX_TextChanged);
            // 
            // tbY0
            // 
            this.tbY0.Location = new System.Drawing.Point(521, 12);
            this.tbY0.Name = "tbY0";
            this.tbY0.Size = new System.Drawing.Size(34, 22);
            this.tbY0.TabIndex = 2;
            this.tbY0.TextChanged += new System.EventHandler(this.TbY_TextChanged);
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(521, 40);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(34, 22);
            this.tbY1.TabIndex = 4;
            this.tbY1.TextChanged += new System.EventHandler(this.TbY_TextChanged);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(481, 40);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(34, 22);
            this.tbX1.TabIndex = 3;
            this.tbX1.TextChanged += new System.EventHandler(this.TbX_TextChanged);
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(521, 68);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(34, 22);
            this.tbY2.TabIndex = 6;
            this.tbY2.TextChanged += new System.EventHandler(this.TbY_TextChanged);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(481, 68);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(34, 22);
            this.tbX2.TabIndex = 5;
            this.tbX2.TextChanged += new System.EventHandler(this.TbX_TextChanged);
            // 
            // tbY3
            // 
            this.tbY3.Location = new System.Drawing.Point(521, 96);
            this.tbY3.Name = "tbY3";
            this.tbY3.Size = new System.Drawing.Size(34, 22);
            this.tbY3.TabIndex = 8;
            this.tbY3.TextChanged += new System.EventHandler(this.TbY_TextChanged);
            // 
            // tbX3
            // 
            this.tbX3.Location = new System.Drawing.Point(481, 96);
            this.tbX3.Name = "tbX3";
            this.tbX3.Size = new System.Drawing.Size(34, 22);
            this.tbX3.TabIndex = 7;
            this.tbX3.TextChanged += new System.EventHandler(this.TbX_TextChanged);
            // 
            // ibDst
            // 
            this.ibDst.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibDst.Location = new System.Drawing.Point(561, 0);
            this.ibDst.Name = "ibDst";
            this.ibDst.Size = new System.Drawing.Size(239, 450);
            this.ibDst.TabIndex = 2;
            this.ibDst.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ibDst);
            this.Controls.Add(this.tbY3);
            this.Controls.Add(this.tbX3);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.tbY0);
            this.Controls.Add(this.tbX0);
            this.Controls.Add(this.panAndZoomPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibDst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private System.Windows.Forms.TextBox tbX0;
        private System.Windows.Forms.TextBox tbY0;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY3;
        private System.Windows.Forms.TextBox tbX3;
        private Emgu.CV.UI.ImageBox ibDst;
    }
}

