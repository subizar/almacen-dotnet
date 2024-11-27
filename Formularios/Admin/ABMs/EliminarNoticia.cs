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

namespace Practicas.Formularios.Admin.ABMs
{
    public partial class EliminarNoticia : Form
    {
        public EliminarNoticia()
        {
            InitializeComponent();
        }

        private void EliminarNoticia_Load(object sender, EventArgs e)
        {
            AdministradorNoticias.CargarTitulos(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdministradorNoticias.EliminarNoticia(AdministradorNoticias.BuscarId(comboBox1.Text));
            comboBox1.Items.Clear();
            AdministradorNoticias.CargarTitulos(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
