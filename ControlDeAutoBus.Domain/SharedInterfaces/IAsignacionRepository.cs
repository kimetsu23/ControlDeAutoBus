using ControlDeAutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.SharedInterfaces
{
    public interface IAsignacionRepository
    {
        void AddAll(Asignaciones asignacion);
        List<Asignaciones> GetAll();
        Asignaciones GetById(int id);
        void Update(Asignaciones asignacion);
        void Delete(int id);
        List<Choferes> GetAvailableChoferes();
        List<Autobuses> GetAvailableBuses();
        List<Ruta> GetAvailableRoutes();
    }
}
