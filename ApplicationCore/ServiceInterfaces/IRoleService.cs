using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IRoleService
    {
        Task<List<RoleModel>> GetAllRoles();
    }
}