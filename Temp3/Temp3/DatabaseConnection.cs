using System;
using System.Data;
using System.Data.SqlClient;

namespace IMDB
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection ( string connectionString )
        {
            _connectionString = connectionString;
        }
        public SqlConnection OpenConnection ( )
        {
            try
            {
                SqlConnection connection = new SqlConnection (_connectionString);
                connection.Open ();
                return connection;
            }
            catch ( Exception ex )
            {
                throw new Exception ("Eroare la conectarea cu baza de date: " + ex.Message);
            }
        }
        public DataTable ExecuteQuery ( string query, SqlParameter [ ] parameters = null )
        {
            using ( SqlConnection connection = OpenConnection () )
            {
                using ( SqlCommand command = new SqlCommand (query, connection) )
                {
                    if ( parameters != null )
                    {
                        command.Parameters.AddRange (parameters);
                    }

                    using ( SqlDataAdapter adapter = new SqlDataAdapter (command) )
                    {
                        DataTable dataTable = new DataTable ();
                        adapter.Fill (dataTable);
                        return dataTable;
                    }
                }
            }
        }
        public int ExecuteNonQuery ( string query, SqlParameter [ ] parameters = null )
        {
            using ( SqlConnection connection = OpenConnection () )
            {
                using ( SqlCommand command = new SqlCommand (query, connection) )
                {
                    if ( parameters != null )
                    {
                        command.Parameters.AddRange (parameters);
                    }

                    return command.ExecuteNonQuery ();
                }
            }
        }
        public object ExecuteScalar ( string query, SqlParameter [ ] parameters = null )
        {
            using ( SqlConnection connection = OpenConnection () )
            {
                using ( SqlCommand command = new SqlCommand (query, connection) )
                {
                    if ( parameters != null )
                    {
                        command.Parameters.AddRange (parameters);
                    }

                    return command.ExecuteScalar ();
                }
            }
        }
    }
}
