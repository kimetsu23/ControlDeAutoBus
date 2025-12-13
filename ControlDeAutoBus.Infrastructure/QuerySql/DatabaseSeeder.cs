using ControlDeAutoBus.Domain.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Infrastructure.QuerySql
{
    public class DatabaseSeeder
    {
        public static void Seed()
        {
            using var connection = new SqlConnection(Database.ConnectionString);
            connection.Open();

            SeedRoles(connection);
            SeedDefaultAdmin(connection);
        }

        private static void SeedRoles(SqlConnection connection)
        {
            string[] roles = { "Admin", "Chofer", "Usuario" };

            foreach (var rol in roles)
            {
                var checkCmd = new SqlCommand(
                    "SELECT COUNT(1) FROM Roles WHERE NombreRol = @NombreRol",
                    connection
                );
                checkCmd.Parameters.AddWithValue("@NombreRol", rol);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                    continue;

                var insertCmd = new SqlCommand(
                    "INSERT INTO Roles (NombreRol) VALUES (@NombreRol)",
                    connection
                );
                insertCmd.Parameters.AddWithValue("@NombreRol", rol);

                insertCmd.ExecuteNonQuery();
            }
        }

        private static void SeedDefaultAdmin(SqlConnection connection)
        {
            var checkCmd = new SqlCommand(
                "SELECT COUNT(1) FROM Usuarios WHERE Usuario = @Usuario",
                connection
            );
            checkCmd.Parameters.AddWithValue("@Usuario", "admin");

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
                return;

            var getRolCmd = new SqlCommand(
                "SELECT RolID FROM Roles WHERE NombreRol = 'Admin'",
                connection
            );

            int rolAdminId = (int)getRolCmd.ExecuteScalar();

            var insertCmd = new SqlCommand(@"
                INSERT INTO Usuarios
                (UsuarioID, Nombre, Apellido, Usuario, Clave, RolID)
                VALUES
                (@Id, @Nombre, @Apellido, @Usuario, @Clave, @RolID)
            ", connection);

            insertCmd.Parameters.AddWithValue("@Id", Guid.NewGuid());
            insertCmd.Parameters.AddWithValue("@Nombre", "Administrador");
            insertCmd.Parameters.AddWithValue("@Apellido", "Sistema");
            insertCmd.Parameters.AddWithValue("@Usuario", "admin");
            insertCmd.Parameters.AddWithValue("@Clave", PasswordHasher.HashPassword("Admin123"));
            insertCmd.Parameters.AddWithValue("@RolID", rolAdminId);

            insertCmd.ExecuteNonQuery();
        }
    }
}
