using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly string? _connectionString;

        public RouteRepository()
        {
            _connectionString = Database.ConnectionString;
        }

        public void AddAll(Ruta route)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarRuta", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreRuta", route.NameRoute);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Ruta> GetAll()
        {
            var routes = new List<Ruta>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Ruta_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    routes.Add(new Ruta
                    {
                        Id = reader.GetInt32(0),
                        NameRoute = reader.GetString(1)
                    });
                }
            }

            return routes;
        }

        public Ruta GetById(int id)
        {
            Ruta? route = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Ruta_GetById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RutaID", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    route = new Ruta
                    {
                        Id = reader.GetInt32(0),
                        NameRoute = reader.GetString(1)
                    };
                }
            }
            if (route == null)
                throw new InvalidOperationException($"No se encontró el autobús con Id {id}.");

            return route;
        }

        public void Update(Ruta route)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Ruta_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RutaID", route.Id);
                cmd.Parameters.AddWithValue("@NombreRuta", route.NameRoute);
                cmd.Parameters.AddWithValue("@Activo", route.Activo);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("Ruta_SoftDelete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RutaID", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
