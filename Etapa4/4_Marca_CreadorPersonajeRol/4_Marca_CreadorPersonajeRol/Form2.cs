using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Marca_CreadorPersonajeRol
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, string vida, string habilidad, string raza)
        {

            InitializeComponent();
            NOMBRE2.Text = nombre;
            Vida2.Text = vida;
            Habilidades2.Text = habilidad;
            Raza2.Text = raza;

            
        }

        private void NOMBRE2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            form1 pantalla1 = new form1();
            pantalla1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}