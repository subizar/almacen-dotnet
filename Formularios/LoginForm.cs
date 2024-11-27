using System;
using System.Windows.Forms;
using Practicas.Clases.Lógica;

namespace Practicas.Formularios
{
    public partial class LoginForm : Form
    {
        public string role;
        public LoginForm()
        {
            InitializeComponent();

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {


            (bool, int?) credenciales = Auth.VerificarCredenciales(txtEmail.Text, txtPassword.Text);
            if (credenciales.Item1)
            {

                State.user_id = AdministracionUsuarios.BuscarId(txtEmail.Text);
                State.user_name = txtEmail.Text;
                State.user_password = txtPassword.Text;
                State.user_role = Auth.LeerRol((int)credenciales.Item2);
                bool prueba = AdministracionUsuarios.primerIngreso(State.user_id);
                if (prueba == true)
                {
                    Form next = new PrimerIngreso();
                    this.Visible = false;
                    next.ShowDialog();
                    this.Visible = true;
                    this.DialogResult = DialogResult.OK;
                    if (credenciales.Item2.HasValue)
                    {
                        State.user_role = Clases.Lógica.Auth.LeerRol((int)credenciales.Item2);
                        State.user_id = (int)credenciales.Item2;
                    }
                    this.Close();
                }
                else
                {



                    this.DialogResult = DialogResult.OK;
                    if (credenciales.Item2.HasValue)
                    {
                        State.user_role = Clases.Lógica.Auth.LeerRol((int)credenciales.Item2);
                        State.user_id = (int)credenciales.Item2;
                    }
                    this.Close();
                }
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form next = new LostPasswordForm();
            this.Visible = false;
            next.ShowDialog();
            this.Visible = true;
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
