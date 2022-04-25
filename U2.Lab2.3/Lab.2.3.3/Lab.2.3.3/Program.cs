using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab._2._3._3
{
    class Provincia
    {
        public string Nombre { get; set; }
        public string codPostal { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var prov = new List<Provincia> { new Provincia { Nombre = "Cordoba", codPostal = "5000"}, new Provincia { Nombre = "Rosario", codPostal = "2000" }, new Provincia { Nombre = "Venado Tuerto", codPostal = "2600" }, new Provincia { Nombre = "La Plata", codPostal = "1900" }, new Provincia { Nombre = "Mar del Plata", codPostal = "7600" }, new Provincia { Nombre = "Pergamino", codPostal = "2700" }, new Provincia { Nombre = "Mendoza", codPostal = "5500" }, new Provincia { Nombre = "Villa Carlos Paz", codPostal = "5152" }, new Provincia { Nombre = "Salta", codPostal = "4400" }, new Provincia { Nombre = "Posadas", codPostal = "3300" } };

            string desc;
            do
            {
                Console.Write("Ingrese nombre parcial de las ciudades a buscar (3 caracteres): ");
                desc = Console.ReadLine();
            } while (desc.Length != 3);

            var provDesc = prov.Where(p => p.Nombre.ToLower().Contains(desc)).Select(p => new { p.Nombre, p.codPostal});

            Console.WriteLine();
            Console.WriteLine($"Provincias coincidentes con '{desc}': ");
            foreach(var p in provDesc)
            {
                Console.WriteLine($"{p.Nombre}: {p.codPostal}");
            }

            Console.ReadKey();
        }
    }
}
