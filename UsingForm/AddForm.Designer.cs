namespace UsingForm
{
    partial class AddForm
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
            this.rec = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.recChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OK.Location = new System.Drawing.Point(4, 96);
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
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PictureBox.Location = new System.Drawing.Point(92, 19);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(172, 143);
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            // 
            // Variable1
            // 
            this.Variable1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Variable1.Location = new System.Drawing.Point(4, 44);
            this.Variable1.MaxLength = 5;
            this.Variable1.Name = "Variable1";
            this.Variable1.Size = new System.Drawing.Size(58, 20);
            this.Variable1.TabIndex = 10;
            this.Variable1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Variable2
            // 
            this.Variable2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Variable2.Location = new System.Drawing.Point(4, 44);
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
            this.Variable3.Location = new System.Drawing.Point(4, 70);
            this.Variable3.MaxLength = 5;
            this.Variable3.Name = "Variable3";
            this.Variable3.Size = new System.Drawing.Size(58, 20);
            this.Variable3.TabIndex = 14;
            this.Variable3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Variable3_KeyPress);
            // 
            // rec
            // 
            this.rec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rec.Location = new System.Drawing.Point(4, 132);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(77, 30);
            this.rec.TabIndex = 16;
            this.rec.Text = "Записать";
            this.rec.UseVisualStyleBackColor = true;
            this.rec.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.recChange);
            this.groupBox.Controls.Add(this.rec);
            this.groupBox.Controls.Add(this.PictureBox);
            this.groupBox.Controls.Add(this.Variable3);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.OK);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.Variable2);
            this.groupBox.Controls.Add(this.Variable1);
            this.groupBox.Location = new System.Drawing.Point(3, 76);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(270, 168);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            this.groupBox.TextChanged += new System.EventHandler(this.groupBox_TextChanged);
            // 
            // recChange
            // 
            this.recChange.Location = new System.Drawing.Point(4, 132);
            this.recChange.Name = "recChange";
            this.recChange.Size = new System.Drawing.Size(77, 30);
            this.recChange.TabIndex = 18;
            this.recChange.Text = "Записать";
            this.recChange.UseVisualStyleBackColor = true;
            this.recChange.Click += new System.EventHandler(this.recChange_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 245);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1400, 740);
            this.MinimumSize = new System.Drawing.Size(291, 284);
            this.Name = "AddForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление данных";
            //this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button OK;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox PictureBox;
        public System.Windows.Forms.TextBox Variable1;
        public System.Windows.Forms.TextBox Variable2;
        public System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.TextBox Variable3;
        public System.Windows.Forms.Button rec;
        public System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.Button recChange;
    }
}

