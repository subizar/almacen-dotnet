namespace Practicas.Formularios.Usuario
{
    partial class Menu
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabVistaCajero = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVentas);
            this.tabControl.Controls.Add(this.tabProductos);
            this.tabControl.Controls.Add(this.tabVistaCajero);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(700, 350);
            this.tabControl.TabIndex = 0;
            // 
            // tabVentas
            // 
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(692, 324);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // tabProductos
            // 
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(692, 324);
            this.tabProductos.TabIndex = 1;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // tabVistaCajero
            // 
            this.tabVistaCajero.Location = new System.Drawing.Point(4, 22);
            this.tabVistaCajero.Name = "tabVistaCajero";
            this.tabVistaCajero.Size = new System.Drawing.Size(692, 324);
            this.tabVistaCajero.TabIndex = 2;
            this.tabVistaCajero.Text = "Caja";
            this.tabVistaCajero.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 348);
            this.Controls.Add(this.tabControl);
            this.Name = "Menu";
            this.Text = "VistaNoticias";
            this.Load += new System.EventHandler(this.VistaNoticias_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabVistaCajero;
    }
}