using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persona;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona2 unaPersona = new Persona2(43644432, "Bautista", "Guerra", "04/12/2001");
            Console.WriteLine($"Nombre completo: {unaPersona.GetFullName()}");
            Console.WriteLine($"Edad: {unaPersona.GetAge()}");
            Console.ReadKey();
        }
    }
}
