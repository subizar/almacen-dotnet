using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases
{
    public class Modelos
    {
            public class Usuario
            {
                private int Id;
                private string Name;
                private string Role;
                private string Contraseña;
                public int id
                {
                    get { return Id; }
                    set { Id = value; }
                }
                public string name
                {
                    get { return Name; }
                    set { Name = value; }
                }
                public string role
                {
                    get { return Role; }
                    set { Role = value; }
                }
                public string contraseña
                {
                    get { return Contraseña; }
                    set { Contraseña = value; }
                }


                public Usuario(int id, string name, string role, string contraseña = null)
                {
                    this.id = id;
                    this.name = name;
                    this.role = role;
                    this.contraseña = contraseña;
                }
            }


        public class Producto
        {
            private int Id;
            private string Name;
            private double Precio;

            public int id
            {
                get { return Id; }
                set { Id = value; }
            }
            public string name
            {
                get { return Name; }
                set { Name = value; }
            }
            public double price
            {
                get { return Precio; }
                set { Precio = value; }
            }


            public Producto(int id, string name, double price)
            {
                this.id = id;
                this.name = name;
                this.price = price;
            }
        }

        public class Venta
        {
            private int Id;
            private int Id_cajero;
            private string Fecha;
            private double Total;
            private List<ProductoEnCarrito> Productos;

            public List<ProductoEnCarrito> productos
            {
                get { return Productos; }
                set { Productos = value; }
            }
            public int id
            {
                get { return Id; }
                set { Id = value; }
            }
            public int id_cajero
            {
                get { return Id_cajero; }
                set { Id_cajero = value; }
            }
            public string fecha
            {
                get { return Fecha; }
                set { Fecha = value; }
            }
            public double total
            {
                get { return Total; }
                set { Total = value; }
            }


            public Venta(int id = 0, int id_cajero = 0, string fecha = null, double total = 0, List<ProductoEnCarrito> productos = null)
            {
                this.id = id;
                this.id_cajero = id_cajero;
                this.fecha = fecha;
                this.total = total;
                this.productos = productos;
            }
        }

        public class ProductoEnCarrito
        {
            private int Quantity;
            public int quantity
            {
                get { return Quantity;}
                set { Quantity = value; }
            }
            private int Id;
            private string Name;
            private double Precio;

            public int id
            {
                get { return Id; }
                set { Id = value; }
            }
            public string name
            {
                get { return Name; }
                set { Name = value; }
            }
            public double price
            {
                get { return Precio; }
                set { Precio = value; }
            }

            public ProductoEnCarrito(Producto producto, int quantity)
            {
                this.quantity = quantity;
                this.id = producto.id;
                this.name = producto.name;
                this.price = producto.price;
            }
        }
    }
}
