namespace UsingForm
{
    partial class UserForm
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
            this.CircleButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.OkCircle = new System.Windows.Forms.Button();
            this.OkRectangle = new System.Windows.Forms.Button();
            this.OkTriangle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Variable1 = new System.Windows.Forms.TextBox();
            this.Variable2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(46, 18);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(99, 31);
            this.CircleButton.TabIndex = 0;
            this.CircleButton.Text = "Круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(151, 18);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(99, 32);
            this.RectangleButton.TabIndex = 1;
            this.RectangleButton.Text = "Прямоугольник";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(256, 18);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(99, 32);
            this.TriangleButton.TabIndex = 2;
            this.TriangleButton.Text = "Треугольник";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // OkCircle
            // 
            this.OkCircle.Location = new System.Drawing.Point(61, 220);
            this.OkCircle.Name = "OkCircle";
            this.OkCircle.Size = new System.Drawing.Size(58, 30);
            this.OkCircle.TabIndex = 3;
            this.OkCircle.Text = "OK";
            this.OkCircle.UseVisualStyleBackColor = true;
            this.OkCircle.Click += new System.EventHandler(this.button4_Click);
            // 
            // OkRectangle
            // 
            this.OkRectangle.Location = new System.Drawing.Point(61, 220);
            this.OkRectangle.Name = "OkRectangle";
            this.OkRectangle.Size = new System.Drawing.Size(58, 30);
            this.OkRectangle.TabIndex = 4;
            this.OkRectangle.Text = "OK";
            this.OkRectangle.UseVisualStyleBackColor = true;
            this.OkRectangle.Click += new System.EventHandler(this.button5_Click);
            // 
            // OkTriangle
            // 
            this.OkTriangle.Location = new System.Drawing.Point(61, 220);
            this.OkTriangle.Name = "OkTriangle";
            this.OkTriangle.Size = new System.Drawing.Size(58, 30);
            this.OkTriangle.TabIndex = 5;
            this.OkTriangle.Text = "OK";
            this.OkTriangle.UseVisualStyleBackColor = true;
            this.OkTriangle.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 49);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(183, 107);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(172, 143);
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            // 
            // Variable1
            // 
            this.Variable1.Location = new System.Drawing.Point(61, 144);
            this.Variable1.Name = "Variable1";
            this.Variable1.Size = new System.Drawing.Size(58, 20);
            this.Variable1.TabIndex = 10;
            this.Variable1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Variable2
            // 
            this.Variable2.Location = new System.Drawing.Point(61, 170);
            this.Variable2.Name = "Variable2";
            this.Variable2.Size = new System.Drawing.Size(58, 20);
            this.Variable2.TabIndex = 11;
            this.Variable2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 262);
            this.Controls.Add(this.Variable2);
            this.Controls.Add(this.Variable1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkTriangle);
            this.Controls.Add(this.OkRectangle);
            this.Controls.Add(this.OkCircle);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.CircleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет площади геометрических фигур";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button OkCircle;
        private System.Windows.Forms.Button OkRectangle;
        private System.Windows.Forms.Button OkTriangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox Variable1;
        private System.Windows.Forms.TextBox Variable2;
    }
}

