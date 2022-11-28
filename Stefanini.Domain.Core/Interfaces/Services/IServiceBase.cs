using Stefanini.Application.DTO.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);        

        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int Id);

        Task<DeleteResponse> RemoveAsync(int id);

        Task<TEntity> UpdateAsync(TEntity entity);
        ValueTask DisposeAsync();
    }
}
