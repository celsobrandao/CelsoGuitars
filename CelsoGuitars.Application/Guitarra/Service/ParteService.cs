using AutoMapper;
using CelsoGuitars.Application.Guitarra.DTO.Parte;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;

namespace CelsoGuitars.Application.Guitarra.Service
{
    public class ParteService : IParteService
    {
        private readonly IBracoRepository _bracoRepository;
        private readonly ICaptadorRepository _captadorRepository;
        private readonly IChaveamentoRepository _chaveamentoRepository;
        private readonly ICorpoRepository _corpoRepository;
        private readonly IMadeiraRepository _madeiraRepository;
        private readonly IPonteRepository _ponteRepository;
        private readonly ITarraxaRepository _tarraxaRepository;
        private readonly ITrasteRepository _trasteRepository;
        private readonly IMapper _mapper;

        public ParteService(IBracoRepository bracoRepository,
                            ICaptadorRepository captadorRepository,
                            IChaveamentoRepository chaveamentoRepository,
                            ICorpoRepository corpoRepository,
                            IMadeiraRepository madeiraRepository,
                            IPonteRepository ponteRepository,
                            ITarraxaRepository tarraxaRepository,
                            ITrasteRepository trasteRepository,
                            IMapper mapper)
        {
            _bracoRepository = bracoRepository;
            _captadorRepository = captadorRepository;
            _chaveamentoRepository = chaveamentoRepository;
            _corpoRepository = corpoRepository;
            _madeiraRepository = madeiraRepository;
            _ponteRepository = ponteRepository;
            _tarraxaRepository = tarraxaRepository;
            _trasteRepository = trasteRepository;
            _mapper = mapper;
        }

        public Task<Braco> GetBraco(Guid id)
        {
            return _bracoRepository.Get(id);
        }

        public Task<Captador> GetCaptador(Guid id)
        {
            return _captadorRepository.Get(id);
        }

        public Task<Chaveamento> GetChaveamento(Guid id)
        {
            return _chaveamentoRepository.Get(id);
        }

        public Task<Corpo> GetCorpo(Guid id)
        {
            return _corpoRepository.Get(id);
        }

        public Task<Madeira> GetMadeira(Guid id)
        {
            return _madeiraRepository.Get(id);
        }

        public Task<Ponte> GetPonte(Guid id)
        {
            return _ponteRepository.Get(id);
        }

        public Task<Tarraxa> GetTarraxa(Guid id)
        {
            return _tarraxaRepository.Get(id);
        }

        public Task<Traste> GetTraste(Guid id)
        {
            return _trasteRepository.Get(id);
        }

        public async Task<TodasPartesOutputDTO> ObterTodos()
        {
            var bracos = _mapper.Map<List<BracoOutputDTO>>(await _bracoRepository.GetAllCompleto());
            var captadores = _mapper.Map<List<CaptadorOutputDTO>>(await _captadorRepository.GetAllCompleto());
            var chaveamentos = _mapper.Map<List<ChaveamentoOutputDTO>>(await _chaveamentoRepository.GetAllCompleto());
            var corpos = _mapper.Map<List<CorpoOutputDTO>>(await _corpoRepository.GetAllCompleto());
            var madeiras = _mapper.Map<List<MadeiraOutputDTO>>(await _madeiraRepository.GetAllCompleto());
            var pontes = _mapper.Map<List<PonteOutputDTO>>(await _ponteRepository.GetAllCompleto());
            var tarraxas = _mapper.Map<List<TarraxaOutputDTO>>(await _tarraxaRepository.GetAllCompleto());
            var trastes = _mapper.Map<List<TrasteOutputDTO>>(await _trasteRepository.GetAllCompleto());

            return new(bracos, captadores, chaveamentos, corpos, madeiras, pontes, tarraxas, trastes);
        }
    }
}
