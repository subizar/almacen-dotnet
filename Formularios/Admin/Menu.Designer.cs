﻿namespace Practicas.Formularios.Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCaja = new System.Windows.Forms.TabPage();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabNoticias = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCaja);
            this.tabControl1.Controls.Add(this.tabVentas);
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Controls.Add(this.tabNoticias);
            this.tabControl1.Controls.Add(this.tabUsuarios);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCaja
            // 
            this.tabCaja.Location = new System.Drawing.Point(4, 22);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Size = new System.Drawing.Size(692, 322);
            this.tabCaja.TabIndex = 6;
            this.tabCaja.Text = "Caja";
            this.tabCaja.UseVisualStyleBackColor = true;
            // 
            // tabVentas
            // 
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Size = new System.Drawing.Size(692, 322);
            this.tabVentas.TabIndex = 3;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // tabProductos
            // 
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(692, 322);
            this.tabProductos.TabIndex = 4;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // tabNoticias
            // 
            this.tabNoticias.Location = new System.Drawing.Point(4, 22);
            this.tabNoticias.Name = "tabNoticias";
            this.tabNoticias.Size = new System.Drawing.Size(692, 322);
            this.tabNoticias.TabIndex = 7;
            this.tabNoticias.Text = "Noticias";
            this.tabNoticias.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cerrar Sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Configuracion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(692, 322);
            this.tabUsuarios.TabIndex = 8;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabCaja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabNoticias;
        private System.Windows.Forms.TabPage tabUsuarios;
    }
}