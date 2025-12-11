using ControlDeAutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.SharedInterfaces
{
    public interface IRouteRepository
    {
        void AddAll(Ruta route);
        List<Ruta> GetAll();
        Ruta GetById(int id);
        void Update(Ruta route);
        void Delete(int id);
    }
}
