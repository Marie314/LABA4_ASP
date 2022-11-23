using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.Interfaces
{
    public interface IOrdersRepository
    {
        Task<IEnumerable<Order>> GetAll(bool trackChanges);
        Task<Order> GetById(int id, bool trackChanges);
        Task<IEnumerable<Order>> Get(int rowsCount, string cacheKey);
        Task Create(Order model);
        Task Create(IEnumerable<Order> models);
        Task Delete(Order model);
        Task Update(Order model);
    }
}
