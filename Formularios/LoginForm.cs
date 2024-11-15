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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form next = new LostPasswordForm();
            this.Visible = false;
            next.ShowDialog();
            this.Visible = true;
            
        }

    }
}
