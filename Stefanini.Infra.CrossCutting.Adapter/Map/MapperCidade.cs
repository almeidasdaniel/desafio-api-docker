using Stefanini.Application.DTO.DTO;
using Stefanini.Domain.Models;
using Stefanini.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Stefanini.Infra.CrossCutting.Adapter.Map
{
    public class MapperCidade : IMapperCidade
    {
        List<CidadeDTO> cidadeDTOs = new List<CidadeDTO>();
        public IEnumerable<CidadeDTO> MapperListCidades(IEnumerable<Cidade> cidades)
        {
            foreach (var item in cidades)
            {
                CidadeDTO cidadeDTO = new CidadeDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    UF = item.UF
                };

                cidadeDTOs.Add(cidadeDTO);
            }

            return cidadeDTOs;
        }

        public CidadeDTO MapperToDTO(Cidade cidade)
        {
            CidadeDTO cidadeDTO = new CidadeDTO
            {
                Id = cidade.Id,
                Nome = cidade.Nome,
                UF = cidade.UF                
            };

            return cidadeDTO;
        }

        public Cidade MapperToEntity(CidadeDTO cidadeDTO)
        {
            Cidade cidade = new Cidade
            {
                Id = cidadeDTO.Id,
                Nome = cidadeDTO.Nome,
                UF = cidadeDTO.UF
            };

            return cidade;
        }
    }
}
