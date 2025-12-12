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
    public interface IRoutesServices
    {
        void AddOrUpdate(RutasRequest request);
        List<Ruta> GetAllRoutes();
        RutasResponse GetRouteById(int id);
        void DeleteRoute(int id);
    }
}
