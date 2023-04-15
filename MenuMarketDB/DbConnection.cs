using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MenuMarketDB
{
    
    class DbConnection
    {

        static private string connections = "Host=localhost;Port=5432;Username=postgres;Password=2003;Database=postgres;";
        public NpgsqlConnection connection = new NpgsqlConnection(connections);

        public void ConOpen() 
        {

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();

            }
        
        }

        public void ConClosed() 
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {

                connection.Close();

            }
        
        }

        public NpgsqlConnection GetConnection() 
        {
        
            return connection;
        
        }
    }
}
