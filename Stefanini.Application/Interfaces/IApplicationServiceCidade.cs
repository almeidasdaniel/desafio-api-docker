using Stefanini.Application.DTO.DTO;
using Stefanini.Application.DTO.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Application.Interfaces
{
    public interface IApplicationServiceCidade 
    {
        Task<IEnumerable<CidadeDTO>>  GetAllAsync();
        Task<CidadeDTO> GetByIdAsync(int id);
        Task<CidadeDTO> AddAsync(CidadeDTO cidadeDTO);
        Task<CidadeDTO> UpdateAsync(CidadeDTO cidadeDTO);
        Task<DeleteResponse> RemoveAsync(int id);
        ValueTask DisposeAsync();
    }
}
