using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guerra.Datos;
using Guerra.Entidades;
using System.Text.RegularExpressions;

namespace Guerra.Negocio
{
    public class Validaciones
    {
        static public bool EsMailValido(string email)
        {
            bool esValido = Regex.IsMatch(email, @"([0-9a-zA-Z])+@([a-zA-Z])+.com");
            return esValido;
        }

        static public Entidades.Alumno EsDniNulo(string dni) {
            try
            {
                Guerra.Datos.Alumno AlumnoData = new Datos.Alumno();
                return AlumnoData.RecuperarUno(dni);
            }
            catch (Exception ex)
            {

                throw ex;
            }        
        }

    }
}
