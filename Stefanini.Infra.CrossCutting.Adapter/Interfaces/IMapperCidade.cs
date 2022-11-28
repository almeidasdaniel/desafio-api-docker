using Stefanini.Application.DTO.DTO;
using Stefanini.Domain.Models;
using System.Collections.Generic;

namespace Stefanini.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCidade
    {
        #region Mappers

        Cidade MapperToEntity(CidadeDTO cidadeDTO);

        IEnumerable<CidadeDTO> MapperListCidades(IEnumerable<Cidade> cidades);

        CidadeDTO MapperToDTO(Cidade cidade);

        #endregion
    }
}
