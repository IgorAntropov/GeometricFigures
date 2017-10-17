using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace UsingForm
{
    public partial class MainForm : Form
    {
        static string path;

        public MainForm()
        {
            InitializeComponent();
        }

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

        public void CloseMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            UserForm fadd = new UserForm();
            fadd.Calculated += fadd_Calculated;
            fadd.ShowDialog();
            if (dataGridView1.Rows[0].Cells[0].Value == null)
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

        void fadd_Calculated(string name, double square, double var1, double var2)
        {
            dataGridView1.Rows.Add(name, square, var1, var2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveMenu.Enabled = false;
            SaveAsMenu.Enabled = false;
            Add.Enabled = false;
            Delete.Enabled = false;
            Search.Enabled = false;
            Change.Enabled = false;
        }

        public void OpenMenu_Click(object sender, EventArgs e)
        {
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

                    var myRead = new StreamReader(myStr, System.Text.Encoding.UTF8);
                    string[] str;

                    var num = 0;
                    var str1 = myRead.ReadToEnd().Split('\n');
                    num = str1.Count();
                    dataGridView1.RowCount = num + 1;
                    for (var i = 0; i < num; i++)
                    {
                        str = str1[i].Split(':');
                        for (var j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = str[j];
                        }
                    }
                    myRead.Close();
                }
            }
        }


        public void SaveMenu_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void SaveAsMenu_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
        }

        public void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow itemDelet in dataGridView1.SelectedRows)
                dataGridView1.Rows.RemoveAt(itemDelet.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CreateMenu_Click(object sender, EventArgs e)
        {
            Check();
            Search.Enabled = false;
            Delete.Enabled = false;
        }

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
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "var2",
                        HeaderText = @"Исходный параметр №2",
                        Width = 300
                    });
                    Add.Enabled = true;
                    SaveMenu.Enabled = false;
                    Change.Enabled = false;
                    Delete.Enabled = false;
                    SaveAsMenu.Enabled = false;
                    Search.Clear();
                }

                if (result == DialogResult.OK)
                {
                    SaveAs();
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
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "var2",
                        HeaderText = @"Исходный параметр №2",
                        Width = 300
                    });
                }
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
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "var2",
                    HeaderText = @"Исходный параметр №2",
                    Width = 300
                });
                Add.Enabled = true;
                Change.Enabled = false;
                Delete.Enabled = false;
                SaveMenu.Enabled = false;
                SaveAsMenu.Enabled = false;
                Search.Clear();
            }
        }

        public void Save()
        {
            using (var myStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                System.Text.Encoding.GetEncoding(1251);
                StreamWriter myWriter = new StreamWriter(myStream);
                for (var i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (var j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        if ((dataGridView1.ColumnCount - j) != 1) myWriter.Write(":");
                    }

                    if (((dataGridView1.RowCount - 1) - i - 1) != 0) myWriter.WriteLine();
                }
                myWriter.Close();
            }
        }

        public void SaveAs()
        {
            System.IO.Stream myStream;
            var saveTags = new SaveFileDialog();
            saveTags.Filter = @"All file (*.*) | *.*| Text file |*.txt";
            saveTags.FilterIndex = 2;
            if (saveTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveTags.OpenFile()) != null)
                {
                    System.Text.Encoding.GetEncoding(1251);
                    StreamWriter myWriter = new StreamWriter(myStream);
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            if ((dataGridView1.ColumnCount - j) != 1) myWriter.Write(":");
                        }

                        if (((dataGridView1.RowCount - 1) - i - 1) != 0) myWriter.WriteLine();
                    }
                    myWriter.Close();
                }
                myStream.Close();
            }
        }

        private void DeleteColumn()
        {
            dataGridView1.Columns.Clear();
        }

        public void Clear(DataGridView dataGridView1)
        {
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                Delete.Enabled = false;
            }
            else
            {
                Delete.Enabled = true;
            }
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                Change.Enabled = false;
            }
            else
            {
                Change.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private void FailMenu_Click(object sender, EventArgs e)
        {
        }

        private void Search_MouseClick(object sender, MouseEventArgs e)
        {
            Delete.Enabled = true;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            var formadd = new ChangeForm();
            formadd.Owner = this;
            
            var fg = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            var sq = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var vr1 = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            var vr2 = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            if (fg == "круг")
            {
                formadd.label3.Text = @"R";
                formadd.textBox2.Enabled = false;
                formadd.label4.Enabled = false;
                formadd.pictureBox1.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//kru.jpg");
            }
            if (fg == "прямоугольник")
            {
                formadd.pictureBox1.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//prya.jpg");
            }
            if (fg == "треугольник")
            {
                formadd.label4.Text = @"H";
                formadd.pictureBox1.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//tre.jpg");
            }
            formadd.textBox1.Text = vr1;
            formadd.textBox2.Text = vr2;
            formadd.label1.Text = fg;
            formadd.label2.Text = sq;
            formadd.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
