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

namespace Practicas.Formularios
{
    public partial class PrimerIngreso : Form
    {
        public PrimerIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar nueva contraseña
            if (!InputValidator.ValidatePassword(textBox1.Text, out string passError))
            {
                InputValidator.ShowValidationError(passError);
                return;
            }

            try
            {
                AdministracionUsuarios.CambiarContraseñaMail(textBox1.Text, State.user_name);
                InputValidator.ShowSuccessMessage("Contraseña actualizada exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
