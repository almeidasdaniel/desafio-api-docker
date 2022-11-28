using Microsoft.EntityFrameworkCore;
using Stefanini.Application.DTO.Response;
using Stefanini.Domain.Core.Interfaces.Repositories;
using Stefanini.Infra.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Infra.Repository.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;
        public RepositoryBase(SqlContext Context)
        {
            _context = Context;
        }
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentException("Requisição vazia!");

            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync(); 

            return entity;
        }
        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public async Task<DeleteResponse> RemoveAsync(int id)
        {
            var entity = _context.Set<TEntity>().FindAsync(id).Result;

            bool sucess = false;

            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();

                sucess = true;
            }

            return new DeleteResponse() { Success = sucess , Error = !sucess };
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
