using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Formularios.Admin.ABMs;

namespace Practicas.Formularios.Usuario
{
    public partial class PanelProductos : Form
    {
        public PanelProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form frm = new AgregarProducto();
            this.Enabled = false;
            frm.ShowDialog();
            datagridProductos.DataSource = Clases.Lógica.AdministracionProductos.LeerProductos();
            this.Enabled = true;

        }

        private void PanelProductos_Load(object sender, EventArgs e)
        {
            datagridProductos.AutoGenerateColumns = false;
            datagridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //solo poder seleccionar filas completas
            DataGridViewTextBoxColumn id_column = new DataGridViewTextBoxColumn();
            id_column.DataPropertyName = "id";
            id_column.HeaderText = "ID";
            id_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn name_column = new DataGridViewTextBoxColumn();
            name_column.DataPropertyName = "name";
            name_column.HeaderText = "Nombre";
            name_column.Width = 200;
            name_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn precio_column = new DataGridViewTextBoxColumn();
            precio_column.DataPropertyName = "price";
            precio_column.HeaderText = "Precio";
            precio_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn stock_column = new DataGridViewTextBoxColumn();
            stock_column.DataPropertyName = "stock";
            stock_column.HeaderText = "Stock";
            stock_column.CellTemplate = new DataGridViewTextBoxCell();

            datagridProductos.Columns.Add(id_column);
            datagridProductos.Columns.Add(name_column);
            datagridProductos.Columns.Add(precio_column);
            datagridProductos.Columns.Add(stock_column);
            //recibimos la List<Usuario>
            datagridProductos.DataSource = Clases.Lógica.AdministracionProductos.LeerProductos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Form frm = new FiltrarProducto();
            this.Enabled = false;
            frm.ShowDialog();
            datagridProductos.DataSource = Practicas.State.filtro_producto_response;
            this.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Practicas.State.id_editar_producto = Convert.ToInt32(datagridProductos.CurrentRow.Cells[0].Value);
            Form frm = new EditarProducto();
            this.Enabled = false;
            frm.ShowDialog();
            datagridProductos.DataSource = Clases.Lógica.AdministracionProductos.LeerProductos();
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridProductos.DataSource = Clases.Lógica.AdministracionProductos.LeerProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Practicas.State.id_editar_producto = Convert.ToInt32(datagridProductos.CurrentRow.Cells[0].Value);
            var confirmar = MessageBox.Show("Seguro que querés eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes && Practicas.State.id_editar_producto != 0)
            {
                Clases.Lógica.AdministracionProductos.EliminarProducto(Practicas.State.id_editar_producto);

            }
            datagridProductos.DataSource = Clases.Lógica.AdministracionProductos.LeerProductos();
        }
    }
    }

