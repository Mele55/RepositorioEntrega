using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregableValentinoMele
{
    public abstract class Venta
    {
        internal int Id { get; set; }
        internal string Comentarios { get; set; }
        internal int IdUsuario { get; set; }
        public Venta(int id, string comentarios, int idusuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idusuario;
        }
    }
}
