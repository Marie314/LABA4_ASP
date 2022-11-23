using AutoMapper;
using HairdressingSalon.BLL.Interfaces;
using HairdressingSalon.DAL.DTO;
using HairdressingSalon.DAL.Interfaces;
using HairdressingSalon.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.BLL.Services
{
    public class FeedbacksService : IFeedbacksService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public FeedbacksService(IRepositoryManager repositoryManager,
            IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Feedback> Create(FeedbackCreated modelCreated)
        {
            var entity = _mapper.Map<Feedback>(modelCreated);

            await _repositoryManager.FeedbacksRepository.Create(entity);

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _repositoryManager.FeedbacksRepository.GetById(id, trackChanges: false);

            if (entity == null)
            {
                return false;
            }

            await _repositoryManager.FeedbacksRepository.Delete(entity);

            return true;
        }

        public async Task<IEnumerable<Feedback>> GetAll() =>
            await _repositoryManager.FeedbacksRepository.GetAll(false);

        public async Task<Feedback> GetById(int id) =>
            await _repositoryManager.FeedbacksRepository.GetById(id, false);

        public async Task<bool> Update(FeedbackUpdated modelUpdated)
        {
            var entity = await _repositoryManager.OrdersRepository.GetById(modelUpdated.Id, trackChanges: true);

            if (entity == null)
            {
                return false;
            }

            _mapper.Map(modelUpdated, entity);

            await _repositoryManager.OrdersRepository.Update(entity);

            return true;
        }

        public async Task<IEnumerable<Feedback>> Get(int rowsCount, string cacheKey) =>
            await _repositoryManager.FeedbacksRepository.Get(rowsCount, cacheKey);
    }
}
