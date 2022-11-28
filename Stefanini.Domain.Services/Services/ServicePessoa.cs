using Stefanini.Domain.Core.Interfaces.Repositories;
using Stefanini.Domain.Core.Interfaces.Services;
using Stefanini.Domain.Models;

namespace Stefanini.Domain.Services.Services
{
    public class ServicePessoa : ServiceBase<Pessoa>, IServicePessoa
    {
        public readonly IRepositoryPessoa _repositoryPessoa;
        public ServicePessoa(IRepositoryPessoa repositoryPessoa)
            : base(repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }
    }
}
