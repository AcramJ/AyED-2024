using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Marca_TerminosYCondiciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Aceptar_CheckedChanged(object sender, EventArgs e)
        {
            if (Aceptar.Checked == true)
            {
                boton.Enabled = true;
            }
            else
            {
                boton.Enabled = false;
            }
        }

        private void boton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
