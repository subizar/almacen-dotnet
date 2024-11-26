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
                producto_edit.name = txtNombre.Text;
            }

            //CONTRASEÑA
            txtPrecio.Enabled = cboxPrecio.Checked;
            if (txtPrecio.Enabled == false)
            {
                producto_edit.price = producto_base.price;
            }
            else
            {
                producto_edit.price = Convert.ToDouble(txtPrecio.Text);
            }
            
           
        }

        

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Revalidar();
            Clases.Lógica.AdministracionProductos.EditarProducto(producto_edit);
            this.Close();
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
    }
}
