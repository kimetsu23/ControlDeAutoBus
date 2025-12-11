using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Services
{
    public class BusServices
    {
        private readonly IBusRepository _BusRepository;

        public BusServices(IBusRepository busRepository)
        {
            _BusRepository = busRepository;
        }
        public void AddBus(Autobuses bus)
        {
            _BusRepository.AddAll (bus);
        }

    }
}
