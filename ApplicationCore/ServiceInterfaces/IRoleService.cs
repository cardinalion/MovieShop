using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IRoleService
    {
        List<RoleModel> GetAllRoles();
    }
}