namespace UsingForm
{
    partial class MainControl
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
            this.variable1 = new System.Windows.Forms.TextBox();
            this.variable2 = new System.Windows.Forms.TextBox();
            this.textVariable1 = new System.Windows.Forms.Label();
            this.textVariable2 = new System.Windows.Forms.Label();
            this.textAreal = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.changeFigure = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // variable1
            // 
            this.variable1.Location = new System.Drawing.Point(16, 178);
            this.variable1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.variable1.Name = "variable1";
            this.variable1.Size = new System.Drawing.Size(64, 22);
            this.variable1.TabIndex = 0;
            this.variable1.TextChanged += new System.EventHandler(this.variable1_TextChanged);
            // 
            // variable2
            // 
            this.variable2.Location = new System.Drawing.Point(16, 210);
            this.variable2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.variable2.Name = "variable2";
            this.variable2.Size = new System.Drawing.Size(64, 22);
            this.variable2.TabIndex = 1;
            // 
            // textVariable1
            // 
            this.textVariable1.Location = new System.Drawing.Point(89, 182);
            this.textVariable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textVariable1.Name = "textVariable1";
            this.textVariable1.Size = new System.Drawing.Size(19, 16);
            this.textVariable1.TabIndex = 2;
            this.textVariable1.Text = "1";
            this.textVariable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textVariable2
            // 
            this.textVariable2.Location = new System.Drawing.Point(89, 219);
            this.textVariable2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textVariable2.Name = "textVariable2";
            this.textVariable2.Size = new System.Drawing.Size(19, 16);
            this.textVariable2.TabIndex = 3;
            this.textVariable2.Text = "2";
            this.textVariable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAreal
            // 
            this.textAreal.Location = new System.Drawing.Point(47, 58);
            this.textAreal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textAreal.Name = "textAreal";
            this.textAreal.Size = new System.Drawing.Size(295, 54);
            this.textAreal.TabIndex = 4;
            this.textAreal.Text = "Информация тут ";
            this.textAreal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(155, 126);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(229, 176);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // changeFigure
            // 
            this.changeFigure.FormattingEnabled = true;
            this.changeFigure.Items.AddRange(new object[] {
            "Круг",
            "Прямоугольник",
            "Треугольник"});
            this.changeFigure.Location = new System.Drawing.Point(81, 28);
            this.changeFigure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeFigure.Name = "changeFigure";
            this.changeFigure.Size = new System.Drawing.Size(212, 24);
            this.changeFigure.TabIndex = 6;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changeFigure);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textAreal);
            this.Controls.Add(this.textVariable2);
            this.Controls.Add(this.textVariable1);
            this.Controls.Add(this.variable2);
            this.Controls.Add(this.variable1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(388, 305);
            this.Load += new System.EventHandler(this.MainControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox variable1;
        private System.Windows.Forms.TextBox variable2;
        private System.Windows.Forms.Label textVariable1;
        private System.Windows.Forms.Label textVariable2;
        private System.Windows.Forms.Label textAreal;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox changeFigure;
    }
}
