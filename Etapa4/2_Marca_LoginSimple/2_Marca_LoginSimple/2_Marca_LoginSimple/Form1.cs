﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Marca_LoginSimple
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "Admin" && textBox1.Text == "Admin12345")
            {
                MessageBox.Show("Ingreso correctamente");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        
    }
}