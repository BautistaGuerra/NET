using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            do
            {
                Console.Write("Indique la cantidad de numeros que desea ingresar: ");
                cant = Convert.ToInt32(Console.ReadLine());
            } while (cant <= 0);

            var listaNumeros = new List<int>();

            Console.WriteLine("Ingrese los numeros: ");
            while(cant > 0)
            {
                int nro = Convert.ToInt32(Console.ReadLine());
                listaNumeros.Add(nro);
                cant--;
            }
            Console.WriteLine();

            var mayores20 = listaNumeros.Where(nro => nro > 20).Select(nro => nro);

            Console.WriteLine("Numeros mayores a 20: ");
            foreach(int n in mayores20)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
