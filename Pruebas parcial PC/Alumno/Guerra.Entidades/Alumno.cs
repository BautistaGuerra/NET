using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra.Entidades
{
    public class Alumno
    {
        public string ApellidoNombre { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal NotaPromedio { get; set; }
        private int _Edad;
        public int Edad
        {
            get
            {
                TimeSpan difFechas = DateTime.Now - FechaNacimiento;
                return Convert.ToInt32((difFechas.Days) / 365);
            }
        }

        public Alumno()
        {

        }

        public Alumno(string apellido_nombre, string dni, string email, DateTime fecha_nacimiento, decimal nota_promedio)
        {
            ApellidoNombre = apellido_nombre;
            Dni = dni;
            Email = email;
            FechaNacimiento = fecha_nacimiento;
            NotaPromedio = nota_promedio;
        }


    }
}
