namespace Practicas.Formularios.Admin.ABMs
{
    partial class FiltrarProducto
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
            this.cboxTextoExacto = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbPropiedadFiltro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxTextoExacto
            // 
            this.cboxTextoExacto.AutoSize = true;
            this.cboxTextoExacto.Location = new System.Drawing.Point(158, 56);
            this.cboxTextoExacto.Name = "cboxTextoExacto";
            this.cboxTextoExacto.Size = new System.Drawing.Size(112, 17);
            this.cboxTextoExacto.TabIndex = 11;
            this.cboxTextoExacto.Text = "Filtrar texto exacto";
            this.cboxTextoExacto.UseVisualStyleBackColor = true;
            this.cboxTextoExacto.CheckedChanged += new System.EventHandler(this.cboxTextoExacto_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(205, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(61, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar por:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(12, 52);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(140, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 30);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(140, 20);
            this.txtFiltro.TabIndex = 7;
            // 
            // cmbPropiedadFiltro
            // 
            this.cmbPropiedadFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropiedadFiltro.FormattingEnabled = true;
            this.cmbPropiedadFiltro.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Precio"});
            this.cmbPropiedadFiltro.Location = new System.Drawing.Point(158, 29);
            this.cmbPropiedadFiltro.Name = "cmbPropiedadFiltro";
            this.cmbPropiedadFiltro.Size = new System.Drawing.Size(108, 21);
            this.cmbPropiedadFiltro.TabIndex = 6;
            this.cmbPropiedadFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbPropiedadFiltro_SelectedIndexChanged);
            // 
            // FiltrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 80);
            this.Controls.Add(this.cboxTextoExacto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbPropiedadFiltro);
            this.Name = "FiltrarProducto";
            this.Text = "FiltrarProducto";
            this.Load += new System.EventHandler(this.FiltrarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxTextoExacto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbPropiedadFiltro;
    }
}