using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_Marca_ConversorTemperaturasGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kelvin.Text = (int.Parse(textBox1.Text) + +273).ToString();
            Fahrenheit.Text = (int.Parse(textBox1.Text) * 18 / 10 + 32).ToString();
        }

        private void Fahrenheit_Click(object sender, EventArgs e)
        {

        }
    }
}
