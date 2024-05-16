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
        protected int Id { get; set; }
        protected int IdProducto { get; set; }
        protected int Stock { get; set; }
        protected char IdVenta { get; set; }

        public ProductoVendido(int id, int idproducto, int stock, char idventa)
        {
            this.Id = id;
            this.IdProducto = idproducto;
            this.Stock = stock;
            this.IdVenta = idventa;
        }
    }
}
