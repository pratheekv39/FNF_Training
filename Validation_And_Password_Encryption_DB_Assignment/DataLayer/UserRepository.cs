using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Validation_And_Password_Encryption_DB_Assignment.Entities;

namespace Validation_And_Password_Encryption_DB_Assignment.DataLayer
{
    public class UserRepository
    {
        private string connStr = ConfigurationManager.ConnectionStrings["ConnectionConfig"].ConnectionString;

        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Users (Username, Email, PasswordHash) VALUES (@Username, @Email, @PasswordHash)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool ValidateUser(string username, string passwordHash)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Id, Username, Email FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = (int)reader["Id"],
                        Username = reader["Username"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return users;
        }
    }

}