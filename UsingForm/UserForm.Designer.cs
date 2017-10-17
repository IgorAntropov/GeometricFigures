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
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Variable1 = new System.Windows.Forms.TextBox();
            this.Variable2 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Variable3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OK.Location = new System.Drawing.Point(12, 164);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(77, 30);
            this.OK.TabIndex = 3;
            this.OK.Text = "Расчитать";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(221, 44);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PictureBox.Location = new System.Drawing.Point(96, 86);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(172, 143);
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Variable1
            // 
            this.Variable1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Variable1.Location = new System.Drawing.Point(12, 86);
            this.Variable1.MaxLength = 5;
            this.Variable1.Name = "Variable1";
            this.Variable1.Size = new System.Drawing.Size(58, 20);
            this.Variable1.TabIndex = 10;
            this.Variable1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Variable2
            // 
            this.Variable2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Variable2.Location = new System.Drawing.Point(12, 112);
            this.Variable2.MaxLength = 5;
            this.Variable2.Name = "Variable2";
            this.Variable2.Size = new System.Drawing.Size(58, 20);
            this.Variable2.TabIndex = 11;
            this.Variable2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Круг",
            "Прямоугольник",
            "Треугольник"});
            this.comboBox.Location = new System.Drawing.Point(52, 5);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(160, 21);
            this.comboBox.TabIndex = 13;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Variable3
            // 
            this.Variable3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Variable3.Location = new System.Drawing.Point(12, 138);
            this.Variable3.MaxLength = 5;
            this.Variable3.Name = "Variable3";
            this.Variable3.Size = new System.Drawing.Size(58, 20);
            this.Variable3.TabIndex = 14;
            this.Variable3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Variable3_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "R";
            // 
            // rec
            // 
            this.rec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rec.Location = new System.Drawing.Point(12, 200);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(77, 30);
            this.rec.TabIndex = 16;
            this.rec.Text = "Записать";
            this.rec.UseVisualStyleBackColor = true;
            this.rec.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 245);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Variable3);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.Variable2);
            this.Controls.Add(this.Variable1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.MaximumSize = new System.Drawing.Size(1400, 740);
            this.MinimumSize = new System.Drawing.Size(291, 284);
            this.Name = "UserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox Variable1;
        private System.Windows.Forms.TextBox Variable2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox Variable3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rec;
    }
}

