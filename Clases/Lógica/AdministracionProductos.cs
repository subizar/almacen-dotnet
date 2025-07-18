using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicas.Clases.Database;
using Practicas.Formularios.Admin.ABMs;
using static Practicas.Clases.Modelos;

namespace Practicas.Clases.Lógica
{
    internal class AdministracionProductos
    {
        public static void AgregarProducto(string nombre, int precio, int stock)
        {
            // Validar entrada
            if (!InputValidator.ValidateProductName(nombre, out string nameError))
            {
                InputValidator.ShowValidationError(nameError);
                return;
            }

            if (precio < InputValidator.MIN_PRICE || precio > InputValidator.MAX_PRICE)
            {
                InputValidator.ShowValidationError($"El precio debe estar entre {InputValidator.MIN_PRICE} y {InputValidator.MAX_PRICE}");
                return;
            }

            if (stock < InputValidator.MIN_STOCK || stock > InputValidator.MAX_STOCK)
            {
                InputValidator.ShowValidationError($"El stock debe estar entre {InputValidator.MIN_STOCK} y {InputValidator.MAX_STOCK}");
                return;
            }

            string consulta = $"INSERT INTO Productos (nombre, precio, stock) VALUES('{InputValidator.SanitizeInput(nombre)}',{precio},{stock})";
            try
            {
                Productos.AgregarProducto(consulta);
                MessageBox.Show("Producto ingresado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void EditarProducto(Producto producto)
        {
            // Validar entrada
            if (!InputValidator.ValidateProductName(producto.name, out string nameError))
            {
                InputValidator.ShowValidationError(nameError);
                return;
            }

            if (producto.price < InputValidator.MIN_PRICE || producto.price > InputValidator.MAX_PRICE)
            {
                InputValidator.ShowValidationError($"El precio debe estar entre {InputValidator.MIN_PRICE} y {InputValidator.MAX_PRICE}");
                return;
            }

            if (producto.stock < InputValidator.MIN_STOCK || producto.stock > InputValidator.MAX_STOCK)
            {
                InputValidator.ShowValidationError($"El stock debe estar entre {InputValidator.MIN_STOCK} y {InputValidator.MAX_STOCK}");
                return;
            }

            if (producto.id <= 0)
            {
                InputValidator.ShowValidationError("ID de producto inválido");
                return;
            }

            string consulta = $"UPDATE Productos SET nombre=\"{InputValidator.SanitizeInput(producto.name)}\", precio={producto.price}, stock={producto.stock} WHERE producto_id={producto.id}";
            
            try
            {
                Database.Productos.EditarProducto(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Producto> LeerProductos()
        {
            string consulta = $"SELECT producto_id, nombre, precio , stock FROM Productos";
            return Database.Productos.LeerProductos(consulta);
        }
        public static List<Producto> LeerProductos(string filtro, string textofiltro, bool exact)
        {
            string consulta = "";
            bool esNumerico = int.TryParse(textofiltro, out _);
            //tambien podrias revisar si filtro es el ID en vez de usar try parse, pero esto tmbn funciona
            switch (exact)
            {
                case true:
                    consulta = esNumerico
                        ? $"SELECT producto_id, nombre, precio ,stock FROM Productos WHERE {filtro} = {textofiltro}"
                : $"SELECT producto_id, nombre, precio ,stock FROM Productos WHERE {filtro} = \"{textofiltro}\"";
                    break;
                case false:
                    consulta = esNumerico
               ? $"SELECT producto_id, nombre, precio ,stock FROM Productos WHERE {filtro} LIKE {textofiltro}"
               : $"SELECT producto_id, nombre, precio ,stock FROM Productos WHERE {filtro} LIKE \"{textofiltro}\"";
                    break;
            }
            return Database.Productos.LeerProductos(consulta);
        }

        public static int BuscarStock(string id)
        {
            string consulta = $"SELECT stock FROM Productos WHERE producto_id = {id} ";
            int stock = BuscarStock(consulta);
            return stock;
        }

        public static void EliminarProducto(int id)
        {
            if (id <= 0)
            {
                InputValidator.ShowValidationError("ID de producto inválido");
                return;
            }

            string consulta = $"DELETE FROM Productos WHERE producto_id = {id}";
            
            try
            {
                Database.Productos.EliminarProducto(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


