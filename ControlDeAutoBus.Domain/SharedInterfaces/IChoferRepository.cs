using ControlDeAutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.SharedInterfaces
{
    public interface IChoferRepository
    {
        void AddAll(Choferes driver);
        List<Choferes> GetAll();
        Choferes GetById(int id);
        void Delete(int id);
        void Update(Choferes bus);

    }
}
