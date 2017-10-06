using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UsingForm
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            Variable1.Visible = false;
            Variable2.Visible = false;
            OkCircle.Visible = false;
            OkRectangle.Visible = false;
            OkTriangle.Visible = false;
            //
            Variable1.Clear();
            Variable2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = ("R");
            label1.Text = "Для нахождения площади круга введите радиус";
            PictureBox.Load("C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//kru.jpg");
            //
            label2.Visible = false;
            label3.Visible = false;
            Variable1.Visible = false;
            Variable2.Visible = false;
            OkRectangle.Visible = false;
            OkTriangle.Visible = false;
            //
            Variable1.Visible = true;
            label2.Visible = true;
            OkCircle.Visible = true;
            //
            Variable1.Clear();
            Variable2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = ("А");
            label3.Text = ("В");
            label1.Text = "Для нахождения площади прямоугольника введите длины его смежных сторон";
            PictureBox.Load("C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//prya.jpg");
            //
            label2.Visible = false;
            label3.Visible = false;
            Variable1.Visible = false;
            Variable2.Visible = false;
            OkCircle.Visible = false;
            OkTriangle.Visible = false;
            //
            Variable1.Visible = true;
            Variable2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            OkRectangle.Visible = true;
            //
            Variable1.Clear();
            Variable2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = ("А");
            label3.Text = ("H");
            label1.Text = "Для нахождения площади треугольника введите длину и высоту";
            PictureBox.Load("C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//tre.jpg");
            //
            label2.Visible = false;
            label3.Visible = false;
            Variable1.Visible = false;
            Variable2.Visible = false;
            OkCircle.Visible = false;
            OkRectangle.Visible = false;
            //
            Variable1.Visible = true;
            Variable2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            OkTriangle.Visible = true;
            //
            Variable1.Clear();
            Variable2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Variable1.Text == string.Empty)
            {
                {
                    MessageBox.Show(
                        "Задайте пожалуйста длину треугольника.",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return;
            }

            if (Variable2.Text == string.Empty)
            {
                {
                    MessageBox.Show(
                        "Задайте пожалуйста высоту треугольника.",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return;
            }

            var a = double.Parse(Variable1.Text);
            var b = double.Parse(Variable2.Text);

            if (a < 0 || a == 0)
            {
                {
                    MessageBox.Show(
                        "Длина  равна или меньше 0",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return;
            }

            if (b < 0 || b == 0)
            {
                {
                    MessageBox.Show(
                        "Высота треугольника равна или меньше 0",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return;
            }

            Model.Triangle triangle = new Triangle(a, b);

            double vol = triangle.Calculate();
            label1.Text = "Площадь треугольника по введенным данным равна " + vol.ToString("F");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Variable1.Text == string.Empty)
            {
                {
                    MessageBox.Show(
                        "Пожалуйста введите длину стороны А.",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return;
            }

            if (Variable2.Text == string.Empty)
            {
                {
                    MessageBox.Show(
                        "Пожалуйста введите длину стороны B.",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                return;
            }

            var a = double.Parse(Variable1.Text);
            var b = double.Parse(Variable2.Text);

            if (a < 0 || a == 0)
            {
                {
                    MessageBox.Show(
                        "Длина стороны А равна или меньше 0",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return;
            }

            if (b < 0 || b == 0)
            {
                {
                    MessageBox.Show(
                        "Длина стороны B равна или меньше 0",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return;
            }

            Model.Rectangle rectangle = new Model.Rectangle(a, b);

            double vol = rectangle.Calculate();
            label1.Text = "Площадь прямоугольника по введенным данным равна " + vol.ToString("F");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Variable1.Text == string.Empty)
            {

                {
                    MessageBox.Show(
                      "Задайте пожалуйста радиус.",
                      "Сообщение",
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
                        "Радиус равен или меньше 0",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return;
            }

            Circle circle = new Circle(r);

            double vol = circle.Calculate();
            label1.Text = "Площадь круга по введенным данным равна " + vol.ToString("F");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (Variable1.Text.Contains(","))
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (Variable2.Text.Contains(","))
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
