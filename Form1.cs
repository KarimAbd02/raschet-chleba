using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР2ПП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x, y, b, c, d, g, z;
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);
                new raschet().metd(x, y, z, out b, out c, out d, out g);
                label2.Text = "Муки понадобится: " + b + " гр.";
                label3.Text = "Дрожжей понадобится: " + c + " гр.";
                label4.Text = "Сахара понадобится: " + d + " гр.";
                label5.Text = "Соли понадобится: " + g + " гр.";
            }
            catch(FormatException) { MessageBox.Show("Вводите только числовые значения!", "Ошибка!"); }
        }
    }

    class raschet
    {
        double a, f, muka = 0.042, drojji = 0.025, sahar = 0.0016, sol = 0.0066;
        public void metd(double x, double y, double z, out double b, out double c, out double d, out double e)
        {
            a = Math.Ceiling(x * y);
            f = Math.Ceiling(a * z);
            b = Math.Ceiling(f * muka);
            c = Math.Ceiling(f * drojji);
            d = Math.Ceiling(f * sahar);
            e = Math.Ceiling(f * sol);
        }
    }
}
