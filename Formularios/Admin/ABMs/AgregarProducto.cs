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
            // Validar nombre del producto
            if (!InputValidator.ValidateProductName(txtNombre.Text, out string nameError))
            {
                InputValidator.ShowValidationError(nameError);
                return;
            }

            // Validar precio
            if (!InputValidator.ValidatePrice(txtPrecio.Text, out int precio, out string priceError))
            {
                InputValidator.ShowValidationError(priceError);
                return;
            }

            // Validar stock
            if (!InputValidator.ValidateStock(txtStock.Text, out int stock, out string stockError))
            {
                InputValidator.ShowValidationError(stockError);
                return;
            }

            // Si todas las validaciones pasan, agregar el producto
            try
            {
                AdministracionProductos.AgregarProducto(txtNombre.Text, precio, stock);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
