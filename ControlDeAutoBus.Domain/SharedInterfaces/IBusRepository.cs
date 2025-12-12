using ControlDeAutoBus.Domain.Entities;

namespace ControlDeAutoBus.Infrastructure.Repositories
{
    public interface IBusRepository
    {
        void AddAll(Autobuses bus);
        List<Autobuses> GetAll();
        Autobuses GetById(int id);
        void Delete(int id);
        void Update(Autobuses bus);
    }
}