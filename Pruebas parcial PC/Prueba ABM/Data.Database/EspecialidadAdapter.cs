using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Business.Entity;

namespace Data.Database
{
    public class EspecialidadAdapter
    {
        public SqlConnection sqlConn { get; set; }

        private void OpenConnection()
        {
            sqlConn = new SqlConnection("Data Source=localhost\\SQLExpress;Initial Catalog=tp2_net;Integrated Security=true;");
            sqlConn.Open();
        }

        private void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }
        public Especialidad GetOne(int id)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("SELECT * FROM especialidades WHERE id_especialidad=@id", sqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while (drEspecialidad.Read())
                {
                    esp.idEspecialidad = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
                }
                drEspecialidad.Close();
                return esp;
            }
            catch (Exception)
            {
          
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("SELECT * FROM especialidades", sqlConn);
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while (drEspecialidad.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.idEspecialidad = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
                    especialidades.Add(esp);
                }
                drEspecialidad.Close();
                return especialidades;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        private void Insert(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidades(desc_especialidad) VALUES(@descripcion)", sqlConn);
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        private void Update(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidades SET desc_especialidad=@descripcion WHERE id_especialidad=@id", sqlConn);
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = esp.idEspecialidad;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        private void Delete(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM especialidades WHERE id_especialidad=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = esp.idEspecialidad;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad esp)
        {
            if(esp.State == Especialidad.States.New)
            {
                this.Insert(esp);
            }
            else if(esp.State == Especialidad.States.Modified)
            {
                this.Update(esp);
            }
            else if(esp.State == Especialidad.States.Deleted)
            {
                this.Delete(esp);
            }
            esp.State = Especialidad.States.Unmodified;
        }
    }
}
