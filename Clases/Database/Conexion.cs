using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases.Database
{
    internal class Conexion
    {
        private static string cadena = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=|DataDirectory|db.accdb";
        private static OleDbConnection conexion = new OleDbConnection(cadena);
        public static void AbrirConexion() { conexion.Open(); }

        public static void CerrarConexion() { conexion.Close(); }

        public static OleDbConnection GetConexion() { return conexion; }
    }
}
