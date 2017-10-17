using System;
using System.Windows.Forms;
using Model;

namespace UsingForm
{
    public partial class UserForm : Form
    {
        public string FigureName { set; get; }
        public double FigureSquare { set; get; }
        public double Var1Name { set; get; }
        public double Var2Name { set; get; }
        public event OnCalculate Calculated;

        public UserForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Variable1.Clear();
            Variable2.Clear();
            Variable3.Clear();
            Variable1.Enabled = false;
            Variable2.Enabled = false;
            Variable3.Enabled = false;
            OK.Enabled = false;
            rec.Enabled = false;
            label1.Text = @"Выберите фигуру для расчета площади";
        }

        public void button1_Click(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
        }

        public void button3_Click(object sender, EventArgs e)
        {
        }

        public void button6_Click(object sender, EventArgs e)
        {
        }

        public void button5_Click(object sender, EventArgs e)
        {
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Calculate();
            if (comboBox.SelectedIndex == 0)
            {
                if (Variable1.Text != string.Empty)
                {
                    rec.Enabled = true;
                }
            }
            if (comboBox.SelectedIndex == 1)
            {
                if (Variable2.Text != string.Empty && Variable3.Text != string.Empty)
                {
                    rec.Enabled = true;
                }
            }
            if (comboBox.SelectedIndex == 2)
            {
                if (Variable2.Text != string.Empty && Variable3.Text != string.Empty)
                {
                    rec.Enabled = true;
                }
            }
        }

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

        public void button1_Click_1(object sender, EventArgs e)
        {
        }

        public void button1_Click_2(object sender, EventArgs e)
        {
        }

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

        void Calculate1()
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
                label1.Text = @"Площадь круга по введенным данным равна " + vol.ToString("F");
                FigureName = "круг";
                FigureSquare = vol;
                Var1Name = r;
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
                label1.Text = @"Площадь прямоугольника по введенным данным равна " + vol.ToString("F");
                FigureName = "прямоугольник";
                FigureSquare = vol;
                Var1Name = a;
                Var2Name = b;
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
                label1.Text = @"Площадь треугольника по введенным данным равна " + vol.ToString("F");
                FigureName = "треугольник";
                FigureSquare = vol;
                Var1Name = a;
                Var2Name = b;
            }
            if (Calculated != null) Calculated(FigureName, FigureSquare, Var1Name, Var2Name);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
        }

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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                PictureBox.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//kru.jpg");
                label1.Text = @"Для нахождения площади круга введите радиус";
                Variable1.Clear();
                Variable2.Clear();
                Variable3.Clear();
                Variable1.Enabled = true;
                Variable2.Enabled = false;
                Variable3.Enabled = false;
                OK.Enabled = true;
                rec.Enabled = false;
            }

            if (comboBox.SelectedIndex == 1)
            {
                PictureBox.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//prya.jpg");
                label1.Text = @"Для нахождения площади прямоугольника введите длины его смежных сторон";
                label3.Text = @"B";
                Variable1.Clear();
                Variable2.Clear();
                Variable3.Clear();
                Variable1.Enabled = false;
                Variable2.Enabled = true;
                Variable3.Enabled = true;
                OK.Enabled = true;
                rec.Enabled = false;
            }

            if (comboBox.SelectedIndex == 2)
            {
                PictureBox.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//tre.jpg");
                label1.Text = @"Для нахождения площади треугольника введите длину и высоту";
                label3.Text = @"H";
                Variable1.Clear();
                Variable2.Clear();
                Variable3.Clear();
                Variable1.Enabled = false;
                Variable2.Enabled = true;
                Variable3.Enabled = true;
                OK.Enabled = true;
                rec.Enabled = false;
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Calculate1();
        }
    }
}
