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
            {
                throw new ArgumentNullException(nameof(request), "El request no puede ser nulo.");
            }
            try
            {
                var bus = new Autobuses
                {
                    Brand = request.Brand,
                    Model = request.Model,
                    LicensePlate = request.LicensePlate,
                    Color = request.Color,
                    Year = request.Year
                };
                _BusRepository.AddAll(bus);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar o actualizar el autobús.", ex);
            }
        }

        public List<Autobuses> GetAllBuses()
        {
            var bus = _BusRepository.GetAll();

            return bus.Select(bus => new Autobuses
            {
                Id = bus.Id,
                Brand = bus.Brand,
                Model = bus.Model,
                LicensePlate = bus.LicensePlate,
                Color = bus.Color,
                Year = bus.Year
            }).ToList();
        }

    }
}
