using AutoMapper;
using CelsoGuitars.Application.Cliente.Service.Interfaces;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using CelsoGuitars.Application.Servico.DTO;
using CelsoGuitars.Application.Servico.Service.Interfaces;
using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Domain.Servico.Repository;

namespace CelsoGuitars.Application.Servico.Service
{
    public class OrdemServicoService : IOrdemServicoService
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;
        private readonly IClienteService _clienteService;
        private readonly IGuitarraService _guitarraService;
        private readonly ITipoServicoService _tipoServicoService;
        private readonly IMapper _mapper;

        public OrdemServicoService(IOrdemServicoRepository ordemServicoRepository,
                                   IClienteService clienteService,
                                   IGuitarraService guitarraService,
                                   ITipoServicoService tipoServicoService,
                                   IMapper mapper)
        {
            _ordemServicoRepository = ordemServicoRepository;
            _clienteService = clienteService;
            _guitarraService = guitarraService;
            _tipoServicoService = tipoServicoService;
            _mapper = mapper;
        }

        public async Task<OrdemServicoOutputDTO> Criar(OrdemServicoInputDTO dto)
        {
            var ordemServico = _mapper.Map<OrdemServico>(dto);

            ordemServico.Cliente = await _clienteService.Obter(dto.ClienteID);
            ordemServico.Guitarra = await _guitarraService.Obter(dto.GuitarraID);

            ordemServico.TiposServicos = new();
            foreach (var tipoServico in dto.TiposServicosIDs)
            {
                ordemServico.TiposServicos.Add(await _tipoServicoService.Obter(tipoServico));
            }

            ordemServico.Calcular();

            ordemServico.Validar();

            await _ordemServicoRepository.Save(ordemServico);

            return _mapper.Map<OrdemServicoOutputDTO>(ordemServico);
        }

        public async Task<OrdemServicoOutputDTO> Atualizar(OrdemServicoUpdateDTO dto)
        {
            var ordemServico = await _ordemServicoRepository.GetByIDCompleto(dto.ID);

            ordemServico.DataEntrada = dto.DataEntrada;
            ordemServico.DataInicioServico = dto.DataInicioServico;
            ordemServico.PercentualDesconto = dto.PercentualDesconto;
            ordemServico.Observacoes = dto.Observacoes;

            ordemServico.Cliente = await _clienteService.Obter(dto.ClienteID);
            ordemServico.Guitarra = await _guitarraService.Obter(dto.GuitarraID);

            //Remove tipos de serviços
            for (int i = ordemServico.TiposServicos.Count - 1; i >= 0; i--)
            {
                if (!dto.TiposServicosIDs.Contains(ordemServico.TiposServicos[i].ID))
                {
                    ordemServico.TiposServicos.RemoveAt(i);
                }
            }
            //Inclui tipos de serviços
            foreach (var tipoServicoID in dto.TiposServicosIDs)
            {
                if (!ordemServico.TiposServicos.Any(ts => ts.ID == tipoServicoID))
                {
                    ordemServico.TiposServicos.Add(await _tipoServicoService.Obter(tipoServicoID));
                }
            }

            ordemServico.Calcular();

            ordemServico.Validar();

            await _ordemServicoRepository.Update(ordemServico);

            return _mapper.Map<OrdemServicoOutputDTO>(ordemServico);
        }

        public async Task<List<OrdemServicoOutputDTO>> ObterPorCliente(Guid clienteID)
        {
            var ordensServicos = await _ordemServicoRepository.GetCompletoByCliente(clienteID);

            return _mapper.Map<List<OrdemServicoOutputDTO>>(ordensServicos);
        }

        public async Task<OrdemServicoOutputDTO> Finalizar(OrdemServicoFinalizarInputDTO dto)
        {
            var ordemServico = await _ordemServicoRepository.Get(dto.ID);

            ordemServico.DataSaidaEfetiva = dto.DataSaidaEfetiva;
            ordemServico.ValorEfetivo = dto.ValorEfetivo;
            ordemServico.Observacoes = String.IsNullOrEmpty(ordemServico.Observacoes) ? dto.ObservacoesComplementares : ordemServico.Observacoes + Environment.NewLine + dto.ObservacoesComplementares;

            ordemServico.ValidarFinalizacao();

            await _ordemServicoRepository.Update(ordemServico);

            return _mapper.Map<OrdemServicoOutputDTO>(ordemServico);
        }

        public async Task Remover(Guid ordemServicoID)
        {
            var ordemServico = await _ordemServicoRepository.Get(ordemServicoID);

            await _ordemServicoRepository.Delete(ordemServico);
        }

        public async Task<List<OrdemServicoOutputDTO>> ObterTodos()
        {
            var result = await _ordemServicoRepository.GetAll();

            return _mapper.Map<List<OrdemServicoOutputDTO>>(result);
        }
    }
}
