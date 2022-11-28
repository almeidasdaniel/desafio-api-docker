using Stefanini.Application.DTO.Common;
using Stefanini.Application.DTO.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task <List<TEntity>> GetAllAsync();
        Task<DeleteResponse> RemoveAsync(int id);
        Task<TEntity> UpdateAsync(TEntity entity);
        ValueTask DisposeAsync();
    }
}
