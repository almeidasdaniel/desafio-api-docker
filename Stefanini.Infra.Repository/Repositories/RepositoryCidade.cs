using Stefanini.Domain.Core.Interfaces.Repositories;
using Stefanini.Domain.Models;
using Stefanini.Infra.Data;

namespace Stefanini.Infra.Repository.Repositories
{
    public class RepositoryCidade : RepositoryBase<Cidade>, IRepositoryCidade
    {
        private readonly SqlContext _context;
        public RepositoryCidade(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
