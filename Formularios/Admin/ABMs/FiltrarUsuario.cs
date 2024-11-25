using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas;

namespace Practicas.Formularios.Admin.ABMs
{
    public partial class FiltrarUsuario : Form
    {
        private string filtroSeleccion;
        private bool exacto;
        public List<Clases.Modelos.Usuario> response;
        public FiltrarUsuario()
        {
            InitializeComponent();
        }

        private void cmbPropiedadFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPropiedadFiltro.Text) //switch para que los strings para la consulta estén corectos
            {
                case "ID": filtroSeleccion = "usr_id"; break;
                case "Nombre": filtroSeleccion = "nombre"; break;
                case "Rol": filtroSeleccion = "rol"; break;
                default:
                    break;
            }
        }

        private void FiltrarUsuario_Load(object sender, EventArgs e)
        {
            cmbPropiedadFiltro.SelectedIndex = 0;
            cboxTextoExacto.Checked = false;
            exacto = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //POR HACER: Validacion
            Practicas.State.filtro_usuario_response = Clases.Lógica.AdministracionUsuarios.LeerUsuarios(filtroSeleccion, txtFiltro.Text, exacto);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            exacto = cboxTextoExacto.Checked;
        }
    }
}
