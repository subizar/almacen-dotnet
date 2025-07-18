using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practicas.Clases.Lógica
{
    /// <summary>
    /// Clase utilitaria para validación de entradas del usuario
    /// </summary>
    internal static class InputValidator
    {
        // Constantes para límites
        public const int MAX_STRING_LENGTH = 255;
        public const int MIN_PASSWORD_LENGTH = 3;
        public const int MAX_PASSWORD_LENGTH = 100;
        public const int MAX_USERNAME_LENGTH = 50;
        public const int MIN_USERNAME_LENGTH = 2;
        public const int MAX_PRICE = 999999;
        public const int MIN_PRICE = 0;
        public const int MAX_STOCK = 99999;
        public const int MIN_STOCK = 0;

        /// <summary>
        /// Valida si una cadena no está vacía y no excede la longitud máxima
        /// </summary>
        public static bool ValidateStringInput(string input, int maxLength = MAX_STRING_LENGTH, bool allowEmpty = false)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return allowEmpty;
            }
            return input.Length <= maxLength;
        }

        /// <summary>
        /// Valida un nombre de usuario
        /// </summary>
        public static bool ValidateUsername(string username, out string errorMessage)
        {
            errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "El nombre de usuario es requerido";
                return false;
            }

            if (username.Length < MIN_USERNAME_LENGTH)
            {
                errorMessage = $"El nombre de usuario debe tener al menos {MIN_USERNAME_LENGTH} caracteres";
                return false;
            }

            if (username.Length > MAX_USERNAME_LENGTH)
            {
                errorMessage = $"El nombre de usuario no puede exceder {MAX_USERNAME_LENGTH} caracteres";
                return false;
            }

            // Validar caracteres permitidos (letras, números, espacios, algunos símbolos básicos)
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9\s._@-]+$"))
            {
                errorMessage = "El nombre de usuario contiene caracteres no válidos";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida una contraseña
        /// </summary>
        public static bool ValidatePassword(string password, out string errorMessage)
        {
            errorMessage = "";
            
            if (string.IsNullOrEmpty(password))
            {
                errorMessage = "La contraseña es requerida";
                return false;
            }

            if (password.Length < MIN_PASSWORD_LENGTH)
            {
                errorMessage = $"La contraseña debe tener al menos {MIN_PASSWORD_LENGTH} caracteres";
                return false;
            }

            if (password.Length > MAX_PASSWORD_LENGTH)
            {
                errorMessage = $"La contraseña no puede exceder {MAX_PASSWORD_LENGTH} caracteres";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida un precio
        /// </summary>
        public static bool ValidatePrice(string priceText, out int price, out string errorMessage)
        {
            price = 0;
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(priceText))
            {
                errorMessage = "El precio es requerido";
                return false;
            }

            if (!int.TryParse(priceText, out price))
            {
                errorMessage = "El precio debe ser un número entero válido";
                return false;
            }

            if (price < MIN_PRICE)
            {
                errorMessage = $"El precio no puede ser menor que {MIN_PRICE}";
                return false;
            }

            if (price > MAX_PRICE)
            {
                errorMessage = $"El precio no puede ser mayor que {MAX_PRICE}";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida un stock
        /// </summary>
        public static bool ValidateStock(string stockText, out int stock, out string errorMessage)
        {
            stock = 0;
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(stockText))
            {
                errorMessage = "El stock es requerido";
                return false;
            }

            if (!int.TryParse(stockText, out stock))
            {
                errorMessage = "El stock debe ser un número entero válido";
                return false;
            }

            if (stock < MIN_STOCK)
            {
                errorMessage = $"El stock no puede ser menor que {MIN_STOCK}";
                return false;
            }

            if (stock > MAX_STOCK)
            {
                errorMessage = $"El stock no puede ser mayor que {MAX_STOCK}";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida un nombre de producto
        /// </summary>
        public static bool ValidateProductName(string productName, out string errorMessage)
        {
            errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(productName))
            {
                errorMessage = "El nombre del producto es requerido";
                return false;
            }

            if (productName.Length > MAX_STRING_LENGTH)
            {
                errorMessage = $"El nombre del producto no puede exceder {MAX_STRING_LENGTH} caracteres";
                return false;
            }

            // Validar que no contenga caracteres potencialmente peligrosos para SQL
            if (ContainsSqlInjectionPatterns(productName))
            {
                errorMessage = "El nombre del producto contiene caracteres no válidos";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida un email básico
        /// </summary>
        public static bool ValidateEmail(string email, out string errorMessage)
        {
            errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "El email es requerido";
                return false;
            }

            if (email.Length > MAX_STRING_LENGTH)
            {
                errorMessage = $"El email no puede exceder {MAX_STRING_LENGTH} caracteres";
                return false;
            }

            // Validación básica de email
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "El formato del email no es válido";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Detecta patrones básicos de inyección SQL
        /// </summary>
        public static bool ContainsSqlInjectionPatterns(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string[] dangerousPatterns = {
                "'", "\"", ";", "--", "/*", "*/", "xp_", "sp_", 
                "DROP", "DELETE", "INSERT", "UPDATE", "SELECT",
                "UNION", "EXEC", "EXECUTE"
            };

            string upperInput = input.ToUpper();
            foreach (string pattern in dangerousPatterns)
            {
                if (upperInput.Contains(pattern.ToUpper()))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Sanitiza una cadena para uso seguro en consultas SQL (no reemplaza parámetros)
        /// </summary>
        public static string SanitizeInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Remover caracteres peligrosos
            return input.Replace("'", "")
                       .Replace("\"", "")
                       .Replace(";", "")
                       .Replace("--", "")
                       .Replace("/*", "")
                       .Replace("*/", "")
                       .Trim();
        }

        /// <summary>
        /// Muestra un mensaje de error en un MessageBox estándar
        /// </summary>
        public static void ShowValidationError(string message)
        {
            MessageBox.Show(message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Muestra un mensaje de éxito
        /// </summary>
        public static void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}