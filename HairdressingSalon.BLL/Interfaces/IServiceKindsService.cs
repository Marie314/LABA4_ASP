using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.BLL.Interfaces
{
    public interface IServiceKindsService
    {
        Task<IEnumerable<ServiceKind>> GetAll();
        Task<ServiceKind> GetById(int id);
        Task<IEnumerable<ServiceKind>> Get(int rowsCount, string cacheKey);
        Task<ServiceKind> Create(ServiceKindCreated modelCreated);
        Task<bool> Delete(int id);
        Task<bool> Update(ServiceKindUpdated modelUpdatede);
    }
}
