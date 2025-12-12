using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Services.Interface
{
    public interface IUserServices
    {
        void AddOrUpdate(UsuarioRequest request);
        List<UsuarioResponse> GetAll();
        UsuarioResponse GetById(Guid id);
        void Delete(Guid id);
    }
}
