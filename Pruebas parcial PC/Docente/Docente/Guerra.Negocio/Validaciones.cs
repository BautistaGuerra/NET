using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra.Negocio
{
    public class Validaciones
    {

        static public bool EsCuilValido(string cuil)
        {
            return ((cuil.Length == 8) & (cuil.StartsWith("20") | cuil.StartsWith("27") | cuil.StartsWith("30")));
        }

        static public Entidades.Docente RecuperarUno(string cuil)
        {
            try
            {
                if (EsCuilValido(cuil))
                {
                    Datos.Docente docenteData = new Datos.Docente();
                    return docenteData.RecuperarUno(cuil);
                }
                else
                {
                    Exception ex = new Exception("Cuil invalido");
                    throw ex;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
