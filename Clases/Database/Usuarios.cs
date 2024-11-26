using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Practicas.Clases;
namespace Practicas.Clases.Database
{
    internal class Usuarios : Conexion
    {
        public static (bool, int?) RevisarLogin(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            int response = Convert.ToInt32(comando.ExecuteScalar());
            CerrarConexion();
            if ( response > 0)
            {
                return (true, response);
            }
            else
            {
                return (false, null);
            }

        }

        public static void CrearUsuario(string consulta)
        {
            // si sobra tiempo, devolver mensajes de error si algo sale mal.
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public static void EditarUsuario(string consulta)
        {
            //ahora mismo es igual que la funcion de crear usuario, pero si implementamos
            //errores u otras funciones es bueno tenerlos por separado
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public static List<Modelos.Usuario> LeerUsuarios(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            List<Modelos.Usuario> usuarios = new List<Modelos.Usuario>(); //nueva lista vacia
            AbrirConexion();
            OleDbDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //por cada row que lee el reader, agregamos a la lista las columnas que nos interesan
                //dentro del parentesis de usuarios.add estamos creando una nueva instancia del modelo Usuario y pasandole los valores necesarios al constructor
                usuarios.Add(new Modelos.Usuario(Convert.ToInt32(reader["usr_id"]), reader["nombre"].ToString(), reader["rol"].ToString()));
            }
            CerrarConexion();
            return usuarios;
        }

    }
}
