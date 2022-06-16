using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases4
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string dni;

        public Persona(string nom, string ape, int ed, string nroDni)
        {
            nombre = nom;
            apellido = ape;
            edad = ed;
            dni = nroDni;

            Console.WriteLine("Persona creada correctamente...");
        }
        public string Nombre
        {
            get => default;
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get => default;
            set
            {
                apellido = value;

            }
        }

        public string Dni
        {
            get => default;
            set
            {
                dni = value;

            }
        }

        public int Edad
        {
            get => default;
            set
            {
                edad = value;

            }
        }

        public string GetFullName()
        {
            return $"{Nombre} {Apellido}";
        }

        public int GetAge()
        {
            return edad;
        }


        ~Persona()
        {
            Console.WriteLine("Persona eliminada correctamente...");
        }
    }
}
