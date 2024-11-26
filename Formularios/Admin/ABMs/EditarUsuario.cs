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
        private Modelos.Usuario usuario_edit;
        public Modelos.Usuario usuario_base; // perdon profe

        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){Revalidar();}

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            Modelos.Usuario response = Clases.Lógica.AdministracionUsuarios.LeerUsuarios("usr_id", State.id_editar_usuario.ToString(), false)[0];
            usuario_edit = usuario_base = response;
            cmbRol.SelectedIndex = 0;

            txtNombre.Text = usuario_base.name;
            if (usuario_base.role.ToLower() == "admin")
            {
                cmbRol.SelectedIndex = 1;
            }
        }

        private void cboxNombre_CheckedChanged(object sender, EventArgs e){Revalidar();}

        private void cboxContraseña_CheckedChanged(object sender, EventArgs e){Revalidar();}

        private void cboxRol_CheckedChanged(object sender, EventArgs e){Revalidar();}

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Revalidar()
        {
            // NOMBRE
            txtNombre.Enabled = cboxNombre.Checked;
            if (txtNombre.Enabled == false)
            {
                usuario_edit.name = usuario_base.name;
            }
            else
            { 
                usuario_edit.name = txtNombre.Text;
            }

            //CONTRASEÑA
            txtContraseña.Enabled = cboxContraseña.Checked;
            if (txtContraseña.Enabled == false)
            {
                usuario_edit.contraseña = null;
            }
            else
            {
                usuario_edit.contraseña = txtContraseña.Text;
            }
            // ROL
            cmbRol.Enabled = cboxRol.Checked;
            if (cmbRol.Enabled == false)
            {
                usuario_edit.role = usuario_base.role;
            }
            else
            {
                switch (cmbRol.Text)
                {
                    case "Usuario": usuario_edit.role = "Usuario"; break;
                    case "Administrador": usuario_edit.role = "Admin"; break;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Revalidar();
            Clases.Lógica.AdministracionUsuarios.EditarUsuario(usuario_edit);
            this.Close();
        }
    }
}
