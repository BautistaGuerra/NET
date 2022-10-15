using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    public class Especialidad
    {
        public enum States
        {
            New,
            Modified,
            Deleted,
            Unmodified
        }

        public States State { get; set; }

        public int idEspecialidad { get; set; }
        public string Descripcion { get; set; }
    }
}
