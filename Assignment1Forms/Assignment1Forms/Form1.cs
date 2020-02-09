using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Assignment1Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            int N = Convert.ToInt32(textBox2.Text);
            Logic logic = new Logic();
            answer1.Text = logic.calculateValue(x, N).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox4.Text);
            double E = Convert.ToDouble(textBox3.Text);
            Logic logic = new Logic();
            label4.Text = logic.calculateSecondQuestion(x,E).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
