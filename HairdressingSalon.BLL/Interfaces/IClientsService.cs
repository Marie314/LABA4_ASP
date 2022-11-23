using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.BLL.Interfaces
{
    public interface IClientsService
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> GetById(int id);
        Task<IEnumerable<Client>> Get(int rowsCount, string cacheKey);
        Task<Client> Create(ClientCreated modelCreated);
        Task<bool> Delete(int id);
        Task<bool> Update(ClientUpdated modelUpdatede);
    }
}
