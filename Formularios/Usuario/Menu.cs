using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Formularios.Config;

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
            Form frmVistaNoticias = prepareTab(new VistaNoticias());
            tabNoticias.Controls.Add(frmVistaNoticias);
        }

        private Form prepareTab(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Visible = true;
            return frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form next = new Configuracion();
            this.Visible = false;
            next.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form next = new CerrarSesion();
            this.Visible = false;
            next.ShowDialog();
            try
            {
                this.Visible = true;

            }
            catch (Exception)
            {

            }
        }
    }
}
