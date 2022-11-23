using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.Interfaces
{
    public interface IClientsRepository
    {
        Task<IEnumerable<Client>> GetAll(bool trackChanges);
        Task<Client> GetById(int id, bool trackChanges);
        Task<IEnumerable<Client>> Get(int rowsCount, string cacheKey);
        Task Create(Client model);
        Task Create(IEnumerable<Client> models);
        Task Delete(Client model);
        Task Update(Client model);
    }
}
