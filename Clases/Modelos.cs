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
            private int id { get; set; }
            private string name { get; set; }
            private string role { get; set; }

            public Usuario(int id, string name, string role)
            {
                this.id = id;
                this.name = name;
                this.role = role;
            }
        }

        public class Producto
        {
            private int id { get; set; }
            private string name { get; set; }
            private double price { get; set; }

        }

        public class Venta
        {
            private int id { get; set; }
            private int id_cajero { get; set; }
            private string date { get; set; }
            private double total { get; set; }
        }
    }
}
