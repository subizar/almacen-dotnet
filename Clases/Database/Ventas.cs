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
        public static void AgregarVenta(string consultaVenta, string consultaVxP)
        {
            OleDbCommand comandoVenta = new OleDbCommand(consultaVenta, GetConexion());
            OleDbCommand comandoVxP = new OleDbCommand(consultaVxP, GetConexion());
            AbrirConexion();
            comandoVenta.ExecuteNonQuery();
            comandoVxP.ExecuteNonQuery();
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


    }
}
