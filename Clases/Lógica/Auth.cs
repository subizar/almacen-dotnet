using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas.Clases;

namespace Practicas.Clases.Lógica
{
    internal class Auth
    {
        // Por ahora, lo único que hace esta clase es intermediar entre la base de datos y los formularios
        // No realiza ningun tipo de autenticación real 
        public static bool VerificarCredenciales(string usuario, string contraseña)
        {
            // vulnerable a inyección sql
            string consulta = $"SELECT Count(*) FROM Usuarios WHERE nombre = \"{usuario}\" AND contraseña = \"{contraseña}\"";
            return Database.Usuarios.RevisarLogin(consulta);
        }
    }
}
