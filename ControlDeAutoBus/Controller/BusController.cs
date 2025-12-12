using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using ControlDeAutoBus.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Controller
{
    
    public class BusController
    {
        private readonly IBusServices _Service;

        public BusController(IBusServices service)
        {
            _Service = service;
        }

        public void AddOrUpdateBus(BusRequest request)
        {
            _Service.AddOrUpdateBus(request);
        }

        public List<Autobuses> GetAllBuses()
        {
            return _Service.GetAllBuses();
        }

        public BusReponse GetBusById(int id)
        {
            return _Service.GetBusById(id);
        }

        public void DeleteBus(int id)
        {
            _Service.DeleteBus(id);
        }
    }
}
