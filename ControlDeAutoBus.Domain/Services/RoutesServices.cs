using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.SharedInterfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Services
{
    public class RoutesServices : IRoutesServices
    {
        private readonly IRouteRepository _routeRepository;
        public RoutesServices(IRouteRepository routeRepository ) 
        {
            _routeRepository = routeRepository;
        }

        public void AddOrUpdate(RutasRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request), "El request no puede ser nulo.");
            if (request.Id == 0)
            {
                var existingUsers = _routeRepository.GetAll();
                if (existingUsers.Any(u => u.NameRoute.Equals(request.NameRoute, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new InvalidOperationException("Ya existe un usuario con el mismo nombre de usuario.");
                }
            }
            try
            {
                if (request.Id == 0)
                {
                    var newRoute = new Ruta
                    {
                        NameRoute = request.NameRoute,
                        IsDeleted = false
                    };
                    _routeRepository.AddAll(newRoute);
                    return;
                }
                var existingRoute = _routeRepository.GetById(request.Id);
                if (existingRoute.IsDeleted)
                    existingRoute.IsDeleted = false;
                existingRoute.NameRoute = request.NameRoute;
                _routeRepository.Update(existingRoute);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new InvalidOperationException(
                    "El nombre de ruta ya existe."
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar o actualizar la ruta.", ex);
            }
        }

        public List<Ruta> GetAllRoutes()
        {
            try
            {
                return _routeRepository.GetAll().Where(r => !r.IsDeleted).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las rutas.", ex);
            }
        }
        public RutasResponse GetRouteById(int id)
        {
            try
            {
                var route = _routeRepository.GetById(id);

                if (route == null || route.IsDeleted)
                    throw new Exception("La ruta no existe o ha sido eliminada.");

                return new RutasResponse
                {
                    Id = route.Id,
                    NameRoute = route.NameRoute
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la ruta por ID.", ex);
            }
        }
        public void DeleteRoute(int id)
        {
            try
            {
                var existingRoute = _routeRepository.GetById(id);
                if (existingRoute == null || existingRoute.IsDeleted)
                    throw new Exception("La ruta no existe o ya ha sido eliminada.");
                existingRoute.IsDeleted = true;
                _routeRepository.Update(existingRoute);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la ruta.", ex);
            }
        }
    }
}
