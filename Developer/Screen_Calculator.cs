using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer
{
    public partial class Screen_Calculator : Form
    {
        // References
        Class.ClassSum ClassSum = new Class.ClassSum();
        Class.ClassRest ClassRest = new Class.ClassRest();
        Class.ClassMult ClassMult = new Class.ClassMult();
        Class.ClassDiv ClassDiv = new Class.ClassDiv();
        
        public Screen_Calculator()
        {
            InitializeComponent();
        }

        //Declare variables
        double x;
        double y;
        string operador;

        private void button8_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtscreen.Text = ".";
        }

        private void Screen_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            x = double.Parse(txtscreen.Text);
            txtscreen.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            x = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operador = "*";
            x = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "/";
            x = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtscreen.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            y = double.Parse(txtscreen.Text);

            double sum;
            double rest;
            double div;
            double mult;

            switch (operador) 
            {
                case "+":
                    sum = ClassSum.sum(x,y);
                    txtscreen.Text = sum.ToString();
                    break;

                case "-":
                    rest = ClassRest.Rest(x,y);
                    txtscreen.Text = rest.ToString();
                    break;

                case "*":
                    div = ClassDiv.Div(x, y);
                    txtscreen.Text = div.ToString();
                    break;

                case "/":
                    mult = ClassMult.Mult(x,y);
                    txtscreen.Text = mult.ToString();
                    break;
            }
        }
    }
}
