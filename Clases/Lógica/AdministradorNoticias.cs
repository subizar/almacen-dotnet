using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Clases.Database;
using Practicas.Formularios.Admin;

namespace Practicas.Clases.Lógica
{
    internal class AdministradorNoticias
    {
        public static void AgregarNoticia(string titulo , string desarrollo)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string consulta = $"INSERT INTO Noticias (titulo, texto, fecha) VALUES ('{titulo}', '{desarrollo}', #{fecha}#)";
            Database.Noticias.AgregarNoticia(consulta);
        }

        public static void LeerNoticia(RichTextBox texto)
        {
            
            string consulta = "SELECT titulo , texto , fecha FROM Noticias";
            OleDbCommand comando = new OleDbCommand(consulta, Conexion.GetConexion());
            Conexion.AbrirConexion();
            OleDbDataReader lector = comando.ExecuteReader();            
            Noticias.LeerNoticias(lector, texto);
            Conexion.CerrarConexion();
        }
        public static void CargarTitulos(ComboBox comboBox)
        {
            string consulta = "SELECT titulo FROM Noticias";

            using (OleDbCommand comando = new OleDbCommand(consulta, Conexion.GetConexion()))
            {
                try
                {
                    Conexion.AbrirConexion();
                    OleDbDataReader lector = comando.ExecuteReader();
                    Noticias.AgregarTitulos(lector, comboBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los títulos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conexion.CerrarConexion();
                }
            }
        }

        public static void CargarNoticiaSeleccionada(string tituloSeleccionado, TextBox textBoxTitulo, RichTextBox richTextBoxTexto)
        {
            // Concatenar la consulta SQL para obtener el título y el desarrollo
            string consulta = $"SELECT titulo, texto FROM Noticias WHERE titulo = '{tituloSeleccionado}'";

            using (OleDbCommand comando = new OleDbCommand(consulta, Conexion.GetConexion()))
            {
                try
                {
                    Conexion.AbrirConexion();

                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        Noticias.MostrarNoticia(lector, textBoxTitulo, richTextBoxTexto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la noticia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conexion.CerrarConexion();
                }
            }
        }
        public static int BuscarId(string titulo)
        {
            string consulta = $"SELECT noticia_id FROM Noticias WHERE titulo = '{titulo}'";
            int id = Noticias.BuscarIdNoticia(consulta);
            return id;
        }

        public static void CambiarNoticia(string Titulo, string texto,int id)
        {

            string consulta = $"UPDATE Noticias SET titulo = '{Titulo}' , texto = '{texto}' WHERE noticia_id ={id}";
            Noticias.CambiarNoticia(consulta);
            MessageBox.Show("Noticia actualizada con exito");
        }


        public static void EliminarNoticia(int id)
        {
            string consulta = "";
            if (id != 0)
            {
                consulta = $"DELETE FROM Noticias WHERE noticia_id = {id}";
                Database.Noticias.EliminarNoticia(consulta);
                MessageBox.Show("Noticia eliminada");
            }
            
        }


    }
}
