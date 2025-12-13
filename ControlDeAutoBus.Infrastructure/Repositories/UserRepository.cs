using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string? _connectionString;

        public UserRepository()
        {
            _connectionString = Database.ConnectionString;
        }

        public void AddAll(Usuarios user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarUsuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", user.Name);
                cmd.Parameters.AddWithValue("@Apellido", user.LastName);
                cmd.Parameters.AddWithValue("@Usuario", user.User);
                cmd.Parameters.AddWithValue("@Clave", user.Password);
                cmd.Parameters.AddWithValue("@RolID", user.Rol);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Usuarios> GetAll()
        {
            var users = new List<Usuarios>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuario_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new Usuarios
                    {
                        Id = reader.GetGuid(0),
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

        public Usuarios GetById(Guid id)
        {
            Usuarios? user = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuario_GetById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new Usuarios
                    {
                        Id = reader.GetGuid(0),
                        Name = reader.GetString(1),
                        LastName = reader.GetString(2),
                        User = reader.GetString(3),
                        Password = reader.GetString(4),
                        Rol = reader.GetInt32(5),
                        CreateDate = reader.GetDateTime(6)
                    };
                }
            }
            if (user == null)
                throw new InvalidOperationException($"No se encontró el autobús con Id {id}.");

            return user;
        }

        public void Update(Usuarios user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuario_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioID", user.Id);
                cmd.Parameters.AddWithValue("@Nombre", user.Name);
                cmd.Parameters.AddWithValue("@Apellido", user.LastName);
                cmd.Parameters.AddWithValue("@Usuario", user.User);
                cmd.Parameters.AddWithValue("@Clave", user.Password);
                cmd.Parameters.AddWithValue("@RolID", user.Rol);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Usuarios GetByUser(string username)
        {
            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("Usuario_GetByUser", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@User", username);

            connection.Open();

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            return new Usuarios
            {
                Id = reader.GetGuid(reader.GetOrdinal("UsuarioID")),
                Name = reader.GetString(reader.GetOrdinal("Nombre")),
                LastName = reader.GetString(reader.GetOrdinal("Apellido")),
                User = reader.GetString(reader.GetOrdinal("Usuario")),
                Password = reader.GetString(reader.GetOrdinal("Clave")),
                Rol = reader.GetInt32(reader.GetOrdinal("RolID"))
            };
        }

        public void Delete(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usuario_SoftDelete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
