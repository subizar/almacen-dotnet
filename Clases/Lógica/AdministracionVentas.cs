using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Clases.Lógica
{
    internal class AdministracionVentas
    {
        public static void AgregarVenta(Modelos.Venta venta)
        {
            string consulta = $"INSERT INTO Ventas (usr_id, fecha, precio_total) VALUES ({venta.id_cajero},\"{venta.fecha}\",{venta.total})";
            Database.Ventas.AgregarVenta(consulta);
        }

        public static void EliminarVenta(int id)
        {
            string consulta = "";
            if (id != 0)
            {
                consulta = $"DELETE FROM Ventas WHERE venta_id = {id}";
            }
            Database.Ventas.EliminarVenta(consulta);
        }

        public static List<Modelos.Venta> LeerVentas()
        {
            string consulta = $"SELECT venta_id, usr_id, fecha, precio_total FROM Ventas";
            return Database.Ventas.LeerVenta(consulta);
        }
    }
}
