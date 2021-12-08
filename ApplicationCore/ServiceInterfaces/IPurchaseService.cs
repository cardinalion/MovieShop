using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IPurchaseService
    {
        List<PurchaseModel> GetPurchasesByUserId(int userId);
    }
}
