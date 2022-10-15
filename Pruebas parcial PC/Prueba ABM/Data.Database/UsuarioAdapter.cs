using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class UsuarioAdapter
    {
        const string consKeyDefaultCnnString = "ConnStringExpress";
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
        public Usuario GetOne(int id)
        {
            Usuario user = new Usuario();
            this.OpenConnection();
            SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE id_usuario=@id", sqlConn);
            cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

            while (drUsuarios.Read())
            {
                user.idUsuario = (int)drUsuarios["id_usuario"];
                user.Nombre = (string)drUsuarios["nombre"];
                user.Apellido = (string)drUsuarios["apellido"];
            }

            drUsuarios.Close();

            this.CloseConnection();
            return user;
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            this.OpenConnection();
            SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios", sqlConn);
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

            while (drUsuarios.Read())
            {
                Usuario user = new Usuario();

                user.idUsuario = (int)drUsuarios["id_usuario"];
                user.Nombre = (string)drUsuarios["nombre"];
                user.Apellido = (string)drUsuarios["apellido"];

                usuarios.Add(user);
            }

            drUsuarios.Close();

            this.CloseConnection();
            return usuarios;
        }

        private void Insert(Usuario user)
        {
            this.OpenConnection();
            SqlCommand cmdSave = new SqlCommand("INSERT INTO usuarios(nombre,apellido, nombre_usuario, clave, habilitado) "+
                "VALUES(@nombre, @apellido, '1234', '1234', 1) select @@identity", sqlConn);
            cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = user.Nombre;
            cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = user.Apellido;
            user.idUsuario = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            this.CloseConnection();
        }

        private void Update(Usuario user)
        {
            this.OpenConnection();
            SqlCommand cmdSave = new SqlCommand("UPDATE usuarios SET nombre=@nombre, apellido=@apellido WHERE id_usuario=@id", sqlConn);
            cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = user.Nombre;
            cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = user.Apellido;
            cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = user.idUsuario;

            cmdSave.ExecuteNonQuery();
            this.CloseConnection();
        }

        private void Delete(int ID)
        {
            this.OpenConnection();
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM usuarios WHERE id_usuario=@id", sqlConn);
            cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmdDelete.ExecuteNonQuery();
            this.CloseConnection();
        }

        public void Save(Usuario user)
        {
            if(user.State == Usuario.States.New)
            {
                this.Insert(user);
            }
            else if(user.State == Usuario.States.Modified)
            {
                this.Update(user);
            }
            else if(user.State == Usuario.States.Deleted)
            {
                this.Delete(user.idUsuario);
            }
            user.State = Usuario.States.Unmodified;
        }


    }
}
