using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Formularios;

namespace Practicas.Formularios.Admin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Form frmPanelVentas = prepareTab(new Usuario.PanelVentas());
            tabVentas.Controls.Add(frmPanelVentas);
            Form frmPanelProductos = prepareTab(new Usuario.PanelProductos());
            tabProductos.Controls.Add(frmPanelProductos);
            Form frmVistaCajero = prepareTab(new Usuario.VistaCajero());
            tabCaja.Controls.Add(frmVistaCajero);
            Form frmVistaUsuarios = prepareTab(new Admin.PanelUsuarios());
            tabUsuarios.Controls.Add(frmVistaUsuarios);
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
