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
    public class OrdersService : IOrdersService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public OrdersService(IRepositoryManager repositoryManager,
            IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Order> Create(OrderCreated modelCreated)
        {
            var entity = _mapper.Map<Order>(modelCreated);

            await _repositoryManager.OrdersRepository.Create(entity);

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _repositoryManager.OrdersRepository.GetById(id, trackChanges: false);

            if (entity == null)
            {
                return false;
            }

            await _repositoryManager.OrdersRepository.Delete(entity);

            return true;
        }

        public async Task<IEnumerable<Order>> GetAll() =>
            await _repositoryManager.OrdersRepository.GetAll(false);

        public async Task<Order> GetById(int id) =>
            await _repositoryManager.OrdersRepository.GetById(id, false);

        public async Task<bool> Update(OrderUpdated modelUpdated)
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

        public async Task<IEnumerable<Order>> Get(int rowsCount, string cacheKey) =>
            await _repositoryManager.OrdersRepository.Get(rowsCount, cacheKey);
    }
}
