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
            string consulta = "";
            switch (exact)
            {
                case true: //Si el resultado debe ser exacto, usamos = en vez de LIKE
                    consulta = $"SELECT usr_id, nombre, rol FROM Usuarios WHERE {filtro}=\"{textofiltro}\"";
                    //Esta consulta FALLA para los ID's o cosas que no sean strings. hay que arreglarlo.
                    break;
                case false:
                    consulta = $"SELECT usr_id, nombre, rol FROM Usuarios WHERE {filtro} LIKE \"{textofiltro}\"";
                    break;
            }
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
