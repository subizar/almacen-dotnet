using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases.Database
{
    internal class Productos : Conexion
    {
        public static void AgregarProducto(string consulta) 
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public static void EditarProducto(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public static void EliminarProducto(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public static List<Modelos.Producto> LeerProductos(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            List<Modelos.Producto> productos = new List<Modelos.Producto>(); //nueva lista vacia
            AbrirConexion();
            OleDbDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //por cada row que lee el reader, agregamos a la lista las columnas que nos interesan
                //dentro del parentesis de usuarios.add estamos creando una nueva instancia del modelo Usuario y pasandole los valores necesarios al constructor
                productos.Add(new Modelos.Producto(Convert.ToInt32(reader["producto_id"]), reader["nombre"].ToString(), Convert.ToInt32(reader["precio"])));
            }
            CerrarConexion();
            return productos;
        }
    }
}

