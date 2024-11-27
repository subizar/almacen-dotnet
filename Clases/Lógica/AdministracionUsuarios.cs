using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas.Clases.Database;
using System.Windows.Forms;
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

        public static void CrearUsuario(string name, string rol, string contraseña,string mail)
        {
            //falta validacion del input
            string consulta = $"INSERT INTO Usuarios (nombre, contraseña, rol, mail) VALUES  (\"{name}\",\"{contraseña}\",\"{rol}\",\"{mail}\")";
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
        public static void CambiarNombre(string nombre, string contraseña)
        {
            if (contraseña == State.user_password)
            {


                string nombreAnterior = State.user_name;
                string consulta = $"UPDATE Usuarios SET nombre = '{nombre}' WHERE nombre ='{nombreAnterior}' ";
                Usuarios.CambiarNombre(consulta);
                MessageBox.Show("Nombre de usuario actualizado con exito");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }

        }
        public static void GuardarContraseñaVieja(string ContraseñaVieja,int id)
        {
            string consulta = $"INSERT INTO ContraseñasViejas (usr_id , contraseñaVieja) VALUES ({id},'{ContraseñaVieja}')";
            Usuarios.GuardarContraseñaVieja(consulta);
            
        }
        public static void CambiarContraseñaMail(string contraseñaNueva, string nombre)
        {
            string consulta = $"UPDATE Usuarios SET contraseña = '{contraseñaNueva}' WHERE nombre ='{nombre}' ";
            Usuarios.CambiarContraseña(consulta);
            GuardarContraseñaVieja(BuscarContraseña(nombre), BuscarId(nombre));
        }
        public static void CambiarContraseña(string contraseñaNueva, string ContraseñaActual)
        {
            if (ContraseñaActual == State.user_password)
            {
                string nombre = State.user_name;
                string consulta = $"UPDATE Usuarios SET contraseña = '{contraseñaNueva}' WHERE nombre ='{nombre}' ";
                Usuarios.CambiarContraseña(consulta);
                GuardarContraseñaVieja(ContraseñaActual, BuscarId(nombre));
                MessageBox.Show("Contraseña actualizada con exito");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            };
        }

        public static int BuscarId(string nombre)
        {
            string consulta = $"SELECT usr_id FROM Usuarios WHERE nombre = '{nombre}'";
            int id = Usuarios.BuscarId(consulta);
            return id;
        }
        public static string BuscarMail(string nombre)
        {
            string consulta = $"SELECT mail FROM Usuarios WHERE nombre = '{nombre}'";
            string mail = Usuarios.BuscarMail(consulta);
            return mail;
        }
        public static string BuscarContraseña(string nombre)
        {
            string consulta = $"SELECT contraseña FROM Usuarios WHERE nombre = '{nombre}'";
            string contraseña = Usuarios.BuscarContraseña(consulta);
            return contraseña;
        }


        public static bool primerIngreso(int id)
        {
            string consulta = $"SELECT contraseñaVieja_id FROM ContraseñasViejas WHERE usr_id = {id} ";
            int usr_id = Usuarios.BuscarId(consulta);
            if (usr_id == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
                
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
