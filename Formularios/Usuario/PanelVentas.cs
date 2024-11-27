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

namespace Practicas.Formularios.Usuario
{
    public partial class PanelVentas : Form
    {
        public PanelVentas()
        {
            InitializeComponent();
        }

        private void PanelVentas_Load(object sender, EventArgs e)
        {
            datagridVentas.AutoGenerateColumns = false;
            datagridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //solo poder seleccionar filas completas
            DataGridViewTextBoxColumn id_column = new DataGridViewTextBoxColumn();
            id_column.DataPropertyName = "id";
            id_column.HeaderText = "ID";
            id_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn id_caja_column = new DataGridViewTextBoxColumn();
            id_caja_column.DataPropertyName = "id_cajero";
            id_caja_column.HeaderText = "ID Cajero";
            id_caja_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn total_column = new DataGridViewTextBoxColumn();
            total_column.DataPropertyName = "total";
            total_column.HeaderText = "Precio Total";
            total_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn fecha_column = new DataGridViewTextBoxColumn();
            fecha_column.DataPropertyName = "fecha";
            fecha_column.HeaderText = "Fecha";
            fecha_column.CellTemplate = new DataGridViewTextBoxCell();

            datagridVentas.Columns.Add(id_column);
            datagridVentas.Columns.Add(id_caja_column);
            datagridVentas.Columns.Add(total_column);
            datagridVentas.Columns.Add(fecha_column);
            //recibimos la List<Usuario>
            datagridVentas.DataSource = Clases.Lógica.AdministracionVentas.LeerVentas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Practicas.State.id_editar_venta = Convert.ToInt32(datagridVentas.CurrentRow.Cells[0].Value);
            var confirmar = MessageBox.Show("Seguro que querés eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes && Practicas.State.id_editar_venta != 0)
            {
                Clases.Lógica.AdministracionVentas.EliminarVenta(Practicas.State.id_editar_venta);

            }
            datagridVentas.DataSource = Clases.Lógica.AdministracionVentas.LeerVentas();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            datagridVentas.DataSource = Clases.Lógica.AdministracionVentas.LeerVentas();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
