using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLINQ1
{
    public class Provincia
    {
        public string nombre { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Provincia> provincias = new List<Provincia> { new Provincia { nombre = "Buenos Aires" }, new Provincia { nombre = "Catamarca" }, new Provincia { nombre = "Chaco" }, new Provincia { nombre = "Chubut" }, new Provincia { nombre = "Cordoba" }, new Provincia { nombre = "Corrientes" }, new Provincia { nombre = "Entre Rios" }, new Provincia { nombre = "Formosa" }, new Provincia { nombre = "Jujuy" }, new Provincia { nombre = "La Pampa" }, new Provincia { nombre = "La Rioja" }, new Provincia { nombre = "Mendoza" }, new Provincia { nombre = "Misiones" }, new Provincia { nombre = "Neuquen" }, new Provincia { nombre = "Rio Negro" }, new Provincia { nombre = "Salta" }, new Provincia { nombre = "San Juan" }, new Provincia { nombre = "San Luis" }, new Provincia { nombre = "Santa Cruz" }, new Provincia { nombre = "Santa Fe" }, new Provincia { nombre = "Santiago del Estero" }, new Provincia { nombre = "Tierra del Fuego" }, new Provincia { nombre = "Tucuman" } };

            Console.WriteLine("Listado de provincias: ");
            foreach (Provincia p in provincias)
            {
                Console.WriteLine($"\t{p.nombre}");
            }
            Console.WriteLine();
            Console.WriteLine("Provincias que empiezan con S o T: ");
            var provST = provincias.Where(p => p.nombre.StartsWith("S") || p.nombre.StartsWith("T")).Select(p => p.nombre);
            foreach(var p in provST)
            {
                Console.WriteLine($"\t{p}");
            }

            Console.ReadKey();
        }
    }
}
