using CelsoGuitars.Domain.Cliente.Repository;
using CelsoGuitars.Domain.Fornecedor.Repository;
using CelsoGuitars.Domain.Guitarra.Repository;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Domain.Servico.Repository;
using CelsoGuitars.Domain.Usuario.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using CelsoGuitars.Repository.Repository.Cliente;
using CelsoGuitars.Repository.Repository.Fornecedor;
using CelsoGuitars.Repository.Repository.Guitarra;
using CelsoGuitars.Repository.Repository.Guitarra.Parte;
using CelsoGuitars.Repository.Repository.Servico;
using CelsoGuitars.Repository.Repository.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CelsoGuitars.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CelsoGuitarsContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));

            #region Cliente
            services.AddScoped<IClienteRepository, ClienteRepository>();
            #endregion

            #region Fornecedor
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            #endregion

            #region Guitarra
            services.AddScoped<IGuitarraRepository, GuitarraRepository>();
            #region Parte
            services.AddScoped<IBracoRepository, BracoRepository>();
            services.AddScoped<ICaptadorRepository, CaptadorRepository>();
            services.AddScoped<IChaveamentoRepository, ChaveamentoRepository>();
            services.AddScoped<ICorpoRepository, CorpoRepository>();
            services.AddScoped<IMadeiraRepository, MadeiraRepository>();
            services.AddScoped<IPonteRepository, PonteRepository>();
            services.AddScoped<ITarraxaRepository, TarraxaRepository>();
            services.AddScoped<ITrasteRepository, TrasteRepository>();
            #endregion
            #endregion

            #region Serviço
            services.AddScoped<IOrdemServicoRepository, OrdemServicoRepository>();
            services.AddScoped<ITipoServicoRepository, TipoServicoRepository>();
            #endregion

            #region Usuário
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            #endregion

            return services;
        }
    }
}
