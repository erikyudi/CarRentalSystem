using System.Collections.Generic;
using System.Threading.Tasks;
using Rental.Domain.Entities;

namespace Rental.Domain.Repositories
{
    public interface ICarRepository
    {
        Task<Car?> GetByIdAsync(int id);
        Task<IEnumerable<Car>> GetAllAsync();
        Task AddAsync(Car car);
        Task UpdateAsync(Car car);
        Task DeleteAsync(int id);
    }
}
