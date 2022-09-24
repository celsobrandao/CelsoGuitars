using AutoMapper;
using CelsoGuitars.Application.Cliente.DTO;
using CelsoGuitars.Application.Cliente.Service.Interfaces;
using CelsoGuitars.Domain.Cliente.Repository;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;

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

        public async Task<ClienteOutputDTO> Criar(ClienteInputDTO dto)
        {
            var cliente = _mapper.Map<ClienteModel>(dto);

            cliente.Validar();

            await _clienteRepository.Save(cliente);

            return _mapper.Map<ClienteOutputDTO>(cliente);
        }

        public async Task<ClienteOutputDTO> Atualizar(ClienteUpdateDTO dto)
        {
            var cliente = _mapper.Map<ClienteModel>(dto);

            cliente.Validar();

            await _clienteRepository.Update(cliente);

            return _mapper.Map<ClienteOutputDTO>(cliente);
        }

        public async Task Remover(Guid clienteID)
        {
            var cliente = await _clienteRepository.Get(clienteID);

            await _clienteRepository.Delete(cliente);
        }

        public Task<ClienteModel> Obter(Guid clienteID)
        {
            return _clienteRepository.Get(clienteID);
        }

        public async Task<List<ClienteOutputDTO>> ObterTodos()
        {
            var result = await _clienteRepository.GetAll();

            return _mapper.Map<List<ClienteOutputDTO>>(result);
        }
    }
}
