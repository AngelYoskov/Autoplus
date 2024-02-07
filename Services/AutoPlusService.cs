using AutoPlus.BL.Intefaces;
using AutoPlus.BL.Interfaces;
using AutoPlus.Models;
using AutoPlus.Models.Request;
using AutoPlus.Models.Response;

namespace AutoPlus.BL.Services
{
    public class AutoPlusService : IAutoPlusService
    {
        private readonly ICarService _carService;
        private readonly IDealerService _dealerService;

        public AutoPlusService(ICarService carService, IDealerService dealerService)
        {
            _carService = carService;
            _dealerService = dealerService;
        }

        public GetAllDealersWithCarsResponse GetAllDealersWithCars()
        {
            var dealersWithCars = new List<Dealer>();
            var dealers = _dealerService.GetAllDealers();
            dealersWithCars.AddRange(dealers.Where(d => d.Cars.Count > 0));
            return new GetAllDealersWithCarsResponse
            {
                Dealers = dealersWithCars
            };
        }

        public void AddCarToDealerInventory(AddCarToDealerInventoryRequest request)
        {
            int dealerId = request.dealerId;
            var dealer = _dealerService.GetDealerById(dealerId);
            
            int carId = request.carId;
            var foundCar = _carService.GetCarById(carId);
            
            dealer.Cars.Add(foundCar);
        }
    }
}
