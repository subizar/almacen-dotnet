using Practicas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practicas
{
    public partial class loginForm : Form
    {
        Login l = new Login();
        string usuario;
        string contraseña;


        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (l.login(usuario, contraseña))
            {
                this.Hide();
                Form menu = new Menu();
                menu.Show(this);
            }
            
        }

        private void controlartexto() {
            if (txtPass.Text == null || txtUser.Text == null || txtPass.Text == "" || txtUser.Text == "")
            {
                btnLogin.Enabled = false;
            }
            else {
                btnLogin.Enabled = true;
                usuario = txtUser.Text;
                contraseña = txtPass.Text;
            }
        }


        static bool controlartexto(TextBox T1, TextBox T2)
        {
          
            if (T1.Text == null || T2.Text == null || T1.Text == "" || T2.Text == "")
            {
               
               return  false;
            }
            else
            {

                return  true;
            }
           
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlartexto();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            controlartexto();
        }
    }
}
