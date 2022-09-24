using AutoMapper;
using CelsoGuitars.Application.Servico.DTO;
using CelsoGuitars.Application.Servico.Service.Interfaces;
using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Domain.Servico.Repository;

namespace CelsoGuitars.Application.Servico.Service
{
    public class TipoServicoService : ITipoServicoService
    {
        private readonly ITipoServicoRepository _tipoServicoRepository;
        private readonly IMapper _mapper;

        public TipoServicoService(ITipoServicoRepository tipoServicoRepository, IMapper mapper)
        {
            _tipoServicoRepository = tipoServicoRepository;
            _mapper = mapper;
        }

        public async Task<TipoServicoOutputDTO> Criar(TipoServicoInputDTO dto)
        {
            var tipoServico = _mapper.Map<TipoServico>(dto);

            tipoServico.Validar();

            await _tipoServicoRepository.Save(tipoServico);

            return _mapper.Map<TipoServicoOutputDTO>(tipoServico);
        }

        public async Task<TipoServicoOutputDTO> Atualizar(TipoServicoUpdateDTO dto)
        {
            var tipoServico = _mapper.Map<TipoServico>(dto);

            tipoServico.Validar();

            await _tipoServicoRepository.Update(tipoServico);

            return _mapper.Map<TipoServicoOutputDTO>(tipoServico);
        }

        public async Task Remover(Guid tipoServicoID)
        {
            var tipoServico = await _tipoServicoRepository.Get(tipoServicoID);

            await _tipoServicoRepository.Delete(tipoServico);
        }

        public Task<TipoServico> Obter(Guid tipoServicoID)
        {
            return _tipoServicoRepository.Get(tipoServicoID);
        }

        public async Task<List<TipoServicoOutputDTO>> ObterTodos()
        {
            var result = await _tipoServicoRepository.GetAll();

            return _mapper.Map<List<TipoServicoOutputDTO>>(result);
        }
    }
}
