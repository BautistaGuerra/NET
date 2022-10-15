using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Guerra.Entidades;

namespace Guerra.Datos
{
    public class Docente: Base
    {

        public List<Entidades.Docente> RecuperarTodos()
        {
            List<Entidades.Docente> docentes = new List<Entidades.Docente>();
            try
            {
                OpenConn();
                SqlCommand cmdDocente = new SqlCommand("SELECT * FROM Docentes", sqlConn);
                SqlDataReader drDocente = cmdDocente.ExecuteReader();
                while (drDocente.Read()) {
                    Entidades.Docente doc = new Entidades.Docente();
                    doc.ApellidoNombre = (string)drDocente["ApellidoNombre"];
                    doc.Id = (int)drDocente["IdDocente"];

                    doc.Cuil = (string)drDocente["Cuil"];

                    doc.Email = (string)drDocente["Email"];

                    doc.FechaIngreso = (DateTime)drDocente["FechaIngreso"];

                    doc.Salario = (decimal)drDocente["Salario"];
                    docentes.Add(doc);
                }
                CloseConn();
                return docentes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Agregar(Entidades.Docente docente)
        {
            try
            {
                OpenConn();
                SqlCommand cmdDocente = new SqlCommand("INSERT INTO Docentes VALUES(@id, @cuil, @apellido_nombre, @email, @fecha_ingreso, @salario)", sqlConn);
                cmdDocente.Parameters.Add("@id", SqlDbType.Int).Value = docente.Id;
                cmdDocente.Parameters.Add("@cuil", SqlDbType.VarChar, 50).Value = docente.Cuil;
                cmdDocente.Parameters.Add("@apellido_nombre", SqlDbType.VarChar, 50).Value = docente.ApellidoNombre;
                cmdDocente.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = docente.Email;
                cmdDocente.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = docente.FechaIngreso;
                cmdDocente.Parameters.Add("@salario", SqlDbType.Decimal).Value = docente.Salario;
                cmdDocente.ExecuteNonQuery();
                CloseConn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Entidades.Docente RecuperarUno(string cuil)
        {
            try
            {
                List<Entidades.Docente> docentes = RecuperarTodos();
                var doc = from docente in docentes where docente.Cuil == cuil select docente;
                return doc.First();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
