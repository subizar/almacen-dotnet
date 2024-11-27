using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas.Formularios.Admin.ABMs;

namespace Practicas.Clases.Database
{
    internal class Ventas : Conexion
    {
        public static void AgregarVenta(string consultaVenta)
        //public static void AgregarVenta(string consultaVenta, string consultaVxP)
        {
            OleDbCommand comandoVenta = new OleDbCommand(consultaVenta, GetConexion());
            //OleDbCommand comandoVxP = new OleDbCommand(consultaVxP, GetConexion());
            AbrirConexion();
            comandoVenta.ExecuteNonQuery();
            //comandoVxP.ExecuteNonQuery();
            CerrarConexion();
        }

        public static void EliminarVenta(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public static void EditarVenta(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public static List<Modelos.Venta> LeerVenta(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            List<Modelos.Venta> ventas = new List<Modelos.Venta>();
            AbrirConexion();
            OleDbDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                ventas.Add(new Modelos.Venta(Convert.ToInt32(reader["venta_id"]), Convert.ToInt32(reader["usr_id"]), reader["fecha"].ToString(), Convert.ToDouble(reader["precio_total"])));
            }
            CerrarConexion();
            return ventas;

        }
    }
}
