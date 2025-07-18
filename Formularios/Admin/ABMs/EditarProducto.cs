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
using Practicas.Clases.Lógica;
using static Practicas.Clases.Modelos;

namespace Practicas.Formularios.Admin.ABMs
{
    public partial class EditarProducto : Form
    {
        private Modelos.Producto producto_edit;
        public Modelos.Producto producto_base; // perdon profe
        public EditarProducto()
        {
            InitializeComponent();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            Modelos.Producto response = Clases.Lógica.AdministracionProductos.LeerProductos("producto_id", State.id_editar_producto.ToString(), true)[0];
            producto_edit = producto_base = response;         

            txtNombre.Text = producto_base.name;
            txtPrecio.Text = producto_base.price.ToString();
            txtStock.Text = producto_base.stock.ToString();
        }


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
                producto_edit.name = producto_base.name;
            }
            else
            {
                if (InputValidator.ValidateProductName(txtNombre.Text, out string nameError))
                {
                    producto_edit.name = txtNombre.Text;
                }
                else
                {
                    InputValidator.ShowValidationError(nameError);
                    return;
                }
            }

            //PRECIO
            txtPrecio.Enabled = cboxPrecio.Checked;
            if (txtPrecio.Enabled == false)
            {
                producto_edit.price = producto_base.price;
            }
            else
            {
                if (InputValidator.ValidatePrice(txtPrecio.Text, out int precio, out string priceError))
                {
                    producto_edit.price = precio;
                }
                else
                {
                    InputValidator.ShowValidationError(priceError);
                    return;
                }
            }
            
            txtStock.Enabled = cmbStock.Enabled;
            if (txtStock.Enabled == false)
            {
                producto_edit.stock = producto_base.stock;
            } else
            {
                if (InputValidator.ValidateStock(txtStock.Text, out int stock, out string stockError))
                {
                    producto_edit.stock = stock;
                }
                else
                {
                    InputValidator.ShowValidationError(stockError);
                    return;
                }
            }
        }

        

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Revalidar();
                Clases.Lógica.AdministracionProductos.EditarProducto(producto_edit);
                InputValidator.ShowSuccessMessage("Producto actualizado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxNombre_CheckedChanged_1(object sender, EventArgs e) { Revalidar(); }

        private void cboxPrecio_CheckedChanged(object sender, EventArgs e) { Revalidar(); }

        private void EditarProducto_Load_1(object sender, EventArgs e)
        {

        }

        private void cmbStock_CheckedChanged(object sender, EventArgs e) { Revalidar(); }
    }
}
