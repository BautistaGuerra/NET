using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero)
        {
            Random rnd = new Random();
            numero = rnd.Next(maxNumero);
        }

        new public bool Comparar(int nroElegido)
        {
            if (nroElegido != numero)
            {
                if (nroElegido < numero) Console.Write("El numero correcto es mayor ");
                else Console.Write("El numero correcto es menor ");
                if (Math.Abs(nroElegido - numero) >= 20) Console.WriteLine("y esta muy lejos");
                else if (Math.Abs(nroElegido - numero) > 5) Console.WriteLine("pero esta cerca");
                else if (Math.Abs(nroElegido - numero) <= 5) Console.WriteLine("pero esta muy cerca");
            }

            return nroElegido == numero;
        }

    }
}
