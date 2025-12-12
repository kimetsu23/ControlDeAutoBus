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
    public class RutasController
    {
       private  readonly IRoutesServices _routesServices;
        public RutasController(IRoutesServices routesServices) 
        {
            _routesServices = routesServices;
        }
        public void AddOrUpdateRoute(RutasRequest request)
        {
            _routesServices.AddOrUpdate(request);
        }

        public List<Ruta> GetAllRoutes()
        {
            return _routesServices.GetAllRoutes();
        }

        public RutasResponse GetRouteById(int id)
        {
            return _routesServices.GetRouteById(id);
        }
        public void DeleteRoute(int id)
        {
            _routesServices.DeleteRoute(id);
        }
    }
}
