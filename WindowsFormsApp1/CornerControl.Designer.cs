namespace WindowsFormsApp1
{
    partial class CornerControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(3, 3);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(58, 22);
            this.tbX.TabIndex = 0;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(67, 3);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(58, 22);
            this.tbY.TabIndex = 1;
            // 
            // CornerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Name = "CornerControl";
            this.Size = new System.Drawing.Size(128, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
    }
}
