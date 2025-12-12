using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Services.Interface
{
    public interface IBusServices
    {
        void AddOrUpdateBus(BusRequest request);
        List<Autobuses> GetAllBuses();
        void DeleteBus(int id);
        BusReponse GetBusById(int id);
    }
}
