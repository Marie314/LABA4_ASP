using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.Interfaces
{
    public interface IWorkersRepository
    {
        Task<IEnumerable<Worker>> GetAll(bool trackChanges);
        Task<Worker> GetById(int id, bool trackChanges);
        Task<IEnumerable<Worker>> Get(int rowsCount, string cacheKey);
        Task Create(Worker model);
        Task Create(IEnumerable<Worker> models);
        Task Delete(Worker model);
        Task Update(Worker model);
    }
}
