using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Formularios.Admin
{
    public partial class PanelUsuarios : Form
    {
        public PanelUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form frm = new ABMs.AgregarUsuario();
            this.Enabled = false;
            frm.ShowDialog();
            //recargamos el datagridview para reflejar los cambios
            datagridUsuarios.DataSource = Clases.Lógica.AdministracionUsuarios.LeerUsuarios();
            this.Enabled = true;
        }

        private void PanelUsuarios_Load(object sender, EventArgs e)
        {

            //POR HACER: Mover esto a un metodo aparte, generico para todos los formularios
            datagridUsuarios.AutoGenerateColumns = false;
            datagridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //solo poder seleccionar filas completas
            DataGridViewTextBoxColumn id_column = new DataGridViewTextBoxColumn();
            id_column.DataPropertyName = "id";
            id_column.HeaderText = "ID";
            id_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn name_column = new DataGridViewTextBoxColumn();
            name_column.DataPropertyName = "name";
            name_column.HeaderText="Nombre";
            name_column.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn role_column = new DataGridViewTextBoxColumn();
            role_column.DataPropertyName = "role";
            role_column.HeaderText = "Rol";
            role_column.CellTemplate = new DataGridViewTextBoxCell();

            datagridUsuarios.Columns.Add(id_column);
            datagridUsuarios.Columns.Add(name_column);
            datagridUsuarios.Columns.Add(role_column);
            //recibimos la List<Usuario>
            datagridUsuarios.DataSource = Clases.Lógica.AdministracionUsuarios.LeerUsuarios();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Form frm = new ABMs.FiltrarUsuario();
            this.Enabled = false;
            frm.ShowDialog();
            datagridUsuarios.DataSource = Practicas.State.filtro_usuario_response;
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridUsuarios.DataSource = Clases.Lógica.AdministracionUsuarios.LeerUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Practicas.State.id_editar_usuario = Convert.ToInt32(datagridUsuarios.CurrentRow.Cells[0].Value); //conseguir id de la fila seleccionada
            Form frm = new ABMs.EditarUsuario();
            this.Enabled = false;
            frm.ShowDialog();
            datagridUsuarios.DataSource = Clases.Lógica.AdministracionUsuarios.LeerUsuarios();
            this.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Practicas.State.id_editar_usuario = Convert.ToInt32(datagridUsuarios.CurrentRow.Cells[0].Value);
            var confirmar = MessageBox.Show("Seguro que querés eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes && Practicas.State.id_editar_usuario != 0)
            {
                Clases.Lógica.AdministracionUsuarios.EliminarUsuario(Practicas.State.id_editar_usuario);

            }
            datagridUsuarios.DataSource = Clases.Lógica.AdministracionUsuarios.LeerUsuarios();
        }
    }
}
