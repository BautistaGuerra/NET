using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guerra.Entidades;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Guerra.Datos
{
    public class Alumno: Base
    {

        public List<Entidades.Alumno> RecuperarTodos()
        {
            List<Entidades.Alumno> alumnos = new List<Entidades.Alumno>();
            try
            {
                OpenConn();
                SqlCommand cmdAlumno = new SqlCommand("SELECT * FROM Alumnos", sqlConn);
                SqlDataReader drAlumno = cmdAlumno.ExecuteReader();
                while (drAlumno.Read())
                {
                    Entidades.Alumno alumno = new Entidades.Alumno();
                    alumno.ApellidoNombre = (string)drAlumno["ApellildoNombre"];
                    alumno.Dni = (string)drAlumno["Dni"];
                    alumno.Email = (string)drAlumno["Email"];
                    alumno.FechaNacimiento = (DateTime)drAlumno["FechaNacimiento"];
                    alumno.NotaPromedio = (decimal)drAlumno["NotaPromedio"];

                    alumnos.Add(alumno);
                }

                CloseConn();
                return alumnos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Agregar(Entidades.Alumno alumno)
        {
            try
            {
                OpenConn();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO Alumnos VALUES(@apellido_nombre, @dni, @email, @fecha_nacimiento, @nota_promedio)", sqlConn);
                cmdSave.Parameters.Add("@apellido_nombre", SqlDbType.VarChar, 50).Value = alumno.ApellidoNombre;
                cmdSave.Parameters.Add("@dni", SqlDbType.VarChar, 50).Value = alumno.Dni;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = alumno.Email;
                cmdSave.Parameters.Add("@fecha_nacimiento", SqlDbType.DateTime).Value = DateTime.Today;
                cmdSave.Parameters.Add("@nota_promedio", SqlDbType.Decimal).Value = alumno.NotaPromedio;
                cmdSave.ExecuteNonQuery();

                CloseConn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Entidades.Alumno RecuperarUno(string dni)
        {
            try
            {
                List<Entidades.Alumno> alumnos = this.RecuperarTodos();
                var alum = from alumno in alumnos
                                        where alumno.Dni == dni
                                        select alumno;
                return alum.First();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
