using System;
using System.Collections.Generic;
using System.Configuration;
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
        
        


    }
}
