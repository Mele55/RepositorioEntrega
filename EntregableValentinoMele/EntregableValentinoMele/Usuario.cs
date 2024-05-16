using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregableValentinoMele
{
    public abstract class Usuario
    {
        protected int Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string NombreUsuario { get; set; }
        protected string Contraseña { get; set; }
        protected char Mail { get; set; }
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, char mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
    }
}
