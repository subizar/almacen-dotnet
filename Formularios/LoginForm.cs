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
                this.DialogResult = DialogResult.OK;
                this.role = credenciales.Item2.ToString();
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "admin";
            txtPassword.Text = "admin";
        }
    }
}
