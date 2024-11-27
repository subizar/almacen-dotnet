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
            lboxCarrito.Items.Clear();
            productosCarrito.Add(new Modelos.ProductoEnCarrito(productosBusqueda[index], Convert.ToInt32(nmrCantidad.Value)));
            foreach (Modelos.ProductoEnCarrito producto in productosCarrito)
            {
                lboxCarrito.Items.Add($"{producto.name} - ${producto.price} x {producto.quantity}");
            }
            ActualizarVenta();
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
            if (index >= 0)
            {
                productosCarrito.RemoveAt(index);
            }
            ActualizarVenta();
            ActualizarListBoxCarrito();
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
            if (lboxCarrito.Items.Count > 0)
            {
                venta.fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                Clases.Lógica.AdministracionVentas.AgregarVenta(venta);
                reiniciarcarrito();
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
