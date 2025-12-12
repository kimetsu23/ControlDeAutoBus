using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeAutoBus;
using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.Response;

namespace ControlDeAutoBus.Domain.Services
{
    public class BusServices : IBusServices
    {
        private readonly IBusRepository _BusRepository;

        public BusServices(IBusRepository busRepository)
        {
            _BusRepository = busRepository;
        }
        public void AddOrUpdateBus(BusRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request), "El request no puede ser nulo.");

            try
            {
                if (request.Id == 0)
                {
                    var newBus = new Autobuses
                    {
                        Brand = request.Brand,
                        Model = request.Model,
                        LicensePlate = request.LicensePlate,
                        Color = request.Color,
                        Year = request.Year,
                        IsDeleted = false
                    };

                    _BusRepository.AddAll(newBus);
                    return;
                }

                var existingBus = _BusRepository.GetById(request.Id);

                if (existingBus.IsDeleted)
                    existingBus.IsDeleted = false;

                existingBus.Brand = request.Brand;
                existingBus.Model = request.Model;
                existingBus.LicensePlate = request.LicensePlate;
                existingBus.Color = request.Color;
                existingBus.Year = request.Year;

                _BusRepository.Update(existingBus);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar o actualizar el autobús.", ex);
            }
        }

        public List<Autobuses> GetAllBuses()
        {
            var buses = _BusRepository.GetAll();

            return buses
                .Where(b => !b.IsDeleted)
                .Select(bus => new Autobuses
                {
                    Id = bus.Id,
                    Brand = bus.Brand,
                    Model = bus.Model,
                    LicensePlate = bus.LicensePlate,
                    Color = bus.Color,
                    Year = bus.Year,
                    IsDeleted = bus.IsDeleted
                }).ToList();
        }

        public BusReponse GetBusById(int id)
        {
            var bus = _BusRepository.GetById(id);

            if (bus == null || bus.IsDeleted)
                throw new KeyNotFoundException("El autobús no existe.");

            return new BusReponse
            {
                Id = bus.Id,
                Brand = bus.Brand,
                Model = bus.Model,
                LicensePlate = bus.LicensePlate,
                Color = bus.Color,
                Year = bus.Year
            };
        }

        public void DeleteBus(int id)
        {
            var bus = _BusRepository.GetById(id);

            if (bus == null)
                throw new KeyNotFoundException("El autobús no existe.");
            if (bus.IsDeleted)
                throw new InvalidOperationException("El autobús ya está eliminado.");
            _BusRepository.Delete(id);
        }

    }
}
