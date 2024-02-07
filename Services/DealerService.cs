using AutoPlus.BL.Intefaces;
using AutoPlus.DL.Interfaces;
using AutoPlus.Models;

namespace AutoPlus.BL.Services
{
    public class DealerService : IDealerService
    {
        private readonly IDealerRepository _dealerRepository;

        public DealerService(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public List<Dealer> GetAllDealers()
        {
            return _dealerRepository.GetAllDealers();
        }

        public Dealer GetDealerById(int dealerId)
        {
            return _dealerRepository.GetDealerById(dealerId);
        }

        public void AddDealer(Dealer dealer)
        {
            _dealerRepository.AddDealer(dealer);
        }

        public void UpdateDealer(Dealer dealer)
        {
            _dealerRepository.UpdateDealer(dealer);
        }

        public void DeleteDealer(int dealerId)
        {
            _dealerRepository.DeleteDealer(dealerId);
        }
    }
}
