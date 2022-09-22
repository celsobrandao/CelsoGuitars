using AutoMapper;
using CelsoGuitars.Application.Cliente.Service.Interfaces;
using CelsoGuitars.Domain.Cliente.Repository;

namespace CelsoGuitars.Application.Cliente.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository,
                              IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
    }
}
