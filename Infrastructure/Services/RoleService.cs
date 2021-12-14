using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class RoleService : IRoleService
    {
        private readonly IGenreRepository _genreRepository;
        public RoleService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<List<RoleModel>> GetAllRoles()
        {
            var roles = await _genreRepository.GetAll();
            var roleModel = new List<RoleModel>();
            foreach (var role in roles)
            {
                roleModel.Add(new RoleModel { Id = role.Id, Name = role.Name });
            }
            return roleModel;
        }
    }
}