using Stefanini.Application.DTO.DTO;
using Stefanini.Domain.Models;
using Stefanini.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Stefanini.Infra.CrossCutting.Adapter.Map
{
    public class MapperPessoa : IMapperPessoa
    {
        List<PessoaDTO>  pessoaDTOs = new List<PessoaDTO>();

        public IEnumerable<PessoaDTO> MapperListPessoas(IEnumerable<Pessoa> pessoas)
        {
            foreach (var item in pessoas)
            {
                PessoaDTO pessoaDTO = new PessoaDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Cpf = item.Cpf,
                    CidadeId = item.CidadeId,
                    Idade = item.Idade
                };

                pessoaDTOs.Add(pessoaDTO);
            }

            return pessoaDTOs;
        }

        public PessoaDTO MapperToDTO(Pessoa pessoa)
        {
            PessoaDTO pessoaDTO = new PessoaDTO
            {
                Id = pessoa.Id,
                Nome = pessoa.Nome, 
                Cpf= pessoa.Cpf,
                CidadeId= pessoa.CidadeId,
                Idade= pessoa.Idade
            };

            return pessoaDTO;
        }

        public Pessoa MapperToEntity(PessoaDTO pessoaDTO)
        {
            Pessoa pessoa = new Pessoa
            {
                Id = pessoaDTO.Id,
                Nome = pessoaDTO.Nome, 
                Cpf = pessoaDTO.Cpf, 
                CidadeId= pessoaDTO.CidadeId, 
                Idade= pessoaDTO.Idade
            };

            return pessoa;
        }
    }
}
