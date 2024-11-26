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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("ingrese datos validos");
            }
            else
            {
                AdministracionProductos.AgregarProducto(txtNombre.Text, Convert.ToInt32(txtPrecio.Text));
                this.Close();
            }
        }
    }
}
