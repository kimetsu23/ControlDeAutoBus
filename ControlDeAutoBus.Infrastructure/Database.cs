using ControlDeAutoBus.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Infrastructure
{
    public class Database
    {
        public static string connetionString;
        static Database()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();
            connetionString = config.GetConnectionString("Connetion");
        }

        SqlConnection connection = new SqlConnection(connetionString);

        public void AddBus(Autobuses bus)
        {
            SqlCommand cmd = new SqlCommand("RegistrarAutobus", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Marca", bus.Brand);
            cmd.Parameters.AddWithValue("@Modelo", bus.Model);
            cmd.Parameters.AddWithValue("@Placa", bus.LicensePlate);
            cmd.Parameters.AddWithValue("@Color", bus.Color);
            cmd.Parameters.AddWithValue("@Ano", bus.Year);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("execcion del progrma", ex);
            }
            finally
            {
                connection.Close();

            }
        }
        public void AddRoute(Ruta route)
        {
            SqlCommand cmd = new SqlCommand("RegistrarRuta", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreRuta", route.NameRoute);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("execcion del progrma", ex);
            }
            finally
            {
                connection.Close();

            }
        }
        public void AddDriver(Choferes Driver)
        {
            SqlCommand cmd = new SqlCommand("RegistrarChofer", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UsuarioID", Driver.UserId);
            cmd.Parameters.AddWithValue("@Nombre", Driver.Name);
            cmd.Parameters.AddWithValue("@Apellido", Driver.LastName);
            cmd.Parameters.AddWithValue("@Cedula", Driver.IdCard);
            cmd.Parameters.AddWithValue("@FechaNacimiento", Driver.DataOfBirth);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("execcion del progrma", ex);
            }
            finally
            {
                connection.Close();

            }
        }
        public void Adduser(Usuarios user)
        {
            SqlCommand cmd = new SqlCommand("RegistrarUsuarios", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", user.Name);
            cmd.Parameters.AddWithValue("@Apellido", user.LastName);
            cmd.Parameters.AddWithValue("@Usuario", user.User);
            cmd.Parameters.AddWithValue("@Clave", user.Password);
            cmd.Parameters.AddWithValue("@RoleID", user.Rol);
            cmd.Parameters.AddWithValue("@Ano", user.CreateDate);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("execcion del progrma", ex);
            }
            finally
            {
                connection.Close();

            }
        }

    }
}
