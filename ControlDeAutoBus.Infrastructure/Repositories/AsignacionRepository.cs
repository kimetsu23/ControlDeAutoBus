using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public class AsignacionRepository : IAsignacionRepository
    {
        private readonly string? _connectionString;

        public AsignacionRepository()
        {
            _connectionString = Database.ConnectionString;
        }

        public void AddAll(Asignaciones asignacion)
        {
            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("RegistrarAsignaciones", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ChoferID", asignacion.DriverId);
            cmd.Parameters.AddWithValue("@AutobusID", asignacion.BusId);
            cmd.Parameters.AddWithValue("@RutaID", asignacion.RouteId);
            cmd.Parameters.AddWithValue("@FechaAsignacion", asignacion.DateAssignment);
            cmd.Parameters.AddWithValue("@Activa", asignacion.Activa);

            connection.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Asignaciones> GetAll()
        {
            var list = new List<Asignaciones>();
            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("Asignacion_GetAll", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            connection.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Asignaciones
                {
                    Id = reader.GetInt32(0),
                    DriverId = reader.GetInt32(1), 
                    DriverNombre = reader.GetString(2),
                    BusId = reader.GetInt32(3), 
                    BusNombre = reader.GetString(4),
                    RouteId = reader.GetInt32(5),
                    RutaNombre = reader.GetString(6),
                    DateAssignment = reader.GetDateTime(7),
                    IsDeleted = reader.GetBoolean(8),
                    Activa = reader.GetBoolean(9)
                });
            }

            return list;
        }

        public Asignaciones GetById(int id)
        {
            Asignaciones? asignacion = null;
            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("Asignacion_GetById", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AsignacionID", id);

            connection.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                asignacion = new Asignaciones
                {
                    Id = reader.GetInt32(0),
                    DriverId = reader.GetInt32(1),
                    DriverNombre = reader.GetString(2),
                    BusId = reader.GetInt32(3),
                    BusNombre = reader.GetString(4),
                    RouteId = reader.GetInt32(5),
                    RutaNombre = reader.GetString(6),
                    DateAssignment = reader.GetDateTime(7),
                    IsDeleted = reader.GetBoolean(8),
                    Activa = reader.GetBoolean(9)
                };
            }

            if (asignacion == null)
                throw new InvalidOperationException($"No se encontró la asignación con Id {id}.");

            return asignacion;
        }

        public void Update(Asignaciones asignacion)
        {
            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("Asignaciones_Update", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AsignacionID", asignacion.Id);
            cmd.Parameters.AddWithValue("@ChoferID", asignacion.DriverId);
            cmd.Parameters.AddWithValue("@AutobusID", asignacion.BusId);
            cmd.Parameters.AddWithValue("@RutaID", asignacion.RouteId);
            cmd.Parameters.AddWithValue("@FechaAsignacion", asignacion.DateAssignment);
            cmd.Parameters.AddWithValue("@Activa", asignacion.Activa);

            connection.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("Asignaciones_SoftDelete", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AsignacionID", id);

            connection.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Choferes> GetAvailableChoferes(int? asignacionId = null)
        {
            var list = new List<Choferes>();

            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("GetAvailableAsignables", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (asignacionId.HasValue)
                cmd.Parameters.AddWithValue("@AsignacionId", asignacionId.Value);

            connection.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Choferes
                {
                    Id = reader.GetInt32(reader.GetOrdinal("ChoferID")),
                    Name = reader.GetString(reader.GetOrdinal("Nombre")),
                    LastName = reader.GetString(reader.GetOrdinal("Apellido"))
                });
            }

            return list;
        }

        public List<Autobuses> GetAvailableBuses(int? asignacionId = null)
        {
            var list = new List<Autobuses>();

            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("GetAvailableAsignables", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (asignacionId.HasValue)
                cmd.Parameters.AddWithValue("@AsignacionId", asignacionId.Value);

            connection.Open();
            using var reader = cmd.ExecuteReader();

            reader.NextResult();
            while (reader.Read())
            {
                list.Add(new Autobuses
                {
                    Id = reader.GetInt32(reader.GetOrdinal("AutobusID")),
                    Brand = reader.GetString(reader.GetOrdinal("Marca")),
                    Model = reader.GetString(reader.GetOrdinal("Modelo"))
                });
            }

            return list;
        }

        public List<Ruta> GetAvailableRoutes(int? asignacionId = null)
        {
            var list = new List<Ruta>();

            using var connection = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("GetAvailableAsignables", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (asignacionId.HasValue)
                cmd.Parameters.AddWithValue("@AsignacionId", asignacionId.Value);

            connection.Open();
            using var reader = cmd.ExecuteReader();

            reader.NextResult();
            reader.NextResult();
            while (reader.Read())
            {
                list.Add(new Ruta
                {
                    Id = reader.GetInt32(reader.GetOrdinal("RutaID")),
                    NameRoute = reader.GetString(reader.GetOrdinal("NombreRuta"))
                });
            }

            return list;
        }

    }
}