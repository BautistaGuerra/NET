using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace U4.Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable dtEmpresas = new DataTable();
            dtEmpresas.Columns.Add("CustomerId", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=NORTHWIND;Integrated Security=true;";

            #region dataReader
            /*
            SqlCommand mycomando = new SqlCommand();
            mycomando.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            mycomando.Connection = myconn;

            SqlDataAdapter myadap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers",myconn);

            myconn.Open();

            SqlDataReader mydr = mycomando.ExecuteReader();
            dtEmpresas.Load(mydr);

            myconn.Close();
            */
            #endregion
            #region dataAdapter
            SqlDataAdapter myadap = new SqlDataAdapter("SELECT CustomerId, CompanyName FROM Customers", myconn);

            myconn.Open();
            myadap.Fill(dtEmpresas);
            myconn.Close();

            #endregion

            Console.WriteLine("Listado de empresas: ");
            foreach(DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string idEmpresa = rowEmpresa["CustomerId"].ToString();
                string nombreEmpresa = rowEmpresa["CompanyName"].ToString();
                Console.WriteLine($"{idEmpresa}: {nombreEmpresa}");
            }

            Console.WriteLine();
            Console.Write("Escriba el id que desea modificar: ");
            string custId = Console.ReadLine();

            DataRow[] rwEmpresas = dtEmpresas.Select("CustomerId = '" + custId +"'");
            if(rwEmpresas.Length != 1)
            {
                Console.WriteLine("Id no encontrado");
                Console.ReadLine();
                return;
            }

            DataRow rowMiEmpresa = rwEmpresas[0];
            string nombreActual = rowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine($"Nombre de la empresa: {nombreActual}");
            Console.Write("Ingrese el nuevo nombre: ");
            string nombreNuevo = Console.ReadLine();

            rowMiEmpresa.BeginEdit();
            rowMiEmpresa["CompanyName"] = nombreNuevo;
            rowMiEmpresa.EndEdit();

            SqlCommand updCommand = new SqlCommand();
            updCommand.Connection = myconn;
            updCommand.CommandText = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerId = @CustomerId";
            updCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updCommand.Parameters.Add("@CustomerId", SqlDbType.NVarChar, 5, "CustomerId");
            myadap.UpdateCommand = updCommand;
            myadap.Update(dtEmpresas);
        }
    }
}
