using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    public class Usuario
    {
        public Usuario()
        {
            this.State = States.New;
        }
        public States State { get; set; }
        public enum States
        {
            New,
            Modified,
            Unmodified,
            Deleted
        }
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int Habilitado { get; set; }
    }
}
