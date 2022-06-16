using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLINQ3
{
    public class Ciudad
    {
        public string Nombre { get; set; }
        public int CodPostal { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Ciudad> ciudades = new List<Ciudad> { new Ciudad { Nombre = "Buenos Aires", CodPostal = 001 }, new Ciudad { Nombre = "Catamarca", CodPostal = 002 }, new Ciudad { Nombre = "Chaco", CodPostal = 003 }, new Ciudad { Nombre = "Chubut", CodPostal = 004 }, new Ciudad { Nombre = "Cordoba", CodPostal = 005 }, new Ciudad { Nombre = "Corrientes", CodPostal = 006 }, new Ciudad { Nombre = "Entre Rios", CodPostal = 007 }, new Ciudad { Nombre = "Formosa", CodPostal = 008}, new Ciudad { Nombre = "Jujuy", CodPostal = 009}, new Ciudad { Nombre = "La Pampa", CodPostal = 010}, new Ciudad { Nombre = "La Rioja", CodPostal = 011}, new Ciudad { Nombre = "Mendoza", CodPostal = 012}, new Ciudad { Nombre = "Misiones", CodPostal = 013}, new Ciudad { Nombre = "Neuquen", CodPostal = 014}, new Ciudad { Nombre = "Rio Negro", CodPostal = 015}, new Ciudad { Nombre = "Salta", CodPostal = 016 }, new Ciudad { Nombre = "San Juan", CodPostal = 017 }, new Ciudad { Nombre = "San Luis", CodPostal = 018 }, new Ciudad { Nombre = "Santa Cruz", CodPostal = 019 }, new Ciudad { Nombre = "Santa Fe", CodPostal = 020 }, new Ciudad { Nombre = "Santiago del Estero", CodPostal = 021}, new Ciudad { Nombre = "Tierra del Fuego", CodPostal = 022 }, new Ciudad { Nombre = "Tucuman", CodPostal = 023 } };
            string busqueda;
            do
            {
                Console.Write("Ingrese su busqueda (3 caracteres): ");
                busqueda = Console.ReadLine();
            } while (busqueda.Length != 3);

            var ciudCoincidentes = ciudades.Where(c => c.Nombre.Contains(busqueda)).Select(c => new { Nombre = c.Nombre, CodPostal = c.CodPostal });
            Console.WriteLine();
            Console.WriteLine($"Provincias coincidentes con \"{busqueda}\": ");
            foreach(var c in ciudCoincidentes)
            {
                Console.WriteLine($"\t{c.Nombre}\t{c.CodPostal}");
            }
            Console.ReadKey();
        }
    }
}
