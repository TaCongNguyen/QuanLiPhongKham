using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        // Suitable for query, stored procedure that will return value
        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable data = new DataTable();
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // if exist para --> query is stored procedure
                    // else it will be a normal query
                    if (parameters.Length > 0)
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Detail: " + ex.StackTrace);
            }

            return data;
        }

        //ExecuteNonQuery is basically used for operations where there is
        //nothing returned from the SQL Query or Stored Procedure.
        //Preferred use will be for INSERT, UPDATE and DELETE Operations.
        public bool ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameters.Length >0)
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);
                    }
                    int msgCode= command.ExecuteNonQuery();
                    connection.Close();
                    return msgCode >-1;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Detail: " + ex.StackTrace);
                return false;
            }
            
        }
    }
}
