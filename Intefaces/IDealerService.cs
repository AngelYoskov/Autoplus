using AutoPlus.Models;

namespace AutoPlus.BL.Intefaces
{
    public interface IDealerService
    {
        List<Dealer> GetAllDealers();
        Dealer GetDealerById(int dealerId);
        void AddDealer(Dealer dealer);
        void UpdateDealer(Dealer dealer);
        void DeleteDealer(int dealerId);
    }
}
