using Stefanini.Application.DTO.DTO;
using Stefanini.Domain.Models;
using System.Collections.Generic;

namespace Stefanini.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperPessoa
    {
        #region Mappers

        Pessoa MapperToEntity(PessoaDTO pessoaDTO);

        IEnumerable<PessoaDTO> MapperListPessoas(IEnumerable<Pessoa> pessoas);

        PessoaDTO MapperToDTO(Pessoa pessoa);

        #endregion
    }
}
