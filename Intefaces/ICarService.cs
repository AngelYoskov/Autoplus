using AutoPlus.Models;

namespace AutoPlus.BL.Intefaces
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int carId);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carId);
    }
}
