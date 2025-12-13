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
    public class UsuarioController
    {
        private readonly IUserServices _userServices;
        public UsuarioController(IUserServices userServices) 
        {
            _userServices = userServices;
        }

        public void AddOrUpdateUser(UsuarioRequest request)
        {
            _userServices.AddOrUpdate(request);
        }

        public List<UsuarioResponse> GetAllUsers()
        {
            return _userServices.GetAll();
        }
        public UsuarioResponse GetUserById(Guid id)
        {
            return _userServices.GetById(id);
        }
        public UsuarioResponse ValidateUser(string username, string password)
        {
            return _userServices.Authenticate(username, password);
        }
        public void DeleteUser(Guid id)
        {
            _userServices.Delete(id);
        }
    }
}
