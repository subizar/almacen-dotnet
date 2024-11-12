namespace Practicas.Formularios
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(48, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(48, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(48, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 197);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
    }
}