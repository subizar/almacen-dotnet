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
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}
