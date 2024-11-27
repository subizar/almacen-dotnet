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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Lógica.Misc.Mandar_Mail(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == AdministracionUsuarios.BuscarContraseña(textBox1.Text))
            {
                (bool, int?) credenciales = Auth.VerificarCredenciales(textBox1.Text, textBox2.Text);
                if (credenciales.Item1)
                {
                    State.user_id = AdministracionUsuarios.BuscarId(textBox1.Text);
                    State.user_name = textBox1.Text;
                    State.user_password = textBox2.Text;
                    State.user_role = Auth.LeerRol((int)credenciales.Item2);
                    if (credenciales.Item2.HasValue)
                    {
                        switch (State.user_role)
                        {
                            case "Usuario":
                                Form next = new Usuario.Menu();
                                this.Visible = false;
                                next.ShowDialog();
                                this.Visible = true;
                                break;
                            case "Admin":
                                Form next1 = new Admin.Menu();
                                this.Visible = false;
                                next1.ShowDialog();
                                this.Visible = true;
                                break;
                        }
                    }
                    this.Visible = true;
                }
            }
        }
    }
}
