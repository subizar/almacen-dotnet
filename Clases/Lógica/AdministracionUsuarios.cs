using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practicas.Clases.Modelos;

namespace Practicas.Clases.Lógica
{
    internal class AdministracionUsuarios
    {
        public static List<Usuario> LeerUsuarios()
        {
            string consulta = $"SELECT usr_id, nombre, rol FROM Usuarios";
            return Database.Usuarios.LeerUsuarios(consulta);
        }

        public static List<Usuario> LeerUsuarios(string filtro, string textofiltro, bool exact)
        {
            string consulta = $"SELECT usr_id, nombre, rol FROM Usuarios WHERE {filtro} LIKE \"{textofiltro}\"";
            return Database.Usuarios.LeerUsuarios(consulta);
        }

        public static void CrearUsuario(string name, string rol, string contraseña)
        {
            //falta validacion del input
            string consulta = $"INSERT INTO Usuarios (nombre, contraseña, rol) VALUES  (\"{name}\",\"{contraseña}\",\"{rol}\")";
            Clases.Database.Usuarios.CrearUsuario(consulta);
        }
    }
}
