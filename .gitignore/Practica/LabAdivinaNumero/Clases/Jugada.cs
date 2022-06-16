using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugada
    {
        private int numero;

        public int Numero
        {
            get
            {
                return default;
            }
            set
            {
                numero = value;
            }
        }

        public int intentos { get; set; }
        public bool adivino { get; set; }
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            numero = rnd.Next(maxNumero);
            intentos = 0;
        }

        public bool Comparar(int nro)
        {
            return nro == numero;
        }

    }
}
