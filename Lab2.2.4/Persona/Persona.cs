using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Persona
    {
        private string nombrePersona;
        private string apellidoPersona;
        private int dniPersona;
        private DateTime fechaNacimiento;

        public string NombrePersona
        {
            get
            {
                return nombrePersona;
            }
            set
            {
                nombrePersona = value;
            }
        }
        public string ApellidoPersona
        {
            get
            {
                return apellidoPersona;
            }
            set
            {
                apellidoPersona = value;
            }
        }
        public int DniPersona
        {
            get
            {
                return dniPersona;
            }
            set
            {
                dniPersona = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = Convert.ToDateTime(value);
            }
        }

        public Persona(int dni, string nombre, string apellido, string fecha)
        {
            dniPersona = dni;
            nombrePersona = nombre;
            apellidoPersona = apellido;
            fechaNacimiento = Convert.ToDateTime(fecha);
            Console.WriteLine("Se ha creado una instancia de la clase Persona correctamente.");
        }

        ~Persona()
        {
            Console.WriteLine("Se ha eliminado la instancia de la clase Persona correctamente.");
        }

        public string GetFullName()
        {
            return nombrePersona + " " + apellidoPersona;
        }

        public int GetAge()
        {
            return ((DateTime.Today - fechaNacimiento).Days) / 365;
        }




    }
}
