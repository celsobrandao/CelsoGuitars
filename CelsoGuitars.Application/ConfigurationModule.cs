using CelsoGuitars.Application.Cliente.Service;
using CelsoGuitars.Application.Cliente.Service.Interfaces;
using CelsoGuitars.Application.Fornecedor.Service;
using CelsoGuitars.Application.Fornecedor.Service.Interfaces;
using CelsoGuitars.Application.Guitarra.Service;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using CelsoGuitars.Application.Servico.Service;
using CelsoGuitars.Application.Servico.Service.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CelsoGuitars.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);
            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            #region Cliente
            services.AddScoped<IClienteService, ClienteService>();
            #endregion

            #region Fornecedor
            services.AddScoped<IMarcaService, MarcaService>();
            #endregion

            #region Guitarra
            services.AddScoped<IGuitarraService, GuitarraService>();
            #endregion

            #region Serviço
            services.AddScoped<IOrdemServicoService, OrdemServicoService>();
            services.AddScoped<ITipoServicoService, TipoServicoService>();
            #endregion

            return services;
        }
    }
}
