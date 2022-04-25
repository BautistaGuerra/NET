using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2._3._1
{
    class Provincia
    {
        public string Nombre { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var prov = new List<Provincia> { new Provincia { Nombre = "Buenos Aires" }, new Provincia { Nombre = "Catamarca" }, new Provincia { Nombre = "Chaco" }, new Provincia { Nombre = "Chubut" }, new Provincia { Nombre = "Cordoba" }, new Provincia { Nombre = "Corrientes" }, new Provincia { Nombre = "Entre Rios" }, new Provincia { Nombre = "Formosa" }, new Provincia { Nombre = "Jujuy" }, new Provincia { Nombre = "La Pampa" }, new Provincia { Nombre = "La Rioja" }, new Provincia { Nombre = "Mendoza" }, new Provincia { Nombre = "Misiones" }, new Provincia { Nombre = "Neuquen" }, new Provincia { Nombre = "Rio Negro" }, new Provincia { Nombre = "Salta" }, new Provincia { Nombre = "San Juan" }, new Provincia { Nombre = "San Luis" }, new Provincia { Nombre = "Santa Cruz" }, new Provincia { Nombre = "Santa Fe" }, new Provincia { Nombre = "Santiago del Estero" }, new Provincia { Nombre = "Tierra del Fuego" }, new Provincia { Nombre = "Tucuman" } };

            var provS = prov.Where(p => (p.Nombre.StartsWith("S") | p.Nombre.StartsWith("T"))).Select(p => new {p.Nombre});

            Console.WriteLine("Provincias de Argentina cuyo nombre comienza con la letra S o T: ");
            
            foreach(var p in provS)
            {
                Console.WriteLine(p.Nombre);
            }


        }
    }
}
