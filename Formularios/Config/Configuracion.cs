using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Formularios.Config
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form next = new CambiarNombre();
            this.Close();
            next.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form next = new CambiarContraseña();
            this.Close();
            next.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
