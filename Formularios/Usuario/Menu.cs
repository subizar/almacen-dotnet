using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Formularios.Usuario
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void VistaNoticias_Load(object sender, EventArgs e) //nombre viejo de el formulario
        {
            Form frmPanelVentas = prepareTab(new PanelVentas());
            tabVentas.Controls.Add(frmPanelVentas);
            Form frmPanelProductos = prepareTab(new PanelProductos());
            tabProductos.Controls.Add(frmPanelProductos);
            Form frmVistaCajero = prepareTab(new VistaCajero());
            tabVistaCajero.Controls.Add(frmVistaCajero);
        }

        private Form prepareTab(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Visible = true;
            return frm;
        }
    }
}
