using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstract_and_derived.Act3_U4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double side;
            double radius;

            if (double.TryParse(TxtSide.Text, out side))
            {
                Square square= new Square(side);
                LblResult.Text = "Area of square: " + square.CalculateArea().ToString();
            }

            if (double.TryParse(TxtRadius.Text, out radius))
            {
                Circle circle = new Circle(radius);
                LblResult.Text += "\nArea of Circle: " + circle.CalculateArea().ToString();
            }
        }
    }
}
