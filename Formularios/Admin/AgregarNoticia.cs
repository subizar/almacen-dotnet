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
using Practicas.Formularios.Admin.ABMs;

namespace Practicas.Formularios.Admin
{
    public partial class AgregarNoticia : Form
    {
        public AgregarNoticia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdministradorNoticias.AgregarNoticia(textBox1.Text, richTextBox1.Text);
            MessageBox.Show("Noticia agregada con éxito");
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form next = new ModificarNoticia();
            this.Visible = false;
            next.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form next = new EliminarNoticia();
            this.Visible = false;
            next.ShowDialog();
            this.Visible = true;
        }
    }
}
