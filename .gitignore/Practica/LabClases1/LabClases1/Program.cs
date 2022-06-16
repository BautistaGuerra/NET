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
            a.MostrarNombre();
            Console.WriteLine();

            A a2 = new A("Instancia a2");
            a2.MostrarNombre();
            a2.M1();
            a2.M2();
            a2.M3();
            Console.WriteLine();

            B b = new B();
            b.MostrarNombre();
            b.M1();
            b.M2();
            b.M3();
            b.M4();

            Console.ReadKey();



        }
    }
}
