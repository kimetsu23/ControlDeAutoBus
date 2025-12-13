using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.SharedInterfaces;
using ControlDeAutoBus.Infrastructure.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Services
{
    public class AsignacionServices : IAsignacionServices
    {
        private  IAsignacionRepository _asignacionRepository;
        private readonly IChoferRepository _choferesRepository;
        private readonly IBusRepository _busRepository;
        private readonly IRouteRepository _routeRepository;
        public AsignacionServices(IAsignacionRepository asignacionRepository, IChoferRepository choferesRepository, IBusRepository busRepository, IRouteRepository routeRepository)
        {
            _asignacionRepository = asignacionRepository;
            _choferesRepository = choferesRepository;
            _busRepository = busRepository;
            _routeRepository = routeRepository;
        }

        public void AddOrUpdate(AsignacionRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            
                var existingAsignaciones = _asignacionRepository.GetAll();

                if (existingAsignaciones.Any(a =>
                     a.RouteId == request.RouteId &&
                     a.Id != request.Id))
                {
                    throw new InvalidOperationException(
                        "Ya existe una asignación con esta ruta."
                    );
                }
            
            try
            {
                var asignacionEntity = new Asignaciones
                {
                    Id = request.Id,
                    BusId = request.BusId,
                    DriverId = request.DriverId,
                    RouteId = request.RouteId,
                    DateAssignment = DateTime.UtcNow,
                    Activa = request.Activa
                };
                if (request.Id == 0)
                {
                    _asignacionRepository.AddAll(asignacionEntity);
                }
                else
                {
                    _asignacionRepository.Update(asignacionEntity);
                }
                if (asignacionEntity.Activa)
                {
                    // Actualizar chofer
                    var existingDriver = _choferesRepository.GetById(asignacionEntity.DriverId);
                    existingDriver.Activo = true;
                    _choferesRepository.Update(existingDriver);

                    // Actualizar bus
                    var existingBus = _busRepository.GetById(asignacionEntity.BusId);
                    existingBus.Activo = true;
                    _busRepository.Update(existingBus);

                    // Actualizar ruta
                    var existingRoute = _routeRepository.GetById(asignacionEntity.RouteId);
                    existingRoute.Activo = true;
                    _routeRepository.Update(existingRoute);
                }

            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new InvalidOperationException(
                    "El nombre de usuario ya existe."
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar o actualizar la asignación.", ex);
            }

        }

        public List<AsignacionResponse> GetAll()
        {
            var asignaciones = _asignacionRepository.GetAll();
            return asignaciones.Select(a => new AsignacionResponse
            {
                Id = a.Id,
                BusId = a.BusId,
                BusNombre = a.BusNombre,
                DriverId = a.DriverId,
                DriverNombre = a.DriverNombre,
                RouteId = a.RouteId,
                RutaNombre = a.RutaNombre,
                DateAssignment = a.DateAssignment,
                Activa = a.Activa
            }).ToList();
        }

        public AsignacionResponse GetById(int id)
        {
            var asignacion = _asignacionRepository.GetById(id);
            return new AsignacionResponse
            {
                Id = asignacion.Id,
                BusId = asignacion.BusId,
                BusNombre = asignacion.BusNombre,
                DriverId = asignacion.DriverId,
                DriverNombre = asignacion.DriverNombre,
                RouteId = asignacion.RouteId,
                RutaNombre = asignacion.RutaNombre,
                DateAssignment = asignacion.DateAssignment,
                Activa = asignacion.Activa
            };
        }

        public List<Choferes> GetAvailableChoferes(int? asignacionId = null)
        {
            return _asignacionRepository
                .GetAvailableChoferes(asignacionId);
        }

        public List<Autobuses> GetAvailableBuses(int? asignacionId = null)
        {
            return _asignacionRepository
                .GetAvailableBuses(asignacionId);
        }
        public List<Ruta> GetAvailableRoutes(int? asignacionId = null)
        {
            return _asignacionRepository
                .GetAvailableRoutes(asignacionId);
        }
        public void Delete(int id)
        {
            var asignacion = _asignacionRepository.GetById(id);
            if (asignacion == null)
                throw new KeyNotFoundException("El usuario no existe.");
            _asignacionRepository.Delete(id);
        }
    }

}
