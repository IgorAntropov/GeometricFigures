using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingForm
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void MainControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void ShowValue(string a,string b, string c, string d)
        {
            variable1.Enabled = false;
            variable2.Enabled = false;
            changeFigure.Enabled = false;
            variable1.Text = c;
            variable2.Text = d;
            textAreal.Text = b;
            if (a == "круг")
            {
                changeFigure.SelectedIndex = 0;
                textAreal.Text = "Площадь круга по введенным данным равна  "+b;
                variable2.Visible = false;
                textVariable2.Visible = false;
                textVariable1.Text = "R";
                pictureBox.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//kru.jpg");
            }
            if (a == "прямоугольник")
            {
                changeFigure.SelectedIndex = 1;
                textAreal.Text = "Площадь прямоугольника по введенным данным равна  " + b;
                variable2.Visible = true;
                textVariable2.Visible = true;
                textVariable1.Text = "A";
                textVariable2.Text = "B";
                pictureBox.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//prya.jpg");
            }
            if (a == "треугольник")
            {
                changeFigure.SelectedIndex = 2;
                textAreal.Text = "Площадь треугольника по введенным данным равна  " + b;
                variable2.Visible = true;
                textVariable2.Visible = true;
                textVariable1.Text = "A";
                textVariable2.Text = "H";
                pictureBox.Load(
                    "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//NTVP//Model//tre.jpg");
            }
        }
    }
}
