namespace Practicas.Formularios.Admin
{
    partial class PanelUsuarios
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
            this.datagridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridUsuarios
            // 
            this.datagridUsuarios.AllowUserToAddRows = false;
            this.datagridUsuarios.AllowUserToDeleteRows = false;
            this.datagridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUsuarios.Location = new System.Drawing.Point(122, 12);
            this.datagridUsuarios.Name = "datagridUsuarios";
            this.datagridUsuarios.ReadOnly = true;
            this.datagridUsuarios.Size = new System.Drawing.Size(557, 298);
            this.datagridUsuarios.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 29);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Registrar usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(12, 47);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(104, 29);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 117);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 29);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 29);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reiniciar Filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.datagridUsuarios);
            this.Name = "PanelUsuarios";
            this.Text = "PanelUsuarios";
            this.Load += new System.EventHandler(this.PanelUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridUsuarios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
    }
}