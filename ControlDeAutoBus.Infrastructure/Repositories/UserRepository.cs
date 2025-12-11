using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString;

        public UserRepository(IConfiguration config)
        {
            connectionString = config.GetConnectionString("Connetion");
        }

        public void AddAll(Usuarios user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarUsuarios", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", user.Name);
                cmd.Parameters.AddWithValue("@Apellido", user.LastName);
                cmd.Parameters.AddWithValue("@Usuario", user.User);
                cmd.Parameters.AddWithValue("@Clave", user.Password);
                cmd.Parameters.AddWithValue("@RoleID", user.Rol);
                cmd.Parameters.AddWithValue("@Ano", user.CreateDate);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Usuarios> GetAll()
        {
            var users = new List<Usuarios>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuarios_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new Usuarios
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        LastName = reader.GetString(2),
                        User = reader.GetString(3),
                        Password = reader.GetString(4),
                        Rol = reader.GetInt32(5),
                        CreateDate = reader.GetDateTime(6)
                    });
                }
            }

            return users;
        }

        public Usuarios GetById(int id)
        {
            Usuarios user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuarios_GetById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new Usuarios
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        LastName = reader.GetString(2),
                        User = reader.GetString(3),
                        Password = reader.GetString(4),
                        Rol = reader.GetInt32(5),
                        CreateDate = reader.GetDateTime(6)
                    };
                }
            }

            return user;
        }

        public void Update(Usuarios user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuarios_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Nombre", user.Name);
                cmd.Parameters.AddWithValue("@Apellido", user.LastName);
                cmd.Parameters.AddWithValue("@Usuario", user.User);
                cmd.Parameters.AddWithValue("@Clave", user.Password);
                cmd.Parameters.AddWithValue("@RoleID", user.Rol);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuarios_SoftDelete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
