using System;
using System.Windows.Forms;
using System.IO;

namespace UsingForm
{
    public partial class MainForm : Form
    {
        static string path;
        /// <summary>
        /// Поддержка конструктора
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вывод справки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HelpMenu_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                    @"По всем вопросам обращаться: shshlaika@mail.ru",
                    @"Справка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Закрытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление элемента в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            AddForm fadd = new AddForm();
            fadd.Calculated += fadd_Calculated;
            fadd.rec.Visible = true;
            fadd.recChange.Visible = false;
            fadd.Variable1.Clear();
            fadd.Variable2.Clear();
            fadd.Variable3.Clear();
            fadd.groupBox.Text = "";
            fadd.Variable1.Enabled = false;
            fadd.Variable2.Enabled = false;
            fadd.Variable3.Enabled = false;
            fadd.Variable1.Visible = false;
            fadd.Variable2.Visible = false;
            fadd.Variable3.Visible = false;
            fadd.label2.Visible = false;
            fadd.label3.Visible = false;
            fadd.OK.Enabled = false;
            fadd.rec.Enabled = false;
            fadd.label1.Text = @"Выберите фигуру для расчета площади";
            fadd.ShowDialog();

            if (dataGridView1.Rows.Count == 0)
            {
                SaveMenu.Enabled = false;
                SaveAsMenu.Enabled = false;
                Change.Enabled = false;
            }
            else
            {
                Search.Enabled = true;
                SaveAsMenu.Enabled = true;
            }
        }

        /// <summary>
        /// Запись созданного элемента и его данных
        /// </summary>
        /// <param name="name"></param>
        /// <param name="square"></param>
        /// <param name="var1"></param>
        /// <param name="var2"></param>
        void fadd_Calculated(string name, double square, double var1, double var2)
        {
            dataGridView1.Rows.Add(name, square, var1, var2);
        }

        /// <summary>
        /// Настройка формы при открытии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            SaveMenu.Enabled = false;
            SaveAsMenu.Enabled = false;
            Add.Enabled = false;
            Delete.Enabled = false;
            Search.Enabled = false;
            Change.Enabled = false;
        }

        /// <summary>
        /// Открытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenMenu_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            Stream myStr = null;
            var OpenTags = new OpenFileDialog();
            OpenTags.Filter = @"All file (*.*) | *.*| Text file |*.txt";
            OpenTags.FilterIndex = 2;
            if (OpenTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStr = OpenTags.OpenFile()) != null)
                {
                    path = OpenTags.FileName;
                    Check();
                    Add.Enabled = true;
                    SaveMenu.Enabled = true;
                    SaveAsMenu.Enabled = true;
                    Search.Enabled = true;
                    Delete.Enabled = false;

                    UseFile load = new UseFile();
                    load.Load(dataGridView1, path);
                }
            }
        }

        /// <summary>
        /// Вызов метода сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SaveMenu_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            UseFile save = new UseFile();
            save.Save(dataGridView1,path);
        }

        /// <summary>
        /// Вызов метода сохраненить как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SaveAsMenu_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            UseFile saveAs = new UseFile();
            saveAs.SaveAs(dataGridView1);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Удаление строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Delete_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            foreach (DataGridViewRow itemDelet in dataGridView1.SelectedRows)
                dataGridView1.Rows.RemoveAt(itemDelet.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mainControl1.ShowValue(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }
        /// <summary>
        /// Создать таблицу и вызов метода проверки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMenu_Click(object sender, EventArgs e)
        {
            Check();
            this.Size = new System.Drawing.Size(425, 323);
            Search.Enabled = false;
            Delete.Enabled = false;
        }

        /// <summary>
        /// Проверка и создание столбцов
        /// </summary>
        public void Check()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                var result = MessageBox.Show(@"Таблица не пуста, сохранить?", @"Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    DeleteColumn();
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "figure",
                        HeaderText = @"Геометрическая фигура",
                        Width = 300
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "yardage",
                        HeaderText = @"Площадь фигуры",
                        Width = 300
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "var1",
                        HeaderText = @"Исходный параметр №1",
                        Width = 300
                    });
                    dataGridView1.Columns["var1"].Visible = false;

                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "var2",
                        HeaderText = @"Исходный параметр №2",
                        Width = 300
                    });
                    dataGridView1.Columns["var2"].Visible = false;

                    dataGridView1.AllowUserToAddRows = false;
                    Add.Enabled = true;
                    SaveMenu.Enabled = false;
                    Change.Enabled = false;
                    Delete.Enabled = false;
                    SaveAsMenu.Enabled = false;
                    Search.Clear();
                }

                if (result == DialogResult.OK)
                {
                    UseFile saveAs = new UseFile();
                    saveAs.SaveAs(dataGridView1);
                    Add.Enabled = true;
                    SaveMenu.Enabled = false;
                    Change.Enabled = false;
                    Delete.Enabled = false;
                    SaveAsMenu.Enabled = false;
                    Search.Clear();
                    DeleteColumn();
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "figure",
                        HeaderText = @"Геометрическая фигура",
                        Width = 300
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "yardage",
                        HeaderText = @"Площадь фигуры",
                        Width = 300
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "var1",
                        HeaderText = @"Исходный параметр №1",
                        Width = 300
                    });
                    dataGridView1.Columns["var1"].Visible = false;

                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "var2",
                        HeaderText = @"Исходный параметр №2",
                        Width = 300
                    });
                    dataGridView1.Columns["var2"].Visible = false;
                }
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                DeleteColumn();
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "figure",
                    HeaderText = @"Геометрическая фигура",
                    Width = 300
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "yardage",
                    HeaderText = @"Площадь фигуры",
                    Width = 300
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "var1",
                    HeaderText = @"Исходный параметр №1",
                    Width = 300
                });
                dataGridView1.Columns["var1"].Visible = false;

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "var2",
                    HeaderText = @"Исходный параметр №2",
                    Width = 300
                });
                dataGridView1.Columns["var2"].Visible = false;

                dataGridView1.AllowUserToAddRows = false;
                Add.Enabled = true;
                Change.Enabled = false;
                Delete.Enabled = false;
                SaveMenu.Enabled = false;
                SaveAsMenu.Enabled = false;
                Search.Clear();
            }
        }

        /// <summary>
        /// Очистка таблицы
        /// </summary>
        private void DeleteColumn()
        {
            dataGridView1.Columns.Clear();
        }

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="dataGridView1"></param>
        public void Clear(DataGridView dataGridView1)
        {
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
        }

        /// <summary>
        /// Настройка активности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                Delete.Enabled = false;
                Change.Enabled = false;
                Search.Enabled = false;
            }
            else
            {
                Delete.Enabled = true;
                Change.Enabled = true;
                Search.Enabled = true;
                this.Size = new System.Drawing.Size(716, 323);

            }
        }

        /// <summary>
        /// Поиск по таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            for (var i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (var j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Search.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        /// <summary>
        /// Активность кнопки удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_MouseClick(object sender, MouseEventArgs e)
        {
            Delete.Enabled = true;
        }

        /// <summary>
        /// Вызов и настройка формы изменения элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Change_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(425, 323);
            var formadd = new AddForm();
            formadd.Owner = this;

            formadd.groupBox.Text = "";
            formadd.rec.Visible = false;
            formadd.recChange.Visible = true;
            formadd.Variable1.Visible = false;
            formadd.Variable2.Visible = false;
            formadd.Variable3.Visible = false;
            formadd.label2.Visible = false;
            formadd.label3.Visible = false;
            var fg = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            var sq = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var vr1 = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            var vr2 = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            if (fg == "круг")
            {
                formadd.comboBox.SelectedIndex = 0;
                formadd.comboBox.Enabled = false;
                formadd.Variable1.Enabled = true;
                formadd.Variable1.Text = vr1;
                formadd.label1.Text = @"Площадь круга по введенным данным равна " + sq;
                formadd.PictureBox.Load(
                    "C://Users//Igor'//Desktop//учеба//НТВП//NTVP//Model//kru.jpg");
            }
            if (fg == "прямоугольник")
            {
                formadd.comboBox.SelectedIndex = 1;
                formadd.comboBox.Enabled = false;
                formadd.Variable2.Text = vr1;
                formadd.Variable3.Text = vr2;
                formadd.label1.Text = @"Площадь прямоугольника по введенным данным равна " + sq;
                formadd.PictureBox.Load(
                    "C://Users//Igor'//Desktop//учеба//НТВП//NTVP//Model//prya.jpg");
            }
            if (fg == "треугольник")
            {
                formadd.comboBox.SelectedIndex = 2;
                formadd.comboBox.Enabled = false;
                formadd.Variable2.Text = vr1;
                formadd.Variable3.Text = vr2;
                formadd.label1.Text = @"Площадь треугольника по введенным данным равна " + sq;
                formadd.label3.Text = @"H";
                formadd.PictureBox.Load(
                    "C://Users//Igor'//Desktop//учеба//НТВП//NTVP//Model//tre.jpg");
            }
            formadd.ShowDialog();
        }
    }
}
