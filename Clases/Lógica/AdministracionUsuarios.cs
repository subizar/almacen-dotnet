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
            bool esNumerico = int.TryParse(textofiltro, out _);
            //tambien podrias revisar si filtro es el ID en vez de usar try parse, pero esto tmbn funciona
            switch (exact)
            {
                case true:
                    consulta = esNumerico
                        ? $"SELECT usr_id, nombre, rol FROM Usuarios WHERE {filtro} = {textofiltro}"
                : $"SELECT usr_id, nombre, rol FROM Usuarios WHERE {filtro} = \"{textofiltro}\"";
                    break;
                case false:
                    consulta = esNumerico
               ? $"SELECT usr_id, nombre, rol FROM Usuarios WHERE {filtro} LIKE {textofiltro}"
               : $"SELECT usr_id, nombre, rol FROM Usuarios WHERE {filtro} LIKE \"%{textofiltro}%\"";
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

        public static void EditarUsuario(Usuario usuario)
        {
            if (usuario.contraseña == null) //si no editamos la contraseña, ponemos la actual
            {
                usuario.contraseña = Database.Misc.LeerValor($"SELECT contraseña FROM Usuarios WHERE usr_id={usuario.id}").ToString(); //esto me ahorra tener que pensar en como modificar la consulta dependiendo de lo que hayamos editado
            }
            string consulta = $"UPDATE Usuarios SET nombre=\"{usuario.name}\", rol=\"{usuario.role}\",contraseña=\"{usuario.contraseña}\" WHERE usr_id={usuario.id}";
            Database.Usuarios.EditarUsuario(consulta);

        }

        public static void EliminarUsuario(int id)
        {
            string consulta = "";
            if (id != 0)
            {
                consulta = $"DELETE FROM Usuarios WHERE usr_id = {id}";
            }
            Database.Usuarios.EliminarUsuario(consulta);
        }
    }
}
