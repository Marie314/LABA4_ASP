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
    public class WorkersService : IWorkersService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public WorkersService(IRepositoryManager repositoryManager,
            IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Worker> Create(WorkerCreated modelCreated)
        {
            var entity = _mapper.Map<Worker>(modelCreated);

            await _repositoryManager.WorkersRepository.Create(entity);

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _repositoryManager.WorkersRepository.GetById(id, trackChanges: false);

            if (entity == null)
            {
                return false;
            }

            await _repositoryManager.WorkersRepository.Delete(entity);

            return true;
        }

        public async Task<IEnumerable<Worker>> GetAll() =>
            await _repositoryManager.WorkersRepository.GetAll(false);

        public async Task<Worker> GetById(int id) =>
            await _repositoryManager.WorkersRepository.GetById(id, false);

        public async Task<bool> Update(WorkerUpdated modelUpdated)
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

        public async Task<IEnumerable<Worker>> Get(int rowsCount, string cacheKey) =>
            await _repositoryManager.WorkersRepository.Get(rowsCount, cacheKey);
    }
}
