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
    public class Base
    {
        public SqlConnection sqlConn;

        public void OpenConn()
        {
            sqlConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C: \\UTN\\NET\\Parcial AD\\Parciales PC.NET 2020\\Net.DB.Alumno.mdf\"; Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
        }

        public void CloseConn()
        {
            sqlConn.Close();
            sqlConn = null;
        }





    }
}
