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
    public partial class ModificarNoticia : Form
    {
        public ModificarNoticia()
        {
            InitializeComponent();
        }

        private void ModificarNoticia_Load(object sender, EventArgs e)
        {
            AdministradorNoticias.CargarTitulos(comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdministradorNoticias.CargarNoticiaSeleccionada(comboBox1.Text,textBox1,richTextBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdministradorNoticias.CambiarNoticia(textBox1.Text, richTextBox1.Text,AdministradorNoticias.BuscarId(comboBox1.Text));
            comboBox1.Items.Clear();
            AdministradorNoticias.CargarTitulos(comboBox1);
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
