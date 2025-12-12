using ControlDeAutoBus.Domain.Entities;
using ControlDeAutoBus.Domain.Helper;
using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.SharedInterfaces;

namespace ControlDeAutoBus.Domain.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public void AddOrUpdate(UsuarioRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            try
                {
                var userEntity = new Usuarios
                {
                    Id = request.Id,
                    Name = request.Name,
                    LastName = request.LastName,
                    User = request.User,
                    Password = PasswordHasher.HashPassword(request.Password),
                    Rol = request.Rol,
                    CreateDate = DateTime.Now
                };
                if (request.Id == Guid.Empty)
                {
                    _userRepository.AddAll(userEntity);
                }
                else
                {
                    _userRepository.Update(userEntity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar o actualizar el usuario.", ex);
            }
        }
        public List<UsuarioResponse> GetAll()
        {
            try
            {
                var users = _userRepository.GetAll();
                return users.Select(user => new UsuarioResponse
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    User = user.User,
                    Password = user.Password,
                    Rol = user.Rol
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de usuarios.", ex);
            }
        }
        public UsuarioResponse GetById(Guid id)
        {
            try
            {
                var user = _userRepository.GetById(id);
                if (user == null) return null;
                return new UsuarioResponse
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    User = user.User,
                    Password = user.Password,
                    Rol = user.Rol
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por ID.", ex);
            }
        }
        public void Delete(Guid id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
                throw new KeyNotFoundException("El usuario no existe.");
            _userRepository.Delete(id);
        }
    }
}
