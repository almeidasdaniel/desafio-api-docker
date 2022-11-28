using Stefanini.Application.DTO.DTO;
using Stefanini.Application.DTO.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Application.Interfaces
{
    public interface IApplicationServicePessoa
    {
        Task<IEnumerable<PessoaDTO>> GetAllAsync();
        Task<PessoaDTO> GetByIdAsync(int id);
        Task<PessoaDTO> AddAsync(PessoaDTO pessoaDTO);
        Task<PessoaDTO> UpdateAsync(PessoaDTO pessoaDTO);
        Task<DeleteResponse> RemoveAsync(int id);
        ValueTask DisposeAsync();
    }
}
