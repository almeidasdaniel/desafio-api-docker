using Stefanini.Domain.Core.Interfaces.Repositories;
using Stefanini.Domain.Core.Interfaces.Services;
using Stefanini.Domain.Models;

namespace Stefanini.Domain.Services.Services
{
    public class ServiceCidade : ServiceBase<Cidade>, IServiceCidade
    {
        public readonly IRepositoryCidade _repositoryCidade;
        public ServiceCidade(IRepositoryCidade repositoryCidade) 
            : base(repositoryCidade) 
        {
            _repositoryCidade = repositoryCidade;
        }
    }
}
