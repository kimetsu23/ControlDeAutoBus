using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;

namespace ControlDeAutoBus.Domain.Services.Interface
{
    public interface IChoferesServices
    {
        void AddOrUpdateChoferes(ChoferesRequest choferes);
        List<ChoferesResponse> GetAllChoferes();
        void DeleteChoferes(int id);

    }
}