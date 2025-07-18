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

namespace Practicas.Formularios.Usuario
{
    public partial class VistaCajero : Form
    {
        private List<Modelos.Producto> productosBusqueda;
        private List<Modelos.ProductoEnCarrito> productosCarrito = new List<Modelos.ProductoEnCarrito>();
        private Modelos.Venta venta = new Modelos.Venta();


        public VistaCajero()
        {
            InitializeComponent();
        }

        private void nmrCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nmrCantidad.Value <= 0) { nmrCantidad.Value = 1; }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                txtBuscar.Text = "";
            } else { BuscarProductos(""); }
        }

        private void BuscarProductos(string texto)
        {
            lboxProductos.Items.Clear();
            productosBusqueda = Clases.Lógica.AdministracionProductos.LeerProductos("nombre", $"%{texto}%", false);
            foreach (Modelos.Producto producto in productosBusqueda)
            {
                lboxProductos.Items.Add($"{producto.name} - ${producto.price}");
            }
        }

        private void AgregarProductoAlCarrito(int index)
        {
            // Validar que se haya seleccionado un producto válido
            if (index < 0 || index >= productosBusqueda.Count)
            {
                InputValidator.ShowValidationError("Seleccione un producto válido de la lista");
                return;
            }

            // Validar que la cantidad sea válida
            if (nmrCantidad.Value <= 0)
            {
                InputValidator.ShowValidationError("La cantidad debe ser mayor a 0");
                return;
            }

            // Validar que hay suficiente stock
            if (nmrCantidad.Value > productosBusqueda[index].stock)
            {
                InputValidator.ShowValidationError($"Stock insuficiente. Stock disponible: {productosBusqueda[index].stock}");
                return;
            }

            try
            {
                lboxCarrito.Items.Clear();
                productosCarrito.Add(new Modelos.ProductoEnCarrito(productosBusqueda[index], Convert.ToInt32(nmrCantidad.Value)));
                foreach (Modelos.ProductoEnCarrito producto in productosCarrito)
                {
                    lboxCarrito.Items.Add($"{producto.name} - ${producto.price} x {producto.quantity}");
                }
                ActualizarVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto al carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListBoxCarrito()
        {
            lboxCarrito.Items.Clear();
            foreach (Modelos.ProductoEnCarrito producto in productosCarrito)
            {
                lboxCarrito.Items.Add($"{producto.name} - ${producto.price} x {producto.quantity}");
            }
            ActualizarVenta();
        }

        private void ActualizarVenta()
        {
            venta.productos = new List<Modelos.ProductoEnCarrito>();
            venta.total = 0;
            foreach (Modelos.ProductoEnCarrito producto in productosCarrito)
            {
                venta.productos.Add(producto);
                venta.total += producto.price * producto.quantity;
            }
            venta.id_cajero = State.user_id;
            txtTotales.Text = $"Total: {venta.total} \nCajero: {Clases.Database.Misc.LeerValor($"SELECT nombre FROM Usuarios WHERE usr_id = {venta.id_cajero}")}";
        }

        private void BorrarDelCarrito(int index)
        {
            if (index < 0 || index >= productosCarrito.Count)
            {
                InputValidator.ShowValidationError("Seleccione un elemento válido del carrito para eliminar");
                return;
            }

            try
            {
                productosCarrito.RemoveAt(index);
                ActualizarVenta();
                ActualizarListBoxCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto del carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos(txtBuscar.Text);
        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito(lboxProductos.SelectedIndex);
        }

        private void VistaCajero_Load(object sender, EventArgs e)
        {
            BuscarProductos("");
        }

        private void btnEliminarElemento_Click(object sender, EventArgs e)
        {
            BorrarDelCarrito(lboxCarrito.SelectedIndex);
        }

        private void btnReiniciarCarrito_Click(object sender, EventArgs e)
        {
            reiniciarcarrito();

        }

        private void btnConfirmarCarrito_Click(object sender, EventArgs e)
        {
            if (lboxCarrito.Items.Count <= 0)
            {
                InputValidator.ShowValidationError("El carrito está vacío. Agregue productos antes de confirmar la venta");
                return;
            }

            // Validar que el usuario tenga permisos
            if (State.user_id <= 0)
            {
                InputValidator.ShowValidationError("Error de sesión. Inicie sesión nuevamente");
                return;
            }

            try
            {
                venta.fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                Clases.Lógica.AdministracionVentas.AgregarVenta(venta);
                InputValidator.ShowSuccessMessage("Venta registrada exitosamente");
                reiniciarcarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reiniciarcarrito()
        {
            productosCarrito.Clear();
            venta = new Modelos.Venta();
            ActualizarVenta();
            ActualizarListBoxCarrito();
            txtTotales.Text = "Carrito vacío";
        }
    }
}
