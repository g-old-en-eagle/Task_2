using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;
namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn1.Click += btn1_Click;

            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(side.Text);

            List<Figure> figures = new List<Figure>();
            figures.Add(new Square(a));
            figures.Add(new Rhombus(a));
            figures.Add(new Circle(a));

            squarePer.Text = figures[0].GetPerimeter().ToString();
            rhombusPer.Text = figures[1].GetPerimeter().ToString();
            circlePer.Text = figures[2].GetPerimeter().ToString();
        }

    }
}
