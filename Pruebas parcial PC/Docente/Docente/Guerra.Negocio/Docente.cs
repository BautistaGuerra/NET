using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guerra.Entidades;
using Guerra.Datos;

namespace Guerra.Negocio
{
    public class Docente
    {
        static public List<Entidades.Docente> RecuperarTodos()
        {
            Datos.Docente docenteData = new Datos.Docente();
            return docenteData.RecuperarTodos();
        }


        static public void Agregar(Entidades.Docente docente)
        {
            Datos.Docente docenteData = new Datos.Docente();
            docenteData.Agregar(docente);
        }

        static public Entidades.Docente RecuperarUno(string cuil)
        {
            Datos.Docente docenteData = new Datos.Docente();
            return docenteData.RecuperarUno(cuil);
        }

    }
}
