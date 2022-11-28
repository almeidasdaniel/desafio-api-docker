using Autofac;
using Stefanini.Application.Interfaces;
using Stefanini.Application.Service;
using Stefanini.Domain.Core.Interfaces.Repositories;
using Stefanini.Domain.Core.Interfaces.Services;
using Stefanini.Domain.Services.Services;
using Stefanini.Infra.CrossCutting.Adapter.Interfaces;
using Stefanini.Infra.CrossCutting.Adapter.Map;
using Stefanini.Infra.Repository.Repositories;

namespace Stefanini.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCidade>().As<IApplicationServiceCidade>();
            builder.RegisterType<ApplicationServicePessoa>().As<IApplicationServicePessoa>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCidade>().As<IServiceCidade>();
            builder.RegisterType<ServicePessoa>().As<IServicePessoa>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCidade>().As<IRepositoryCidade>();
            builder.RegisterType<RepositoryPessoa>().As<IRepositoryPessoa>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCidade>().As<IMapperCidade>();
            builder.RegisterType<MapperPessoa>().As<IMapperPessoa>();
            #endregion

            #endregion

        }
    }
}
