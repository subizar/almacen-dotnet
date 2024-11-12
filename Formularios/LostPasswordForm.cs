using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Formularios
{
    public partial class LostPasswordForm : Form
    {
        public LostPasswordForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form next = new LoginForm();
            next.Show();
            this.Dispose();
        }
    }
}
