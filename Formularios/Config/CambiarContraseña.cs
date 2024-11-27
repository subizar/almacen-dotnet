using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Clases.Lógica;

namespace Practicas.Formularios.Config
{
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
        }      

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdministracionUsuarios.CambiarContraseña(textBox1.Text, textBox2.Text);
            MessageBox.Show("Contraseña actualizada con exito");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}