namespace Practicas.Formularios.Admin.ABMs
{
    partial class EditarProducto
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboxPrecio = new System.Windows.Forms.CheckBox();
            this.cboxNombre = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(143, 105);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(69, 22);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // cboxPrecio
            // 
            this.cboxPrecio.AutoSize = true;
            this.cboxPrecio.Location = new System.Drawing.Point(143, 68);
            this.cboxPrecio.Name = "cboxPrecio";
            this.cboxPrecio.Size = new System.Drawing.Size(64, 17);
            this.cboxPrecio.TabIndex = 19;
            this.cboxPrecio.Text = "Editable";
            this.cboxPrecio.UseVisualStyleBackColor = true;
            this.cboxPrecio.CheckedChanged += new System.EventHandler(this.cboxPrecio_CheckedChanged);
            // 
            // cboxNombre
            // 
            this.cboxNombre.AutoSize = true;
            this.cboxNombre.Location = new System.Drawing.Point(143, 28);
            this.cboxNombre.Name = "cboxNombre";
            this.cboxNombre.Size = new System.Drawing.Size(64, 17);
            this.cboxNombre.TabIndex = 18;
            this.cboxNombre.Text = "Editable";
            this.cboxNombre.UseVisualStyleBackColor = true;
            this.cboxNombre.CheckedChanged += new System.EventHandler(this.cboxNombre_CheckedChanged_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(16, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 36);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(16, 65);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(16, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 137);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cboxPrecio);
            this.Controls.Add(this.cboxNombre);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Name = "EditarProducto";
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox cboxPrecio;
        private System.Windows.Forms.CheckBox cboxNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
    }
}