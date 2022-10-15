using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity
{
    public class Modulo
    {
        public enum States
        {
            New,
            Modified,
            Unmodified,
            Deleted
        }

        public States State { get; set; }


        public int idModulo { get; set; }
        public string Descripcion { get; set; }
        public string Ejecuta { get; set; }

    }
}
