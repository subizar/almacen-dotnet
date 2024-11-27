using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Formularios.Admin;

namespace Practicas.Clases.Database
{
    internal class Noticias:Conexion
    {
        public static void AgregarNoticia(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
        public static void LeerNoticias(OleDbDataReader lector , RichTextBox richTextBox)
        {
            
                while (lector.Read())
                {
                    // Obtener datos de cada noticia
                    string titulo = lector["titulo"].ToString();
                    DateTime fecha = Convert.ToDateTime(lector["fecha"]);
                    string desarrollo = lector["texto"].ToString();

                richTextBox.SelectionStart = richTextBox.TextLength;
                richTextBox.SelectionColor = Color.DarkBlue;
                richTextBox.AppendText($"Título: {titulo}\n");

                // Agregar la fecha con formato
                richTextBox.SelectionStart = richTextBox.TextLength;
                richTextBox.SelectionColor = Color.Gray;
                richTextBox.AppendText($"Fecha: {fecha:dd/MM/yyyy}\n");

                // Agregar el desarrollo con formato
                richTextBox.SelectionStart = richTextBox.TextLength;
                richTextBox.SelectionColor = Color.Black;
                richTextBox.AppendText($"{desarrollo}\n\n");

                // Restablecer el color por defecto
                richTextBox.SelectionColor = richTextBox.ForeColor;
            }
            
        }


        public static void MostrarNoticia(OleDbDataReader lector, TextBox textBoxTitulo, RichTextBox richTextBoxTexto)
        {
            if (lector.Read())
            {
                // Asignar el título al TextBox
                textBoxTitulo.Text = lector["titulo"].ToString();

                // Asignar el desarrollo al RichTextBox
                richTextBoxTexto.Clear();  // Limpiar el contenido previo
                richTextBoxTexto.AppendText(lector["texto"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontró la noticia seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void AgregarTitulos(OleDbDataReader lector, ComboBox comboBox)
        {
            

            while (lector.Read())
            {
                // Obtener y agregar cada título al ComboBox
                string titulo = lector["titulo"].ToString();
                comboBox.Items.Add(titulo);
            }
        }

        public static void CambiarNoticia(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
             comando.ExecuteNonQuery();
            CerrarConexion();
            
        }
        public static int BuscarIdNoticia(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            int id =  Convert.ToInt32(comando.ExecuteScalar());
            CerrarConexion();
            return id;
        }
        public static void EliminarNoticia(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }

}

