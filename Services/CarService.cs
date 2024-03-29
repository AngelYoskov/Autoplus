﻿using AutoPlus.BL.Intefaces;
using AutoPlus.DL.Interfaces;
using AutoPlus.Models;

namespace AutoPlus.BL.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car GetCarById(int carId)
        {
            return _carRepository.GetCarById(carId);
        }

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public void UpdateCar(Car car)
        {
            _carRepository.UpdateCar(car);
        }

        public void DeleteCar(int carId)
        {
            _carRepository.DeleteCar(carId);
        }
    }
}
