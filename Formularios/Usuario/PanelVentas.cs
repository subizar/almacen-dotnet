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
            label1.Text = Auth.LeerRol(1);
        }
    }
}
