using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Juego
    {
        public int record { get; set; }

        public Juego()
        {
            Console.WriteLine("Bienvenido al juego de adivinar el numero!\n");
        }
        public void ComenzarJuego()
        {
            Console.Clear();
            int nroMax = PreguntarMaximo();
            Jugada jug = new Jugada(nroMax);
            int nro;
            do
            {
                Console.WriteLine();
                nro = PreguntarNumero();
                jug.intentos++;
            }while(!(jug.Comparar(nro)));

            if (CompararRecord(jug.intentos) || record == 0)
            {
                Console.WriteLine($"Felicitaciones, supero su antiguo record de {record} intentos con una nueva marca de {jug.intentos} intentos");
                record = jug.intentos;
            }
            else
                Console.WriteLine($"Su record sigue siendo {record}");

            Console.WriteLine();
            Continuar();



        }

        private int PreguntarMaximo()
        {
            Console.Write("Ingrese el maximo: ");
            int nroMax = Convert.ToInt32(Console.ReadLine());
            return nroMax;
        }

        private int PreguntarNumero()
        {
            Console.Write("Ingrese su numero: ");
            int nro = Convert.ToInt32(Console.ReadLine());
            return nro;
        }

        private bool CompararRecord(int intentos)
        {
            return intentos < record;
        }

        private void Continuar()
        {
            Console.Write("Desea continuar? (1- SI / otro- NO): ");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1) ComenzarJuego();
            else Console.WriteLine("Gracias por jugar, que tenga un buen dia...");
        }
    }
}
