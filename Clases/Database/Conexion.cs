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
        private string cadena = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=|DataDirectory|Database11.ACCDB";
        private OleDbConnection conexion;
        public OleDbConnection Abrir()
        {
            conexion = new OleDbConnection(cadena);
            return conexion;
        }

        public void Cerrar()
        {
            conexion.Close();
        }
    }
}
