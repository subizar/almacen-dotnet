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
        // No realiza ningun tipo de autenticación real (En el sentido de que esto no se vuelve a verificar
        // para ninguna acción, y un usuario puede simplemente modificar la memoria y acceder al programa sin restricciones)
        public static (bool, int?) VerificarCredenciales(string usuario, string contraseña)
        {
            // Validar entrada antes de procesar
            if (!InputValidator.ValidateUsername(usuario, out string userError))
            {
                InputValidator.ShowValidationError(userError);
                return (false, null);
            }

            if (!InputValidator.ValidatePassword(contraseña, out string passError))
            {
                InputValidator.ShowValidationError(passError);
                return (false, null);
            }

            // Usar consulta parametrizada para evitar inyección SQL
            (bool, int?) response = Database.Usuarios.RevisarLoginSeguro(usuario, contraseña);
            return response;
        }

        public static string LeerRol(int id)
        {
            // Validar que el ID sea válido
            if (id <= 0)
            {
                InputValidator.ShowValidationError("ID de usuario inválido");
                return string.Empty;
            }

            // Usar consulta parametrizada para evitar inyección SQL
            return Database.Usuarios.LeerRolSeguro(id);
        }
    }
}
