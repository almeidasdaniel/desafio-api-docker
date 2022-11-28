using Stefanini.Application.DTO.DTO;
using Stefanini.Application.DTO.Response;
using Stefanini.Application.Interfaces;
using Stefanini.Domain.Core.Interfaces.Services;
using Stefanini.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stefanini.Application.Service
{
    public class ApplicationServiceCidade : IApplicationServiceCidade
    {
        private readonly IServiceCidade _serviceCidade;
        private readonly IMapperCidade _mapperCidade;
        public ApplicationServiceCidade(IServiceCidade serviceCidade, IMapperCidade mapperCidade)
        {
            _serviceCidade = serviceCidade;
            _mapperCidade = mapperCidade;
        }
        public async Task<CidadeDTO> AddAsync(CidadeDTO cidadeDTO)
        {
            var objCidade = _mapperCidade.MapperToEntity(cidadeDTO);
            await _serviceCidade.AddAsync(objCidade);

            return cidadeDTO;
        }
        public async Task<IEnumerable<CidadeDTO>>GetAllAsync()
        {
            var objCidades = await _serviceCidade.GetAllAsync();
            return _mapperCidade.MapperListCidades(objCidades);
        }
        public async Task<CidadeDTO> GetByIdAsync(int id)
        {
            var objCidade = await _serviceCidade.GetByIdAsync(id);
            return _mapperCidade.MapperToDTO(objCidade);
        }
        public async Task<DeleteResponse> RemoveAsync(int id)
        {
            return await _serviceCidade.RemoveAsync(id);
        }

        public async Task<CidadeDTO> UpdateAsync(CidadeDTO cidadeDTO)
        {
            var objCidade = _mapperCidade.MapperToEntity(cidadeDTO);
            await _serviceCidade.UpdateAsync(objCidade);
            return cidadeDTO;
        }

        public async ValueTask DisposeAsync()
        {
            await _serviceCidade.DisposeAsync();
        }
    }
}
