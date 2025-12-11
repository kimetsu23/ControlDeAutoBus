using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public class ChoferRepository : IChoferRepository
    {
        private readonly string connectionString;

        public ChoferRepository(IConfiguration config)
        {
            connectionString = config.GetConnectionString("Connetion");
        }

        public void AddAll(Choferes driver)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarChofer", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioID", driver.UserId);
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    drivers.Add(new Choferes
                    {
                        Id = reader.GetInt32(0),
                        UserId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        LastName = reader.GetString(3),
                        IdCard = reader.GetString(4),
                        DataOfBirth = reader.GetDateTime(5)
                    });
                }
            }

            return drivers;
        }

        public Choferes GetById(int id)
        {
            Choferes driver = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_GetById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    driver = new Choferes
                    {
                        Id = reader.GetInt32(0),
                        UserId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        LastName = reader.GetString(3),
                        IdCard = reader.GetString(4),
                        DataOfBirth = reader.GetDateTime(5)
                    };
                }
            }

            return driver;
        }

        public void Update(Choferes driver)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", driver.Id);
                cmd.Parameters.AddWithValue("@UsuarioID", driver.UserId);
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Chofer_SoftDelete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
