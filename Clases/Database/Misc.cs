using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases.Database
{
    internal class Misc : Conexion
    {
        public static string LeerValor(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            string response = comando.ExecuteScalar().ToString();
            CerrarConexion();
            return response;
        }
    }
}
