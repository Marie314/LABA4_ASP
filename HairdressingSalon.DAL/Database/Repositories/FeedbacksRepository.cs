using HairdressingSalon.DAL.Interfaces;
using HairdressingSalon.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.Database.Repositories
{
    public class FeedbacksRepository : BaseRepository<Feedback>, IFeedbacksRepository
    {
        private readonly IMemoryCache _memoryCache;

        public FeedbacksRepository(ApplicationDbContext dbContext, IMemoryCache memoryCache)
            : base(dbContext)
        {
            _memoryCache = memoryCache;
        }

        public async Task Create(Feedback model) =>
            await CreateEntity(model);

        public async Task Create(IEnumerable<Feedback> models) =>
            await CreateEntities(models);

        public async Task Delete(Feedback model) =>
            await DeleteEntity(model);

        public async Task<IEnumerable<Feedback>> GetAll(bool trackChanges) =>
            await GetAllEntities(trackChanges).ToListAsync();

        public async Task<Feedback> GetById(int id, bool trackChanges) =>
            await GetByCondition(x => x.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task Update(Feedback model) =>
            await UpdateEntity(model);

        public async Task<IEnumerable<Feedback>> Get(int rowsCount, string cacheKey)
        {
            if (!_memoryCache.TryGetValue(cacheKey, out IEnumerable<Feedback> models))
            {
                models = await dbContext.Feedbacks.Take(rowsCount).Include(f => f.Order).ThenInclude(o => o.Client).ToListAsync();
                if (models != null)
                {
                    _memoryCache.Set(cacheKey, models,
                        new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(CachingTime)));
                }
            }
            return models;
        }
    }
}
