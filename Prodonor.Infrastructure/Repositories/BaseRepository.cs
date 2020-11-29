using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Infrastructure.Repositories
{
    public class BaseRepository<TEntity, TEntityDao> : IRepository<TEntity> where TEntity : class where TEntityDao : class
    {
        protected ProdonorDbContext Db { get; }
        protected readonly IMapper Mapper;

        public BaseRepository(ProdonorDbContext db, IMapper mapper)
        {
            Db = db;
            Mapper = mapper;
        }

        protected DbSet<TEntityDao> Entities
        {
            get { return Db.Set<TEntityDao>(); }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Mapper.Map<List<TEntityDao>, List<TEntity>>(Entities.ToList());
//            return Entities.ProjectTo<TEntity>(Mapper.ConfigurationProvider).ToList();
        }

        public virtual IQueryable<TEntity> GetAllQueryable()
        {
            return Entities.ProjectTo<TEntity>(Mapper.ConfigurationProvider);
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            var entityDao = Mapper.Map<TEntity, TEntityDao>(entity);
            var addedDao = Entities.Add(entityDao);
            Db.SaveChanges();
            //toDo: investigate why doesn't work await Db.SaveChangesAsync();
            var result = Mapper.Map<TEntityDao, TEntity>(addedDao.Entity);
            return await Task.FromResult(result);
        }

        public async Task<TEntity> GetAsync(int id)
        {
            var entityDao = await GetInternalFindAsync(id);
            var result = Mapper.Map<TEntityDao, TEntity>(entityDao);
            return await Task.FromResult(result);
        }

        protected virtual Task<TEntityDao> GetInternalFindAsync(int id)
        {
            return Entities.FindAsync(id);
        }

        protected virtual TEntityDao GetInternal(int id)
        {
            return Entities.Find(id);
        }

        public TEntity Get(int id)
        {
            var entityDao = GetInternal(id);
            var result = Mapper.Map<TEntityDao, TEntity>(entityDao);
            return result;
        }

        public void Remove(int id)
        {
            var entityDao = Entities.Find(id);
            Entities.Remove(entityDao);
            Db.SaveChanges();
        }

        public async Task RemoveAsync(int id)
        {
            var entityDao = Entities.Find(id);
            Entities.Remove(entityDao);
            await Db.SaveChangesAsync();
        }

        public void RemoveRange(IEnumerable<TEntity> entitiesList)
        {
            //this.entities.RemoveRange(entitiesList);
            throw new NotSupportedException();
        }

        public virtual async Task SetModified(TEntity entity)
        {
            var entityDao = Mapper.Map<TEntity, TEntityDao>(entity);
            Db.Entry(entityDao).State = EntityState.Modified;
            await Db.SaveChangesAsync();
        }

        protected virtual async Task<TEntityDao> AddInternalAsync(TEntity entity)
        {
            var entityDao = Mapper.Map<TEntity, TEntityDao>(entity);
            var addedDao = Entities.Add(entityDao);
            await Db.SaveChangesAsync();
            return await Task.FromResult(addedDao.Entity);
        }

        protected virtual void MarkNavigationPropertiesAsChanged(TEntityDao entityDao)
        {}


        protected virtual void MarkNavigationPropertiesAsUnchanged(TEntityDao entityDao)
        {}
    }
}
