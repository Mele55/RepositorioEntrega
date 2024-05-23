using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregableValentinoMele
{
    public class Producto
    {
        internal int Id { get; set; }
        internal string Descripcion { get; set; }
        internal int Costo { get; set; }
        internal double PrecioVenta { get; set; }
        internal int Stock { get; set; }
        internal char IdUsuario { get; set; }
        public Producto(int id, string descripcion, int costo, double precioVenta, int stock, char idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }
    }
}
