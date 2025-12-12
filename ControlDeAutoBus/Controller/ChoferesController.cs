using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Controller
{
    
    public class ChoferesController
    {
        private readonly IChoferesServices _Service;
    
        public ChoferesController(IChoferesServices service)
        {
            _Service = service;
        }
        public void AddOrUpdateChoferes(ChoferesRequest request)
        {
            _Service.AddOrUpdateChoferes(request);
        }
        public List<Domain.Response.ChoferesResponse> GetAllChoferes()
        {
            return _Service.GetAllChoferes();
        }
        public void DeleteChoferes(int id)
        {
            _Service.DeleteChoferes(id);
        }
    }
}
