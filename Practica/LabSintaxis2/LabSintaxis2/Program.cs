using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Menu(string texto)
        {
            ConsoleKeyInfo opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija entre las siguientes opciones: ");
                Console.WriteLine("1- Convertir a mayusculas\n2- Convertir a minusculas\n3- Mostrar cantidad de caracteres\n4 - Salir");
                opcion = Console.ReadKey();

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"Texto original: {texto}");
                        Console.WriteLine($"Texto modificado: {texto.ToUpper()}");
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine($"Texto original: {texto}");
                        Console.WriteLine($"Texto modificado: {texto.ToLower()}");
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine($"Cantidad de caracteres: {texto.Length}");
                        break;

                    default:
                        break;
                }
                Console.ReadKey();
            } while (opcion.Key != 
            ConsoleKey.D4);
            
        }
        static void Main(string[] args)
        {
            string texto;
            do {
                Console.WriteLine("Ingrese un texto: ");
                texto = Console.ReadLine();
            } while (!(texto is string));

            Menu(texto);

        }
    }
}
