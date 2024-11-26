using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases
{
    public class Modelos
    {
        //Las propiedades tienen que ser public para que los datagridview puedan accederlas
        //perdón profe
        public class Usuario
        {
            public int id { get; set; }
            public string name { get; set; }
            public string role { get; set; }
            public string contraseña { get; set; }

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
            public int id { get; set; }
            public string name { get; set; }
            public double price { get; set; }

            public Producto(int id, string name, double price)
            {
                this.id = id;
                this.name = name;
                this.price = price;
            }
        }

        public class Venta
        {
            public int id { get; set; }
            public int id_cajero { get; set; }
            public string date { get; set; }
            public double total { get; set; }

            public Venta(int id, int id_cajero, string date, double total)
            {
                this.id = id;
                this.id_cajero = id_cajero;
                this.date = date;
                this.total = total;
            }
        }
    }
}
