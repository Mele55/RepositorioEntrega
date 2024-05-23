using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregableValentinoMele
{
    public abstract class ProductoVendido
    {
        internal int Id { get; set; }
        internal int IdProducto { get; set; }
        internal int Stock { get; set; }
        internal char IdVenta { get; set; }

        public ProductoVendido(int id, int idproducto, int stock, char idventa)
        {
            this.Id = id;
            this.IdProducto = idproducto;
            this.Stock = stock;
            this.IdVenta = idventa;
        }
    }
}
