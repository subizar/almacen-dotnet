using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Formularios.Admin.ABMs
{
    public partial class FiltrarProducto : Form
    {
        private string filtroSeleccion;
        private bool exacto;
        public List<Clases.Modelos.Producto> response;

        public FiltrarProducto()
        {
            InitializeComponent();
        }

        private void FiltrarProducto_Load(object sender, EventArgs e)
        {
            cmbPropiedadFiltro.SelectedIndex = 0;
            cboxTextoExacto.Checked = false;
            exacto = false;
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //POR HACER: Validacion
            Practicas.State.filtro_producto_response = Clases.Lógica.AdministracionProductos.LeerProductos(filtroSeleccion, txtFiltro.Text, exacto);
            this.Close();
        }

        private void cboxTextoExacto_CheckedChanged(object sender, EventArgs e)
        {
            exacto = cboxTextoExacto.Checked;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPropiedadFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPropiedadFiltro.Text) //switch para que los strings para la consulta estén corectos
            {
                case "ID": filtroSeleccion = "producto_id"; break;
                case "Nombre": filtroSeleccion = "nombre"; break;
                case "Precio": filtroSeleccion = "precio"; break;
                default:
                    break;
            }
        }
    }
}
