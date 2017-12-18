using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Model;

namespace UsingForm
{
    public partial class AddForm : Form
    {
        /// <summary>
        /// Название фигуры для таблицы
        /// </summary>
        public string FigureName { set; get; }

        /// <summary>
        /// Площадь фигуры для таблицы
        /// </summary>
        public double FigureSquare { set; get; }

        /// <summary>
        /// Первое введенное значение для таблицы
        /// </summary>
        public double Var1Name { set; get; }

        /// <summary>
        /// Второе введенное значение для таблицы
        /// </summary>
        public double Var2Name { set; get; }

        /// <summary>
        /// Для записи в таблицу
        /// </summary>
        public event OnCalculate Calculated;


        /// <summary>
        /// Поддержка конструктора 
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Разрешение на занесение данных в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button4_Click(object sender, EventArgs e)
        {
            Calculate();
            if (comboBox.SelectedIndex == 0)
            {
                if (Variable1.Text != string.Empty)
                {
                    rec.Enabled = true;
                    recChange.Enabled = true;
                }
            }
            if (comboBox.SelectedIndex == 1)
            {
                if (Variable2.Text != string.Empty && Variable3.Text != string.Empty)
                {
                    rec.Enabled = true;
                    recChange.Enabled = true;
                }
            }
            if (comboBox.SelectedIndex == 2)
            {
                if (Variable2.Text != string.Empty && Variable3.Text != string.Empty)
                {
                    rec.Enabled = true;
                    recChange.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Фильтрация вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == ',' || e.KeyChar == (char) Keys.Back)
                {
                    if (e.KeyChar == (char) Keys.Back)
                    {
                    }
                    else if (Variable1.Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        /// <summary>
        /// Фильтрация вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == ',' || e.KeyChar == (char) Keys.Back)
                {
                    if (e.KeyChar == (char) Keys.Back)
                    {
                    }
                    else if (Variable2.Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Проверка ввода данных
        /// </summary>
        void Calculate()
        {
            if (comboBox.SelectedIndex == 0)
            {
                if (Variable1.Text == string.Empty)
                {

                    {
                        MessageBox.Show(
                            @"Задайте пожалуйста радиус.",
                            @"Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    return;
                }

                var r = double.Parse(Variable1.Text);

                if (r < 0 || r == 0)
                {
                    {
                        MessageBox.Show(
                            @"Радиус равен или меньше 0",
                            @"Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    return;
                }

                Circle circle = new Circle(r);
                double vol = circle.Calculate();
                Var1Name = r;
                label1.Text = @"Площадь круга по введенным данным равна " + vol.ToString("F");
            }
            if (comboBox.SelectedIndex == 1)
            {
                if (Variable2.Text == string.Empty)
                {
                    {
                        MessageBox.Show(
                            @"Пожалуйста введите длину стороны А.",
                            @"Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    return;
                }

                if (Variable3.Text == string.Empty)
                {
                    {
                        MessageBox.Show(
                            @"Пожалуйста введите длину стороны B.",
                            @"Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    return;
                }

                var a = double.Parse(Variable2.Text);
                var b = double.Parse(Variable3.Text);

                if (a < 0 || a == 0)
                {
                    {
                        MessageBox.Show(
                            @"Длина стороны А равна или меньше 0",
                            @"Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    return;
                }

                if (b < 0 || b == 0)
                {
                    {
                        MessageBox.Show(
                            @"Длина стороны B равна или меньше 0",
                            @"Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    return;
                }

                var rectangle = new Rectangle(a, b);
                var vol = rectangle.Calculate();
                Var1Name = a;
                Var2Name = b;
                label1.Text = @"Площадь прямоугольника по введенным данным равна " + vol.ToString("F");
            }
            if (comboBox.SelectedIndex == 2)
            {
                if (Variable2.Text == string.Empty)
                {
                    {
                        MessageBox.Show(
                            @"Задайте пожалуйста длину треугольника.",
                            @"Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    return;
                }

                if (Variable3.Text == string.Empty)
                {
                    {
                        MessageBox.Show(
                            @"Задайте пожалуйста высоту треугольника.",
                            @"Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    return;
                }

                var a = double.Parse(Variable2.Text);
                var b = double.Parse(Variable3.Text);

                if (a < 0 || a == 0)
                {
                    {
                        MessageBox.Show(
                            @"Длина  равна или меньше 0",
                            @"Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    return;
                }

                if (b < 0 || b == 0)
                {
                    {
                        MessageBox.Show(
                            @"Высота треугольника равна или меньше 0",
                            @"Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    return;
                }

                var triangle = new Triangle(a, b);
                var vol = triangle.Calculate();
                Var1Name = a;
                Var2Name = b;
                label1.Text = @"Площадь треугольника по введенным данным равна " + vol.ToString("F");
            }
        }

        /// <summary>
        /// Проверка ввода данных
        /// </summary>
        void Calculate1()
        {
            if (comboBox.SelectedIndex == 0)
            {
                var r = double.Parse(Variable1.Text);
                Circle circle = new Circle(r);
                double vol = circle.Calculate();
                FigureName = "круг";
                FigureSquare = vol;
                Var1Name = r;
            }
            if (comboBox.SelectedIndex == 1)
            {
                var a = double.Parse(Variable2.Text);
                var b = double.Parse(Variable3.Text);
                var rectangle = new Rectangle(a, b);
                var vol = rectangle.Calculate();
                FigureName = "прямоугольник";
                FigureSquare = vol;
                Var1Name = a;
                Var2Name = b;
            }
            if (comboBox.SelectedIndex == 2)
            {
                var a = double.Parse(Variable2.Text);
                var b = double.Parse(Variable3.Text);
                var triangle = new Triangle(a, b);
                var vol = triangle.Calculate();
                FigureName = "треугольник";
                FigureSquare = vol;
                Var1Name = a;
                Var2Name = b;
            }
            if (Calculated != null) Calculated(FigureName, FigureSquare, Var1Name, Var2Name);
        }

        /// <summary>
        /// Фильтрация вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Variable3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == ',' || e.KeyChar == (char) Keys.Back)
                {
                    if (e.KeyChar == (char) Keys.Back)
                    {
                    }
                    else if (Variable1.Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public delegate void OnCalculate(string figName, double figSquare, double var1, double var2);

        /// <summary>
        /// Загрузка изображений и настройка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                groupBox.Text = @"Круг";
                PictureBox.Load(
                    "C://Users//Igor'//Desktop//учеба//НТВП//NTVP//Model//kru.jpg");
                label1.Text = @"Для нахождения площади круга введите радиус";
                label2.Text = @"R";
                Variable1.Clear();
                Variable2.Clear();
                Variable3.Clear();
                Variable1.Enabled = true;
                Variable2.Enabled = false;
                Variable3.Enabled = false;
                Variable1.Visible = true;
                Variable2.Visible = false;
                Variable3.Visible = false;
                OK.Enabled = true;
                rec.Enabled = false;
                recChange.Enabled = false;
            }

            if (comboBox.SelectedIndex == 1)
            {
                groupBox.Text = @"Прямоугольник";
                PictureBox.Load(
                    "C://Users//Igor'//Desktop//учеба//НТВП//NTVP//Model//prya.jpg");
                label1.Text = @"Для нахождения площади прямоугольника введите длины его смежных сторон";
                label2.Text = @"A";
                label3.Text = @"B";
                Variable1.Clear();
                Variable2.Clear();
                Variable3.Clear();
                Variable1.Enabled = false;
                Variable2.Enabled = true;
                Variable3.Enabled = true;
                Variable1.Visible = false;
                Variable2.Visible = true;
                Variable3.Visible = true;
                OK.Enabled = true;
                rec.Enabled = false;
                recChange.Enabled = false;
            }

            if (comboBox.SelectedIndex == 2)
            {
                groupBox.Text = @"Треугольник";
                PictureBox.Load(
                    "C://Users//Igor'//Desktop//учеба//НТВП//NTVP//Model//tre.jpg");
                label1.Text = @"Для нахождения площади треугольника введите длину и высоту";
                label2.Text = @"A";
                label3.Text = @"H";
                Variable1.Clear();
                Variable2.Clear();
                Variable3.Clear();
                Variable1.Enabled = false;
                Variable2.Enabled = true;
                Variable3.Enabled = true;
                Variable1.Visible = false;
                Variable2.Visible = true;
                Variable3.Visible = true;
                OK.Enabled = true;
                rec.Enabled = false;
                recChange.Enabled = false;
            }
        }

        /// <summary>
        /// Вызов метода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_3(object sender, EventArgs e)
        {
            Calculate1();
        }

        private void recChange_Click(object sender, EventArgs e)
        {
            Calculate1();
            var main = this.Owner as MainForm;
            if (main != null)
            {
                if (FigureName == "круг")
                {
                    main.dataGridView1.CurrentRow.Cells[1].Value = FigureSquare;
                    main.dataGridView1.CurrentRow.Cells[2].Value = Var1Name;
                }
                if (FigureName == "прямоугольник")
                {
                    main.dataGridView1.CurrentRow.Cells[1].Value = FigureSquare;
                    main.dataGridView1.CurrentRow.Cells[2].Value = Var1Name;
                    main.dataGridView1.CurrentRow.Cells[3].Value = Var2Name;
                }
                if (FigureName == "треугольник")
                {
                    main.dataGridView1.CurrentRow.Cells[1].Value = FigureSquare;
                    main.dataGridView1.CurrentRow.Cells[2].Value = Var1Name;
                    main.dataGridView1.CurrentRow.Cells[3].Value = Var2Name;
                }
            }
            Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
        }

        private void groupBox_TextChanged(object sender, EventArgs e)
        {
            if (groupBox.Text == @"Круг")
            {
                Variable1.Visible = true;
                Variable2.Visible = false;
                Variable3.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
            }
            if (groupBox.Text == @"Прямоугольник")
            {
                Variable1.Visible = false;
                Variable2.Visible = true;
                Variable3.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
            if (groupBox.Text == @"Треугольник")
            {
                Variable1.Visible = false;
                Variable2.Visible = true;
                Variable3.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
        }
    }
}
