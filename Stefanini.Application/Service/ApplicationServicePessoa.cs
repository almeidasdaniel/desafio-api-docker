using Stefanini.Application.DTO.DTO;
using Stefanini.Application.DTO.Response;
using Stefanini.Application.Interfaces;
using Stefanini.Domain.Core.Interfaces.Services;
using Stefanini.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Application.Service
{
    public class ApplicationServicePessoa : IApplicationServicePessoa
    {
        private readonly IServicePessoa _servicePessoa;
        private readonly IMapperPessoa _mapperPessoa;

        public ApplicationServicePessoa(IServicePessoa servicePessoa, IMapperPessoa mapperPessoa)
        {
            _servicePessoa = servicePessoa;
            _mapperPessoa = mapperPessoa;
        }

        public async Task<PessoaDTO> AddAsync(PessoaDTO pessoaDTO)
        {
            var objPessoa = _mapperPessoa.MapperToEntity(pessoaDTO);
            await _servicePessoa.AddAsync(objPessoa);

            return pessoaDTO;
        }
        public async Task<IEnumerable<PessoaDTO>> GetAllAsync()
        {
            var objPessoas = await _servicePessoa.GetAllAsync();
            return _mapperPessoa.MapperListPessoas(objPessoas);
        }
        public async Task<PessoaDTO> GetByIdAsync(int id)
        {
            var objPessoa = await _servicePessoa.GetByIdAsync(id);
            return _mapperPessoa.MapperToDTO(objPessoa);
        }
        public async Task<DeleteResponse> RemoveAsync(int id)
        {
            return await _servicePessoa.RemoveAsync(id);            
        }

        public async Task<PessoaDTO> UpdateAsync(PessoaDTO pessoaDTO)
        {
            var objPessoa = _mapperPessoa.MapperToEntity(pessoaDTO);
            await _servicePessoa.UpdateAsync(objPessoa);
            return pessoaDTO;
        }

        public async ValueTask DisposeAsync()
        {
            await _servicePessoa.DisposeAsync();
        }
    }
}
