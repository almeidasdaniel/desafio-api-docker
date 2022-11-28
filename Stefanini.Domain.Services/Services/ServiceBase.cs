using Stefanini.Application.DTO.Response;
using Stefanini.Domain.Core.Interfaces.Repositories;
using Stefanini.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> Repository)
        {
            _repository = Repository;
        }
        public virtual Task<TEntity> AddAsync(TEntity obj)
        {
            return _repository.AddAsync(obj);
        }
        public virtual Task<TEntity> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }
        public virtual Task<List<TEntity>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }
        public virtual Task<TEntity> UpdateAsync(TEntity entity)
        {
            return _repository.UpdateAsync(entity);
        }
        public virtual Task<DeleteResponse> RemoveAsync(int id)
        {
            return _repository.RemoveAsync(id);
        }
        public virtual ValueTask DisposeAsync()
        {
            return _repository.DisposeAsync();
        }
    }
}
