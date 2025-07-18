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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            cmbRol.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar nombre de usuario
            if (!InputValidator.ValidateUsername(txtNombre.Text, out string nameError))
            {
                InputValidator.ShowValidationError(nameError);
                return;
            }

            // Validar contraseña
            if (!InputValidator.ValidatePassword(txtContraseña.Text, out string passError))
            {
                InputValidator.ShowValidationError(passError);
                return;
            }

            // Validar email
            if (!InputValidator.ValidateEmail(txtEmail.Text, out string emailError))
            {
                InputValidator.ShowValidationError(emailError);
                return;
            }

            // Validar rol seleccionado
            if (string.IsNullOrWhiteSpace(cmbRol.Text))
            {
                InputValidator.ShowValidationError("Debe seleccionar un rol");
                return;
            }

            // Si todas las validaciones pasan, crear el usuario
            try
            {
                Clases.Lógica.AdministracionUsuarios.CrearUsuario(txtNombre.Text, cmbRol.Text, txtContraseña.Text, txtEmail.Text);
                InputValidator.ShowSuccessMessage("Usuario creado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
