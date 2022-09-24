using CelsoGuitars.API.Configuration;
using CelsoGuitars.Application;
using CelsoGuitars.Domain.Cliente.Repository;
using CelsoGuitars.Domain.Fornecedor.Repository;
using CelsoGuitars.Domain.Guitarra.Repository;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Domain.Servico.Repository;
using CelsoGuitars.Domain.Usuario.Repository;
using CelsoGuitars.Infra.Repository;
using CelsoGuitars.Infra.Storage;
using CelsoGuitars.Infra.Storage.Interfaces;
using CelsoGuitars.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using CelsoGuitars.Repository.Repository.Cliente;
using CelsoGuitars.Repository.Repository.Fornecedor;
using CelsoGuitars.Repository.Repository.Guitarra;
using CelsoGuitars.Repository.Repository.Guitarra.Parte;
using CelsoGuitars.Repository.Repository.Servico;
using CelsoGuitars.Repository.Repository.Usuario;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureAuthentication(builder);

builder.Services.AddControllers();

builder.Services
    .RegisterApplication()
    .RegisterRepository(builder.Configuration.GetConnectionString("CelsoGuitars"));

builder.Services.AddDbContext<CelsoGuitarsContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("CelsoGuitars"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

#region Cliente
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
#endregion

#region Fornecedor
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
#endregion

#region Guitarra
#region Parte
builder.Services.AddScoped<IBracoRepository, BracoRepository>();
builder.Services.AddScoped<ICaptadorRepository, CaptadorRepository>();
builder.Services.AddScoped<IChaveamentoRepository, ChaveamentoRepository>();
builder.Services.AddScoped<ICorpoRepository, CorpoRepository>();
builder.Services.AddScoped<IMadeiraRepository, MadeiraRepository>();
builder.Services.AddScoped<IPonteRepository, PonteRepository>();
builder.Services.AddScoped<ITarraxaRepository, TarraxaRepository>();
builder.Services.AddScoped<ITrasteRepository, TrasteRepository>();
#endregion
builder.Services.AddScoped<IGuitarraRepository, GuitarraRepository>();
#endregion

#region Serviço
builder.Services.AddScoped<IOrdemServicoRepository, OrdemServicoRepository>();
builder.Services.AddScoped<ITipoServicoRepository, TipoServicoRepository>();
#endregion

#region Usuario
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
#endregion

builder.Services.AddScoped<IStorage, Storage>();
builder.Services.AddHttpClient();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwagger();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
