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
    public class Base
    {
        public SqlConnection sqlConn { get; set; }

        public void OpenConn()
        {
            sqlConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\UTN\\NET\\Parcial AD\\Parciales PC .NET 2020\\Net.DB.Docentes.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
        }

        public void CloseConn()
        {
            sqlConn.Close();
            sqlConn = null;
        }
    }
}
