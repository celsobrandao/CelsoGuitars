using AutoMapper;
using CelsoGuitars.Application.Cliente.DTO;
using CelsoGuitars.Application.Cliente.Service.Interfaces;
using CelsoGuitars.Domain.Cliente.Repository;
using CelsoGuitars.Infra.Utils;
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

            cliente.AtualizarSenha();

            await _clienteRepository.Save(cliente);

            return _mapper.Map<ClienteOutputDTO>(cliente);
        }

        public async Task<ClienteOutputDTO> Atualizar(ClienteUpdateDTO dto)
        {
            var cliente = _mapper.Map<ClienteModel>(dto);

            cliente.Validar();

            cliente.AtualizarSenha();

            await _clienteRepository.Update(cliente);

            return _mapper.Map<ClienteOutputDTO>(cliente);
        }

        public async Task Remover(Guid clienteID)
        {
            var cliente = await _clienteRepository.Get(clienteID);

            await _clienteRepository.Delete(cliente);
        }

        public async Task<ClienteLoginOutputDTO> ValidarLogin(ClienteLoginInputDTO dto)
        {
            var senha = SegurancaUtils.HashSHA1(dto.Senha);
            var id = await _clienteRepository.ValidarLogin(dto.Email, senha);
            var valido = id != Guid.Empty;
            var mensagem = id == Guid.Empty ? "Usuário ou senha inválidos." : "";

            return new ClienteLoginOutputDTO(valido, mensagem, id);
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
