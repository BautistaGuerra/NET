using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    public class Juego
    {
        private int record;

        public Juego()
        {
            record = 0;
            Console.WriteLine("Bienvenido al juego de adivinar el numero...");
            Console.WriteLine("Usted tendra que definir un intervalo de valores posibles y luego intentar adivinar el numero en el menor numero de intentos posibles");
            Console.WriteLine("¡Mucha suerte!");

        }

        private bool CompararRecord(int cantIntentos)
        {
            if (cantIntentos < record) return true;
            else return false;
        }

        private void Continuar()
        {
            Console.WriteLine("Si desea jugar nuevamente pulse (1), si desea terminar pulse (0): ");
            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.WriteLine();
            if (opcion.Key == ConsoleKey.D1)
            {
                ComenzarJuego();
            }
            else Console.WriteLine("Gracias por haber jugado a adivinar el numero, hasta pronto...");
        }

        private int PreguntarMaximo()
        {
            Console.Write("Indique el numero maximo del intervalo de numeros posibles: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private int PreguntarNumero()
        {
            Console.Write("Indique el numero que cree que es el correcto: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void ComenzarJuego()
        {
            int cantIntentos = 0;
            int nroMax = PreguntarMaximo();
            JugadaConAyuda jugada = new JugadaConAyuda(nroMax);
            int nroElegido = -1;
            bool band;
            do
            {
                nroElegido = PreguntarNumero();
                band = jugada.Comparar(nroElegido);
                cantIntentos += 1;
            } while (!band);
                Console.WriteLine($"Felicitaciones! Ha acertado el numero en {cantIntentos} intentos");
            if (CompararRecord(cantIntentos))
            {
                Console.WriteLine("Ha batido su anterior record. Felicitaciones!");
                record = cantIntentos;
            }
            else if (record == 0)
            {
                Console.WriteLine($"Su record se ha fijado en {cantIntentos} intentos");
                record = cantIntentos;
            }
            else Console.WriteLine($"Su record sigue siendo {record} intentos");
            Continuar();
        }


    }
}
