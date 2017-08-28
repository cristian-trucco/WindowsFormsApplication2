using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Equacao eq = new Equacao();
                eq.seta(Convert.ToDouble(textBoxA.Text));
                eq.setb(Convert.ToDouble(textBoxB.Text));
                eq.setc(Convert.ToDouble(textBoxC.Text));

                eq.calcularDelta();
                textBoxX1.Text = eq.calcularX1();
                textBoxX2.Text = eq.calcularX2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Digitar valores de A, B e C! ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxX1.Clear();
            textBoxX2.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelC_Click(object sender, EventArgs e)
        {

        }
    }
}
