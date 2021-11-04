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
    public class DataProvider_
    {
        private string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

        private static DataProvider_ instance;
        public static DataProvider_ Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider_();
                return instance;
            }
        }
        
        public DataTable ExecuteQuery(string query,object[] para=null)
        {
            DataTable data = new DataTable();
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // if exist para --> query is stored procedure
                    // Ex: query="SP_Login @userName,@passWord"
                    // para = [username,password]
                    // otherwise it will be a normal query
                    if (para != null)
                    {
                        string[] lstPara = query.Split(
                            new char[] { ',', ' '},
                            StringSplitOptions.RemoveEmptyEntries);
                        int i = 0;
                        foreach (string item in lstPara)
                        {
                            if (item.StartsWith("@"))
                            {
                                command.Parameters.AddWithValue(item, para[i]);
                                i++;
                            }
                        }
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
        public bool ExecuteNonQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
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
