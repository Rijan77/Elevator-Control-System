using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using sec_a_desktop_app_started.Model;
using sec_a_desktop_app_started.IService;

namespace sec_a_desktop_app_started.Controller
{
    public class UserRepository : BaseRepository, IRepository<User>
	{
        public UserRepository(string connectionString) : base(connectionString)
        {
        }

        

        // Get a user by ID
        public User GetById(string id)
        {
            string query = "SELECT * FROM dbo.users_1 WHERE id = @id";

            using (SqlDataReader reader = ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", id);
            }))
            {
                if (reader.Read())
                {
                    return new User
                    {
                        Id = reader["id"].ToString(),
                        Name = reader["name"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Gender = reader["gender"].ToString(),
                        Country = reader["country"].ToString(),
                    };
                }
            }
            return null;
        }

        // Get all users
        public IEnumerable<User> GetAll()
        {
            string query = "SELECT * FROM dbo.users_1";
            List<User> users = new List<User>();

            using (SqlDataReader reader = ExecuteReader(query, cmd => { }))
            {
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = reader["id"].ToString(),
                        Name = reader["name"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Gender = reader["gender"].ToString(),
                        Country = reader["country"].ToString(),
                    });
                }
            }
            return users;
        }

        // Update a user
        public void Update(User user)
        {
            string query = @"UPDATE dbo.users_1 
                         SET name = @name, 
                             phone = @phone, 
                             gender = @gender, 
                             country = @country 
                         WHERE id = @id";

            ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@country", user.Country);
                cmd.Parameters.AddWithValue("@id", user.Id);
            });
        }

        // Insert a new user
        public void Insert(User user)
        {
            string query = @"INSERT INTO dbo.users_1 (id, name, phone, gender, country) 
                         VALUES (@id, @name, @phone, @gender, @country)";

            ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@country", user.Country);
            });
        }

        // Delete a user
        public void DeleteById(string id)
        {
            string query = "DELETE FROM dbo.users_1 WHERE id = @id";

            ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", id);
            });
        }

		// Delete all
		public void DeleteAll()
		{
			string query = "Truncate Table dbo.users_1";

			ExecuteNonQuery(query, cmd =>
			{
				
			});
		}
	}

}
