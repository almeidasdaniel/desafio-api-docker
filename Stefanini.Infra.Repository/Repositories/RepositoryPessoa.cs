using Stefanini.Domain.Core.Interfaces.Repositories;
using Stefanini.Domain.Models;
using Stefanini.Infra.Data;

namespace Stefanini.Infra.Repository.Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
        private readonly SqlContext _context;
        public RepositoryPessoa(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
