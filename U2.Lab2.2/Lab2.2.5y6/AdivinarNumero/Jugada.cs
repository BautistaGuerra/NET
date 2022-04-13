using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    class Jugada
    {
        protected int numero;
        protected int intentos;
        protected bool adivino;

        public int Intentos
        {
            get
            {
                return intentos;
            }
        }

        public bool Adivino
        {
            get
            {
                return adivino;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public bool Comparar(int nroElegido)
        {
            return nroElegido == numero;
        }
    }
}
