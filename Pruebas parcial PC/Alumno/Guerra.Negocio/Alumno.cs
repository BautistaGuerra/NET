using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guerra.Datos;
using Guerra.Entidades;


namespace Guerra.Negocio
{
    public class Alumno
    {
        Datos.Alumno AlumnoData;
        static public List<Entidades.Alumno> RecuperarTodos()
        {
            Datos.Alumno AlumnoData = new Datos.Alumno();
            return AlumnoData.RecuperarTodos();

        }


        static public void Agregar(Entidades.Alumno alumno)
        {
            Datos.Alumno AlumnoData = new Datos.Alumno();
            AlumnoData.Agregar(alumno);
        }

        static public Entidades.Alumno RecuperarUno(string dni)
        {
            Datos.Alumno AlumnoData = new Datos.Alumno();
            return AlumnoData.RecuperarUno(dni);
        }


        
    }
}
