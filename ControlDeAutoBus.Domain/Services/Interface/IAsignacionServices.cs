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
    public interface IAsignacionServices
    {
        void AddOrUpdate(AsignacionRequest request);
        List<AsignacionResponse> GetAll();
        AsignacionResponse GetById(int id);
        void Delete(int id);
        List<Choferes> GetAvailableChoferes(int? asignacionId = null);
        List<Autobuses> GetAvailableBuses(int? asignacionId = null);
        List<Ruta> GetAvailableRoutes(int? asignacionId = null);
    }
}
