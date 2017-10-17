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
    public partial class ChangeForm : Form
    {
        string lb11;
        public double cl { set; get; }
        public double rr { set; get; }
        public double aa { set; get; }
        public double bb { set; get; }

        public ChangeForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string lb1 = label1.Text;
            lb11 = lb1;
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                SaveChange.Enabled = true;
            }
             //circle
             if (lb1 == "круг")
            {
                if (textBox1.Text == string.Empty)
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

                var r = double.Parse(textBox1.Text);
                rr = r;
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
            cl=Math.PI * (r * r);
            label2.Text = cl.ToString("F");
            }

            //rectangle
            if (lb1 == "прямоугольник")
            {
                if (textBox1.Text == string.Empty)
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

                if (textBox2.Text == string.Empty)
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

                var a = double.Parse(textBox1.Text);
                aa = a;
                var b = double.Parse(textBox2.Text);
                bb = b;
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
                cl = a * b;
                label2.Text = cl.ToString("F");
            }

            //triangle
            if (lb1 == "треугольник")
            {
                if (textBox1.Text == string.Empty)
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

                if (textBox2.Text == string.Empty)
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
                var a = double.Parse(textBox1.Text);
                aa = a;
                var b = double.Parse(textBox2.Text);
                bb = b;

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
                cl = (0.5 * a) * b;
                label2.Text = cl.ToString("F");
            }
                


        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            SaveChange.Enabled = false;
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
                        if (textBox1.Text.Contains(","))
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
                        if (textBox2.Text.Contains(","))
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

        private void SaveChange_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (lb11 == "круг")
                {
                    main.dataGridView1.CurrentRow.Cells[1].Value = cl;
                    main.dataGridView1.CurrentRow.Cells[2].Value = rr;
                }
                if (lb11 == "прямоугольник")
                {
                    main.dataGridView1.CurrentRow.Cells[1].Value = cl;
                    main.dataGridView1.CurrentRow.Cells[2].Value = aa;
                    main.dataGridView1.CurrentRow.Cells[3].Value = bb;
                }
                if (lb11 == "треугольник")
                {
                    main.dataGridView1.CurrentRow.Cells[1].Value = cl;
                    main.dataGridView1.CurrentRow.Cells[2].Value = aa;
                    main.dataGridView1.CurrentRow.Cells[3].Value = bb;
                }
            }

            Close();
        }
    }
}
