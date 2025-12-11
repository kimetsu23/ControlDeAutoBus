using ControlDeAutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.SharedInterfaces
{
    public interface IUserRepository
    {
        void AddAll(Usuarios user);
        List<Usuarios> GetAll();
        Usuarios GetById(int id);
        void Update(Usuarios user);
        void Delete(int id);

    }
}
