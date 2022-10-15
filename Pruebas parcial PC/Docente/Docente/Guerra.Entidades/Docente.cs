using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra.Entidades
{
    public class Docente
    {
        public string ApellidoNombre { get; set; }
        public string Cuil { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Id { get; set; }
        public decimal Salario { get; set; }

        private int _Antiguedad;
        public int Antiguedad {
            get
            {
                int anios = Convert.ToInt32(((DateTime.Today - FechaIngreso).Days) / 365);
                return anios;
            }
        }

        public Docente()
        {

        }
        public Docente(string apellido_nombre, string cuil, string email, DateTime fecha_ingreso, int id, decimal salario)
        {
            ApellidoNombre = apellido_nombre;
            Cuil = cuil;
            Email = email;
            FechaIngreso = fecha_ingreso;
            Id = id;
            Salario = salario;
        }
    }
}
