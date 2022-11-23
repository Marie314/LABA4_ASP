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
    public class ServicesService : IServicesService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ServicesService(IRepositoryManager repositoryManager,
            IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Service> Create(ServiceCreated modelCreated)
        {
            var entity = _mapper.Map<Service>(modelCreated);

            await _repositoryManager.ServicesRepository.Create(entity);

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _repositoryManager.ServicesRepository.GetById(id, trackChanges: false);

            if (entity == null)
            {
                return false;
            }

            await _repositoryManager.ServicesRepository.Delete(entity);

            return true;
        }

        public async Task<IEnumerable<Service>> GetAll() =>
            await _repositoryManager.ServicesRepository.GetAll(false);

        public async Task<Service> GetById(int id) =>
            await _repositoryManager.ServicesRepository.GetById(id, false);

        public async Task<bool> Update(ServiceUpdated modelUpdated)
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

        public async Task<IEnumerable<Service>> Get(int rowsCount, string cacheKey) =>
            await _repositoryManager.ServicesRepository.Get(rowsCount, cacheKey);
    }
}
