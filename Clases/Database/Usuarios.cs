using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Clases;

namespace Practicas.Clases.Database
{
    internal class Usuarios : Conexion
    {
        public static bool RevisarLogin(string consulta)
        {
            OleDbCommand comando = new OleDbCommand(consulta, GetConexion());
            AbrirConexion();
            int response = Convert.ToInt32(comando.ExecuteScalar());
            CerrarConexion();
            if ( response > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
