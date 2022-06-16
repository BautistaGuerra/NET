using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeros de su lista: ");
            int cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Ingrese sus {cant} numeros: ");
            List<int> numeros = new List<int>();
            for(int i = 1; i <= cant; i++)
            {
                Console.Write($"Num {i}: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.WriteLine("Numeros mayores a 20: ");
            var mayores = numeros.Where(n => n > 20).Select(n => n);
            
            foreach(int n in mayores)
            {
                Console.WriteLine($"\t{n}");

            }
            Console.ReadKey();

        }
    }
}
