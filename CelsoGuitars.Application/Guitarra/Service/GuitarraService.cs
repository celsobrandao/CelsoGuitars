using AutoMapper;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using CelsoGuitars.Domain.Guitarra.Repository;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Infra.Storage.Interfaces;

namespace CelsoGuitars.Application.Guitarra.Service
{
    public class GuitarraService : IGuitarraService
    {
        private readonly IGuitarraRepository _guitarraRepository;
        private readonly IBracoRepository _bracoRepository;
        private readonly ICaptadorRepository _captadorRepository;
        private readonly IChaveamentoRepository _chaveamentoRepository;
        private readonly ICorpoRepository _corpoRepository;
        private readonly IMadeiraRepository _madeiraRepository;
        private readonly IPonteRepository _ponteRepository;
        private readonly ITarraxaRepository _tarraxaRepository;
        private readonly ITrasteRepository _trasteRepository;
        private readonly IMapper _mapper;
        private readonly IStorage _storage;

        public GuitarraService(IGuitarraRepository guitarraRepository,
                               IBracoRepository bracoRepository,
                               ICaptadorRepository captadorRepository,
                               IChaveamentoRepository chaveamentoRepository,
                               ICorpoRepository corpoRepository,
                               IMadeiraRepository madeiraRepository,
                               IPonteRepository ponteRepository,
                               ITarraxaRepository tarraxaRepository,
                               ITrasteRepository trasteRepository,
                               IMapper mapper,
                               IStorage storage)
        {
            _guitarraRepository = guitarraRepository;
            _bracoRepository = bracoRepository;
            _captadorRepository = captadorRepository;
            _chaveamentoRepository = chaveamentoRepository;
            _corpoRepository = corpoRepository;
            _madeiraRepository = madeiraRepository;
            _ponteRepository = ponteRepository;
            _tarraxaRepository = tarraxaRepository;
            _trasteRepository = trasteRepository;
            _mapper = mapper;
            _storage = storage;
        }
    }
}
