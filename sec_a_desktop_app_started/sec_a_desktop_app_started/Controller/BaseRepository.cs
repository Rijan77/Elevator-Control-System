using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sec_a_desktop_app_started.Controller
{
    public abstract class BaseRepository
    {
        private readonly string _connectionString;

        protected BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Method to get a connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Method to execute a non-query command (like INSERT, UPDATE, DELETE)
        protected void ExecuteNonQuery(string query, Action<SqlCommand> parameterize)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Allow the caller to add parameters
                    parameterize(command);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        // Method to execute a scalar command (like COUNT, SUM, etc.)
        protected object ExecuteScalar(string query, Action<SqlCommand> parameterize)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    parameterize(command);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    return result;
                }
            }
        }

        // Method to execute a query that returns a data reader
        protected SqlDataReader ExecuteReader(string query, Action<SqlCommand> parameterize)
        {
            SqlConnection connection = GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                parameterize(command);
                connection.Open();

                return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection); // Auto-closes connection when done
            }
        }
    }

}
