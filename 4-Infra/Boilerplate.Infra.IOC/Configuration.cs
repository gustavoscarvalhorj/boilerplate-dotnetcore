using Boilerplate.AppServices.ApiAppService.Produtor;
using Boilerplate.AppServices.Resources.Interfaces;
using Boilerplate.Domain.Core.Interfaces.Repositories;
using Boilerplate.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Boilerplate.Infra.IOC
{
    public class Configuration
    {
        public static void Configure(IServiceCollection services)
        {
            AppServices(services);
            RepositoryServices(services);
        }

        private static void AppServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IProdutorAppService), typeof(ProdutorAppService));
        }

        private static void RepositoryServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IProdutorRepository), typeof(ProdutorRepository));
        }
    }
}
