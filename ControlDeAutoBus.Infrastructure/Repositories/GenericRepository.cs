using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Entity;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public class BusRepository : IBusRepository
    {
        private readonly string connectionString;

        public BusRepository(IConfiguration config)
        {
            connectionString = config.GetConnectionString("Connetion");
        }

        public void AddAll(Autobuses bus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarAutobus", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Marca", bus.Brand);
                cmd.Parameters.AddWithValue("@Modelo", bus.Model);
                cmd.Parameters.AddWithValue("@Placa", bus.LicensePlate);
                cmd.Parameters.AddWithValue("@Color", bus.Color);
                cmd.Parameters.AddWithValue("@Ano", bus.Year);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Autobuses> GetAll()
        {
            var buses = new List<Autobuses>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Autobus_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    buses.Add(new Autobuses
                    {
                        Id = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        LicensePlate = reader.GetString(3),
                        Color = reader.GetString(4),
                        Year = reader.GetInt32(5)
                    });
                }
            }

            return buses;
        }

        public Autobuses GetById(int id)
        {
            Autobuses bus = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Autobus_GetById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bus = new Autobuses
                    {
                        Id = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        LicensePlate = reader.GetString(3),
                        Color = reader.GetString(4),
                        Year = reader.GetInt32(5)
                    };
                }
            }

            return bus;
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Autobus_SoftDelete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Autobuses bus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Autobus_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", bus.Id);
                cmd.Parameters.AddWithValue("@Marca", bus.Brand);
                cmd.Parameters.AddWithValue("@Modelo", bus.Model);
                cmd.Parameters.AddWithValue("@Placa", bus.LicensePlate);
                cmd.Parameters.AddWithValue("@Color", bus.Color);
                cmd.Parameters.AddWithValue("@Ano", bus.Year);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

