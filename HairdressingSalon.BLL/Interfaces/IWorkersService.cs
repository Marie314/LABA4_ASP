using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.BLL.Interfaces
{
    public interface IWorkersService
    {
        Task<IEnumerable<Worker>> GetAll();
        Task<Worker> GetById(int id);
        Task<IEnumerable<Worker>> Get(int rowsCount, string cacheKey);
        Task<Worker> Create(WorkerCreated modelCreated);
        Task<bool> Delete(int id);
        Task<bool> Update(WorkerUpdated modelUpdatede);
    }
}
