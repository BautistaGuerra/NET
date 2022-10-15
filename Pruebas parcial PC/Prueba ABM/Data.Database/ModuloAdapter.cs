using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entity;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Data.Database
{
    public class ModuloAdapter
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
        public Modulo GetOne(int id)
        {
            Modulo mod = new Modulo();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("SELECT * FROM modulos WHERE id_modulo=@id", sqlConn);
                cmdModulo.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                while (drModulo.Read())
                {
                    mod.idModulo = (int)drModulo["id_modulo"];
                    mod.Descripcion = (string)drModulo["desc_modulo"];
                    mod.Ejecuta = (string)drModulo["ejecuta"];
                }
                return mod;
            }
            catch (Exception)
            {

                throw;
            }
            finally { this.CloseConnection(); }
        }
        public List<Modulo> GetAll()
        {
            List<Modulo> modulos = new List<Modulo>(); 
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("SELECT * FROM modulos", sqlConn);
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                while (drModulo.Read())
                {
                    Modulo mod = new Modulo();
                    mod.idModulo = (int)drModulo["id_modulo"];
                    mod.Descripcion = (string)drModulo["desc_modulo"];
                    mod.Ejecuta = (string)drModulo["ejecuta"];
                    modulos.Add(mod);
                }
                return modulos;
            }
            catch (Exception)
            {

                throw;
            }
            finally { this.CloseConnection(); }
        }

        private void Insert(Modulo mod)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO modulos VALUES(@descripcion,@ejecuta)", sqlConn);
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar,50).Value = mod.Descripcion;
                cmdSave.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = mod.Ejecuta;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { this.CloseConnection(); }
        }

        private void Update(Modulo mod)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE modulos SET desc_modulo=@descripcion, ejecuta=@ejecuta WHERE id_modulo=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = mod.idModulo;
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = mod.Descripcion;
                cmdSave.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = mod.Ejecuta;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { this.CloseConnection(); }
        }

        private void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM modulos WHERE id_modulo=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { this.CloseConnection(); }
        }

        public void Save(Modulo mod)
        {
            if (mod.State == Modulo.States.New)
            {
                this.Insert(mod);
            }
            else if (mod.State == Modulo.States.Modified)
            {
                this.Update(mod);
            }
            else if(mod.State == Modulo.States.Deleted)
            {
                this.Delete(mod.idModulo);
            }
            mod.State = Modulo.States.Unmodified;
        }

    }
}
