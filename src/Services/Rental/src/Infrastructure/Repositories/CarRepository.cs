using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _cars = new(); 
        public Task<IEnumerable<Car>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Car>>(_cars);
        }

        public Task<Car> GetByIdAsync(int id)
        {
            var car = _cars.Find(c => c.Id == id);
            return Task.FromResult(car);
        }

        public Task AddAsync(Car car)
        {
            _cars.Add(car);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Car car)
        {
            var existingCar = _cars.Find(c => c.Id == car.Id);
            if (existingCar != null)
            {
                _cars.Remove(existingCar);
                _cars.Add(car);
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var car = _cars.Find(c => c.Id == id);
            if (car != null)
            {
                _cars.Remove(car);
            }
            return Task.CompletedTask;
        }
    }
}
