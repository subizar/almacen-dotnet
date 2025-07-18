using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases.Database
{
    internal class Conexion
    {
        private static string cadena = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=|DataDirectory|db2.accdb";
        private static OleDbConnection conexion = new OleDbConnection(cadena);
        public static void AbrirConexion() 
        { 
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    conexion.Close();
                    conexion.Open();
                }
                catch (Exception ex2)
                {
                    throw new Exception($"Error al conectar con la base de datos: {ex2.Message}", ex2);
                }
            }
        }

        public static void CerrarConexion() 
        { 
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                // Log the error but don't throw, as we're trying to close
                System.Diagnostics.Debug.WriteLine($"Error al cerrar conexión: {ex.Message}");
            }
        }

        public static OleDbConnection GetConexion() { return conexion; }
    }
}
