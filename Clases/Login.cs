using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Clases
{
    internal class Login
    {
        static string cadena = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=|DataDirectory|Database11.ACCDB";

        public bool login(string username, string password)
        {
            if (username == null || password == null || username == "" || password == "")
            {
                return false;

            }
            OleDbConnection conexion = new OleDbConnection(Login.cadena);
            string consultaverificarlogin = $"SELECT Count(*) FROM Usuarios WHERE N_usr = @username AND contraseña = @password";
            OleDbCommand verificarlogin = new OleDbCommand(consultaverificarlogin, conexion);

            using (verificarlogin)
            {
                verificarlogin.Parameters.AddWithValue("@username", username);
                verificarlogin.Parameters.AddWithValue("@password", password);

                try
                {
                    conexion.Open();
                    int count = Convert.ToInt32(verificarlogin.ExecuteScalar());
                    if (count > 0) {
                        MessageBox.Show("Inicio de sesión exitoso");
                        return true;
                    } else {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                        return false; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
