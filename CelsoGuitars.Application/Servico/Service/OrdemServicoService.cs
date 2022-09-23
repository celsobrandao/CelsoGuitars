using AutoMapper;
using CelsoGuitars.Application.Servico.DTO;
using CelsoGuitars.Application.Servico.Service.Interfaces;
using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Domain.Servico.Repository;

namespace CelsoGuitars.Application.Servico.Service
{
    public class OrdemServicoService : IOrdemServicoService
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;
        private readonly IMapper _mapper;

        public OrdemServicoService(IOrdemServicoRepository ordemServicoRepository,
                                   IMapper mapper)
        {
            _ordemServicoRepository = ordemServicoRepository;
            _mapper = mapper;
        }

        public async Task<OrdemServicoOutputDTO> Criar(OrdemServicoInputDTO dto)
        {
            var ordemServico = _mapper.Map<OrdemServico>(dto);

            ordemServico.Calcular();

            ordemServico.Validar();

            await _ordemServicoRepository.Save(ordemServico);

            return _mapper.Map<OrdemServicoOutputDTO>(ordemServico);
        }

        public async Task<OrdemServicoOutputDTO> Atualizar(OrdemServicoUpdateDTO dto)
        {
            var ordemServico = _mapper.Map<OrdemServico>(dto);

            ordemServico.Calcular();

            ordemServico.Validar();

            await _ordemServicoRepository.Update(ordemServico);

            return _mapper.Map<OrdemServicoOutputDTO>(ordemServico);
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
