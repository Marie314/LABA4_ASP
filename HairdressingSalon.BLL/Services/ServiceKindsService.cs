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
    public class ServiceKindsService : IServiceKindsService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ServiceKindsService(IRepositoryManager repositoryManager,
            IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<ServiceKind> Create(ServiceKindCreated modelCreated)
        {
            var entity = _mapper.Map<ServiceKind>(modelCreated);

            await _repositoryManager.ServiceKindsRepository.Create(entity);

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _repositoryManager.ServiceKindsRepository.GetById(id, trackChanges: false);

            if (entity == null)
            {
                return false;
            }

            await _repositoryManager.ServiceKindsRepository.Delete(entity);

            return true;
        }

        public async Task<IEnumerable<ServiceKind>> GetAll() =>
            await _repositoryManager.ServiceKindsRepository.GetAll(false);

        public async Task<ServiceKind> GetById(int id) =>
            await _repositoryManager.ServiceKindsRepository.GetById(id, false);

        public async Task<bool> Update(ServiceKindUpdated modelUpdated)
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

        public async Task<IEnumerable<ServiceKind>> Get(int rowsCount, string cacheKey) =>
            await _repositoryManager.ServiceKindsRepository.Get(rowsCount, cacheKey);
    }
}
