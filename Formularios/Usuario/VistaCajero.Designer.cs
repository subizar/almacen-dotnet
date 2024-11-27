namespace Practicas.Formularios.Usuario
{
    partial class VistaCajero
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
            this.lboxCarrito = new System.Windows.Forms.ListBox();
            this.lboxProductos = new System.Windows.Forms.ListBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.nmrCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtTotales = new System.Windows.Forms.RichTextBox();
            this.btnReiniciarCarrito = new System.Windows.Forms.Button();
            this.btnConfirmarCarrito = new System.Windows.Forms.Button();
            this.btnEliminarElemento = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxCarrito
            // 
            this.lboxCarrito.FormattingEnabled = true;
            this.lboxCarrito.Location = new System.Drawing.Point(344, 5);
            this.lboxCarrito.Name = "lboxCarrito";
            this.lboxCarrito.Size = new System.Drawing.Size(335, 212);
            this.lboxCarrito.TabIndex = 17;
            // 
            // lboxProductos
            // 
            this.lboxProductos.FormattingEnabled = true;
            this.lboxProductos.Location = new System.Drawing.Point(12, 12);
            this.lboxProductos.Name = "lboxProductos";
            this.lboxProductos.Size = new System.Drawing.Size(193, 264);
            this.lboxProductos.TabIndex = 18;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 289);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(163, 20);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.Location = new System.Drawing.Point(211, 225);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(127, 53);
            this.btnAñadirProducto.TabIndex = 20;
            this.btnAñadirProducto.Text = "Añadir";
            this.btnAñadirProducto.UseVisualStyleBackColor = true;
            this.btnAñadirProducto.Click += new System.EventHandler(this.btnAñadirProducto_Click);
            // 
            // nmrCantidad
            // 
            this.nmrCantidad.Location = new System.Drawing.Point(211, 199);
            this.nmrCantidad.Name = "nmrCantidad";
            this.nmrCantidad.Size = new System.Drawing.Size(127, 20);
            this.nmrCantidad.TabIndex = 21;
            this.nmrCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCantidad.ValueChanged += new System.EventHandler(this.nmrCantidad_ValueChanged);
            // 
            // txtTotales
            // 
            this.txtTotales.Location = new System.Drawing.Point(344, 225);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.Size = new System.Drawing.Size(205, 84);
            this.txtTotales.TabIndex = 22;
            this.txtTotales.Text = "Carrito vacío";
            // 
            // btnReiniciarCarrito
            // 
            this.btnReiniciarCarrito.Location = new System.Drawing.Point(555, 259);
            this.btnReiniciarCarrito.Name = "btnReiniciarCarrito";
            this.btnReiniciarCarrito.Size = new System.Drawing.Size(59, 50);
            this.btnReiniciarCarrito.TabIndex = 23;
            this.btnReiniciarCarrito.Text = "Reiniciar Carrito";
            this.btnReiniciarCarrito.UseVisualStyleBackColor = true;
            this.btnReiniciarCarrito.Click += new System.EventHandler(this.btnReiniciarCarrito_Click);
            // 
            // btnConfirmarCarrito
            // 
            this.btnConfirmarCarrito.Location = new System.Drawing.Point(620, 259);
            this.btnConfirmarCarrito.Name = "btnConfirmarCarrito";
            this.btnConfirmarCarrito.Size = new System.Drawing.Size(59, 50);
            this.btnConfirmarCarrito.TabIndex = 24;
            this.btnConfirmarCarrito.Text = "Confirmar Carrito";
            this.btnConfirmarCarrito.UseVisualStyleBackColor = true;
            this.btnConfirmarCarrito.Click += new System.EventHandler(this.btnConfirmarCarrito_Click);
            // 
            // btnEliminarElemento
            // 
            this.btnEliminarElemento.Location = new System.Drawing.Point(555, 225);
            this.btnEliminarElemento.Name = "btnEliminarElemento";
            this.btnEliminarElemento.Size = new System.Drawing.Size(124, 28);
            this.btnEliminarElemento.TabIndex = 26;
            this.btnEliminarElemento.Text = "Eliminar seleccionado";
            this.btnEliminarElemento.UseVisualStyleBackColor = true;
            this.btnEliminarElemento.Click += new System.EventHandler(this.btnEliminarElemento_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(181, 286);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(24, 23);
            this.btnReiniciar.TabIndex = 27;
            this.btnReiniciar.Text = "🗑️";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cantidad:";
            // 
            // VistaCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnEliminarElemento);
            this.Controls.Add(this.btnConfirmarCarrito);
            this.Controls.Add(this.btnReiniciarCarrito);
            this.Controls.Add(this.txtTotales);
            this.Controls.Add(this.nmrCantidad);
            this.Controls.Add(this.btnAñadirProducto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lboxProductos);
            this.Controls.Add(this.lboxCarrito);
            this.Name = "VistaCajero";
            this.Text = "VistaCajero";
            this.Load += new System.EventHandler(this.VistaCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lboxCarrito;
        private System.Windows.Forms.ListBox lboxProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.NumericUpDown nmrCantidad;
        private System.Windows.Forms.RichTextBox txtTotales;
        private System.Windows.Forms.Button btnReiniciarCarrito;
        private System.Windows.Forms.Button btnConfirmarCarrito;
        private System.Windows.Forms.Button btnEliminarElemento;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label1;
    }
}