using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregableValentinoMele
{
    public abstract class Producto
    {
        protected int Id { get; set; }
        protected string Descripcion { get; set; }
        protected int Costo { get; set; }
        protected double PrecioVenta { get; set; }
        protected int Stock { get; set; }
        protected char IdUsuario { get; set; }
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
