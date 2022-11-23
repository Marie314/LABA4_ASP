using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.BLL.Interfaces
{
    public interface IServicesService
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> GetById(int id);
        Task<IEnumerable<Service>> Get(int rowsCount, string cacheKey);
        Task<Service> Create(ServiceCreated modelCreated);
        Task<bool> Delete(int id);
        Task<bool> Update(ServiceUpdated modelUpdatede);
    }
}
