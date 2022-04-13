using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A a2 = new A("Nombre definido por usuario");
            Console.Write("Nombre de a: ");
            a.MostrarNombre();
            Console.Write("Nombre de a2: ");
            a2.MostrarNombre();
            Console.WriteLine("Metodos de clase A: ");
            a.M1();
            a.M2();
            a.M3();

            B b = new B();
            Console.WriteLine();
            Console.Write("Nombre de b: ");
            b.MostrarNombre();
            Console.WriteLine("Metodos de clase B: ");
            b.M1();
            b.M2();
            b.M3();
            b.M4();

            Console.ReadKey();





        }
    }
}
