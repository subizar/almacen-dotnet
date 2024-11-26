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
