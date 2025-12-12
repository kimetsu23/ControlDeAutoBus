using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public class ChoferRepository : IChoferRepository
    {
        private readonly string? _connectionString;

        public ChoferRepository()
        {
            _connectionString = Database.ConnectionString;
        }

        public void AddAll(Choferes driver)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarChofer", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", driver.Name);
                cmd.Parameters.AddWithValue("@Apellido", driver.LastName);
                cmd.Parameters.AddWithValue("@Cedula", driver.IdCard);
                cmd.Parameters.AddWithValue("@FechaNacimiento", driver.DataOfBirth);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Choferes> GetAll()
        {
            var drivers = new List<Choferes>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    drivers.Add(new Choferes
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("ChoferID")),
                        Name = reader.GetString(reader.GetOrdinal("Nombre")),
                        LastName = reader.GetString(reader.GetOrdinal("Apellido")),
                        DataOfBirth = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                        IdCard = reader.GetString(reader.GetOrdinal("Cedula"))
                    });
                }
            }

            return drivers;
        }

        public Choferes GetById(int id)
        {
            Choferes? driver = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_GetById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChoferID", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    driver = new Choferes
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("ChoferID")),
                        Name = reader.GetString(reader.GetOrdinal("Nombre")),
                        LastName = reader.GetString(reader.GetOrdinal("Apellido")),
                        DataOfBirth = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                        IdCard = reader.GetString(reader.GetOrdinal("Cedula"))
                    };
                }
            }

            return driver ?? throw new InvalidOperationException($"No se encontró un chofer con el Id {id}.");
        }

        public void Update(Choferes driver)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ChoferID", driver.Id);
                cmd.Parameters.AddWithValue("@Nombre", driver.Name);
                cmd.Parameters.AddWithValue("@Apellido", driver.LastName);
                cmd.Parameters.AddWithValue("@Cedula", driver.IdCard);
                cmd.Parameters.AddWithValue("@FechaNacimiento", driver.DataOfBirth);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_SoftDelete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChoferID", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
