using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.BLL.Interfaces
{
    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetById(int id);
        Task<IEnumerable<Order>> Get(int rowsCount, string cacheKey);
        Task<Order> Create(OrderCreated modelCreated);
        Task<bool> Delete(int id);
        Task<bool> Update(OrderUpdated modelUpdatede);
    }
}
