using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class A
    {
        private string NombreInstancia;

        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre)
        {
            NombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("M1 invocado");
        }
        public void M2()
        {
            Console.WriteLine("M2 invocado");
        }
        public void M3()
        {
            Console.WriteLine("M3 invocado");
        }
    }
}
