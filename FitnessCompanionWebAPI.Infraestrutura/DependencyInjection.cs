using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Contexto;
using FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FitnessCompanionWebAPI.Infraestrutura
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FitnessCompanionContexto>(opt =>
                    opt.UseSqlServer(configuration.GetConnectionString("FITNESS_COMPANION_DB")).EnableSensitiveDataLogging()
                  );

            AddRepositories(services);

            return services;
        }

        //TODO: pegar oq fiz de inspecao
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();

        }
    }
}