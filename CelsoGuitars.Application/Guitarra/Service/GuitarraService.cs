using AutoMapper;
using CelsoGuitars.Application.Guitarra.DTO;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using CelsoGuitars.Domain.Guitarra.Repository;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Infra.Storage.Interfaces;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

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

        public async Task<GuitarraOutputDTO> Criar(GuitarraInputDTO dto)
        {
            var guitarra = _mapper.Map<GuitarraModel>(dto);

            guitarra.Braco = await _bracoRepository.Get(dto.BracoID);
            guitarra.Corpo = await _corpoRepository.Get(dto.CorpoID);
            guitarra.Ponte = await _ponteRepository.Get(dto.PonteID);
            guitarra.Tarraxa = await _tarraxaRepository.Get(dto.TarraxaID);
            guitarra.Traste = await _trasteRepository.Get(dto.TrasteID);

            guitarra.Captadores = new();
            foreach (var captador in dto.CaptadoresIDs)
            {
                guitarra.Captadores.Add(await _captadorRepository.Get(captador));
            }

            guitarra.Chaveamentos = new();
            foreach (var chaveamento in dto.ChaveamentoIDs)
            {
                guitarra.Chaveamentos.Add(await _chaveamentoRepository.Get(chaveamento));
            }

            guitarra.Foto = await _storage.Upload(dto.FotoUrl);

            guitarra.Validar();

            await _guitarraRepository.Save(guitarra);

            return _mapper.Map<GuitarraOutputDTO>(guitarra);
        }

        public async Task<GuitarraOutputDTO> Atualizar(GuitarraUpdateDTO dto)
        {
            var guitarra = _mapper.Map<GuitarraModel>(dto);

            guitarra.Braco = await _bracoRepository.Get(dto.BracoID);
            guitarra.Corpo = await _corpoRepository.Get(dto.CorpoID);
            guitarra.Ponte = await _ponteRepository.Get(dto.PonteID);
            guitarra.Tarraxa = await _tarraxaRepository.Get(dto.TarraxaID);
            guitarra.Traste = await _trasteRepository.Get(dto.TrasteID);

            guitarra.Captadores = new();
            foreach (var captador in dto.CaptadoresIDs)
            {
                guitarra.Captadores.Add(await _captadorRepository.Get(captador));
            }

            guitarra.Chaveamentos = new();
            foreach (var chaveamento in dto.ChaveamentoIDs)
            {
                guitarra.Chaveamentos.Add(await _chaveamentoRepository.Get(chaveamento));
            }

            guitarra.Foto = await _storage.Upload(dto.FotoUrl);

            guitarra.Validar();

            await _guitarraRepository.Update(guitarra);

            return _mapper.Map<GuitarraOutputDTO>(guitarra);
        }

        public async Task Remover(Guid guitarraID)
        {
            var guitarra = await _guitarraRepository.Get(guitarraID);

            await _guitarraRepository.Delete(guitarra);
        }

        public async Task<List<GuitarraOutputDTO>> ObterTodos()
        {
            var result = await _guitarraRepository.GetAll();

            return _mapper.Map<List<GuitarraOutputDTO>>(result);
        }
    }
}
