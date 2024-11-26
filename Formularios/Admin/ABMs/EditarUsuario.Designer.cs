namespace Practicas.Formularios.Admin.ABMs
{
    partial class EditarUsuario
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboxNombre = new System.Windows.Forms.CheckBox();
            this.cboxContraseña = new System.Windows.Forms.CheckBox();
            this.cboxRol = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(33, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Enabled = false;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cmbRol.Location = new System.Drawing.Point(33, 117);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 1;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(33, 78);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(33, 144);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 36);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cboxNombre
            // 
            this.cboxNombre.AutoSize = true;
            this.cboxNombre.Location = new System.Drawing.Point(160, 41);
            this.cboxNombre.Name = "cboxNombre";
            this.cboxNombre.Size = new System.Drawing.Size(64, 17);
            this.cboxNombre.TabIndex = 7;
            this.cboxNombre.Text = "Editable";
            this.cboxNombre.UseVisualStyleBackColor = true;
            this.cboxNombre.CheckedChanged += new System.EventHandler(this.cboxNombre_CheckedChanged);
            // 
            // cboxContraseña
            // 
            this.cboxContraseña.AutoSize = true;
            this.cboxContraseña.Location = new System.Drawing.Point(160, 81);
            this.cboxContraseña.Name = "cboxContraseña";
            this.cboxContraseña.Size = new System.Drawing.Size(64, 17);
            this.cboxContraseña.TabIndex = 8;
            this.cboxContraseña.Text = "Editable";
            this.cboxContraseña.UseVisualStyleBackColor = true;
            this.cboxContraseña.CheckedChanged += new System.EventHandler(this.cboxContraseña_CheckedChanged);
            // 
            // cboxRol
            // 
            this.cboxRol.AutoSize = true;
            this.cboxRol.Location = new System.Drawing.Point(160, 121);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Size = new System.Drawing.Size(64, 17);
            this.cboxRol.TabIndex = 9;
            this.cboxRol.Text = "Editable";
            this.cboxRol.UseVisualStyleBackColor = true;
            this.cboxRol.CheckedChanged += new System.EventHandler(this.cboxRol_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(160, 158);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(69, 22);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 190);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cboxRol);
            this.Controls.Add(this.cboxContraseña);
            this.Controls.Add(this.cboxNombre);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtNombre);
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox cboxNombre;
        private System.Windows.Forms.CheckBox cboxContraseña;
        private System.Windows.Forms.CheckBox cboxRol;
        private System.Windows.Forms.Button btnVolver;
    }
}