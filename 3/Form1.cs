using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                Определение c = new Определение(x, y);
                MessageBox.Show(c.Ответ());
            }
            catch (Exception ec)
            {
                MessageBox.Show($"{ec.Message}");
            }
        }
        class Определение
        {
            private double a;
            private double b;
            public double a1
            {
                get { return a; }
                set { a = value; }
            }
            public double b1
            {
                get { return b; }
                set { b = value; }
            }
            public Определение(double al, double bl)
            {
                a = al;
                b = al;
            }
            public string Ответ()
            {
                if (b >= 0 && b <= 1 && a >= 0 && a <= 1 && a == -b || b >= 0 && b <= 1 && a <= 0 && a >= -1 && a == b)
                {
                    return "точка находится в области допустимых значений";
                }
                else
                {
                    return " точка находится вне области допустимых значений";
                }
            }
        }
    }
}
