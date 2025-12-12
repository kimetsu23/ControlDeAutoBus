using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.SharedInterfaces;
using ControlDeAutoBus.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Domain.Services
{
    public class ChoferesServices : IChoferesServices
    {
        private readonly IChoferRepository _choferesRepository;
        public ChoferesServices(IChoferRepository choferRepository) 
        {
            _choferesRepository = choferRepository;

        }

        public void AddOrUpdateChoferes(ChoferesRequest choferes)
        {
            if (choferes == null)
                throw new ArgumentNullException(nameof(choferes), "El request no puede ser nulo.");
            try
            {
                if (choferes.Id == 0)
                {
                    var newChofer = new Entities.Choferes
                    {
                        Name = choferes.Name,
                        LastName = choferes.LastName,
                        IdCard = choferes.IdCard,
                        DataOfBirth = choferes.DataOfBirth
                    };
                    _choferesRepository.AddAll(newChofer);
                }
                else
                {
                    var existingChofer = _choferesRepository.GetById(choferes.Id);
                    existingChofer.Name = choferes.Name;
                    existingChofer.LastName = choferes.LastName;
                    existingChofer.IdCard = choferes.IdCard;
                    existingChofer.DataOfBirth = choferes.DataOfBirth;
                    _choferesRepository.Update(existingChofer);

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar o actualizar el chofer.", ex);
            }
        }

        public List<ChoferesResponse> GetAllChoferes()
        {
            var choferesList = _choferesRepository.GetAll();
            var responseList = choferesList.Select(chofer => new ChoferesResponse
            {
                Id = chofer.Id,
                Name = chofer.Name,
                LastName = chofer.LastName,
                IdCard = chofer.IdCard,
                DataOfBirth = chofer.DataOfBirth
            }).ToList();
            return responseList;
        }

        public void DeleteChoferes(int id)
        {
            var chofer = _choferesRepository.GetById(id);

            if (chofer == null)
                throw new KeyNotFoundException("El autobús no existe.");
            if (chofer.IsDeleted)
                throw new InvalidOperationException("El autobús ya está eliminado.");
            _choferesRepository.Delete(id);
        }
    }
}
