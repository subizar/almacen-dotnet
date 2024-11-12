using System;
using System.Windows.Forms;
using Practicas.Clases.Lógica;

namespace Practicas.Formularios
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Auth.VerificarCredenciales(txtEmail.Text, txtPassword.Text))
            {
                Form next = new Usuario.PanelVentas();
                next.Show();
                this.Hide();
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form next = new LostPasswordForm();
            next.Show();
            this.Dispose();
        }

    }
}
