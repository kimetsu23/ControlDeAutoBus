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
    public class AsignacionController
    {
        private readonly IAsignacionServices _services;
        public AsignacionController(IAsignacionServices services) 
        {
            _services = services;
        }
        public void AddAll(AsignacionRequest request)
        {
            _services.AddOrUpdate(request);
        }
        public List<AsignacionResponse> GetAll()
        {
            return _services.GetAll();
        }
        public AsignacionResponse GetById(int id)
        {
            return _services.GetById(id);
        }
        public List<Choferes> GetChoferes()
        {
            return _services.GetAvailableChoferes();
        }
        public List<Choferes> GetChoferes(int asignacionId)
        {
            return _services.GetAvailableChoferes(asignacionId);
        }

        public List<Autobuses> GetAutobuses()
        {
            return _services.GetAvailableBuses();
        }

        public List<Autobuses> GetAutobuses(int asignacionId)
        {
            return _services.GetAvailableBuses(asignacionId);
        }

        public List<Ruta> GetRutas()
        {
            return _services.GetAvailableRoutes();
        }

        public List<Ruta> GetRutas(int asignacionId)
        {
            return _services.GetAvailableRoutes(asignacionId);
        }
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
