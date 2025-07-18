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
            // Validar contraseña nueva
            if (!InputValidator.ValidatePassword(textBox1.Text, out string newPassError))
            {
                InputValidator.ShowValidationError($"Nueva contraseña: {newPassError}");
                return;
            }

            // Validar contraseña actual
            if (!InputValidator.ValidatePassword(textBox2.Text, out string currentPassError))
            {
                InputValidator.ShowValidationError($"Contraseña actual: {currentPassError}");
                return;
            }

            // Validar que las contraseñas sean diferentes
            if (textBox1.Text == textBox2.Text)
            {
                InputValidator.ShowValidationError("La nueva contraseña debe ser diferente a la actual");
                return;
            }

            try
            {
                AdministracionUsuarios.CambiarContraseña(textBox1.Text, textBox2.Text);
                // El método ya muestra su propio mensaje de éxito o error
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}