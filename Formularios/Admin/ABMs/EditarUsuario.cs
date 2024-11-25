using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Clases;

namespace Practicas.Formularios.Admin.ABMs
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            cmbRol.SelectedIndex = 0;
            Modelos.Usuario usuario_base = Clases.Lógica.AdministracionUsuarios.LeerUsuarios("usr_id", State.id_editar_usuario.ToString(), false)[0];
            txtNombre.Text = usuario_base.name;
            if (usuario_base.role == "admin")
            {
                cmbRol.SelectedIndex = 1;
            }
        }

        private void cboxNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = cboxNombre.Checked;
        }

        private void cboxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.Enabled = cboxContraseña.Checked;
        }

        private void cboxRol_CheckedChanged(object sender, EventArgs e)
        {
            cmbRol.Enabled = cboxRol.Checked;
        }
    }
}
