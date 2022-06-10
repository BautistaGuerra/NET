using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2._3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Ingrese cantidad de palabras: ");
            int cantIteraciones = Convert.ToInt32(Console.ReadLine());
            string[] lista = new string[cantIteraciones];

            Console.Clear();
            Console.WriteLine("Ingrese cada una de las palabras: ");
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.Write($"Palabra {i + 1}: ");
                lista[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Palabras ingresadas: ");
            for (int i = cantIteraciones; i > 0; i--)
            {
                Console.WriteLine($"\tPalabra {i}: {lista[i - 1]}");
            }

            Console.ReadKey();
        }
    }
}
