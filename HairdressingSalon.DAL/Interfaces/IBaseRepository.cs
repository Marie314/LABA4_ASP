using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAllEntities(bool trackChanges);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        Task CreateEntity(T entity);
        Task CreateEntities(IEnumerable<T> entities);
        Task UpdateEntity(T entity);
        Task DeleteEntity(T entity);
    }
}
