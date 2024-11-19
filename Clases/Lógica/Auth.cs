using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas.Clases;
using static Practicas.Clases.Modelos;

namespace Practicas.Clases.Lógica
{
    internal class Auth
    {
        // Por ahora, lo único que hace esta clase es intermediar entre la base de datos y los formularios
        // No realiza ningun tipo de autenticación real 
        public static (bool, int?) VerificarCredenciales(string usuario, string contraseña)
        {
            // vulnerable a inyección sql
            string consulta = $"SELECT usr_id FROM Usuarios WHERE nombre = \"{usuario}\" AND contraseña = \"{contraseña}\"";
            (bool, int?) response = Database.Usuarios.RevisarLogin(consulta);
            return response;
        }

        public static string LeerRol(int id)
        {
            string consulta = $"SELECT rol FROM Usuarios WHERE usr_id = {id}";
            return Database.Usuarios.LeerValor(consulta);
        }
    }
}
