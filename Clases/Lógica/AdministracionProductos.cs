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
        public static void AgregarProducto(string nombre , int precio)
        {
            string consulta = $"INSERT INTO Productos (nombre, precio) VALUES('{nombre}',{precio})";
            try
            {
                Productos.AgregarProducto(consulta);
                MessageBox.Show("Producto ingresado correctamente");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void EditarProducto(Producto producto)
        {
            string consulta = $"UPDATE Productos SET nombre=\"{producto.name}\", precio={producto.price} WHERE producto_id={producto.id}";
            Database.Productos.AgregarProducto(consulta);

        }

        public static List<Producto> LeerProductos()
        {
            string consulta = $"SELECT producto_id, nombre, precio FROM Productos";
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
                        ? $"SELECT producto_id, nombre, precio FROM Productos WHERE {filtro} = {textofiltro}"
                : $"SELECT producto_id, nombre, precio FROM Productos WHERE {filtro} = \"{textofiltro}\"";
                    break;
                case false:
                    consulta = esNumerico
               ? $"SELECT producto_id, nombre, precio FROM Productos WHERE {filtro} LIKE {textofiltro}"
               : $"SELECT producto_id, nombre, precio FROM Productos WHERE {filtro} LIKE \"%{textofiltro}%\"";
                    break;
            }
            return Database.Productos.LeerProductos(consulta);
        }

    }
}
