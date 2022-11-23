using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.BLL.Interfaces
{
    public interface IFeedbacksService
    {
        Task<IEnumerable<Feedback>> GetAll();
        Task<Feedback> GetById(int id);
        Task<IEnumerable<Feedback>> Get(int rowsCount, string cacheKey);
        Task<Feedback> Create(FeedbackCreated modelCreated);
        Task<bool> Delete(int id);
        Task<bool> Update(FeedbackUpdated modelUpdatede);
    }
}
