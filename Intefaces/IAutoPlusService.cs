using AutoPlus.Models.Request;
using AutoPlus.Models.Response;

namespace AutoPlus.BL.Interfaces
{
    public interface IAutoPlusService
    {
        void AddCarToDealerInventory(AddCarToDealerInventoryRequest request);

        GetAllDealersWithCarsResponse GetAllDealersWithCars();
    }
}
