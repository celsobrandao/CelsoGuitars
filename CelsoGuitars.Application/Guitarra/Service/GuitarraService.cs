using AutoMapper;
using CelsoGuitars.Application.Fornecedor.Service.Interfaces;
using CelsoGuitars.Application.Guitarra.DTO;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using CelsoGuitars.Domain.Guitarra.Repository;
using CelsoGuitars.Infra.Storage.Interfaces;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Application.Guitarra.Service
{
    public class GuitarraService : IGuitarraService
    {
        private readonly IGuitarraRepository _guitarraRepository;
        private readonly IParteService _parteService;
        private readonly IMarcaService _marcaService;
        private readonly IMapper _mapper;
        private readonly IStorage _storage;

        public GuitarraService(IGuitarraRepository guitarraRepository,
                               IParteService parteService,
                               IMarcaService marcaService,
                               IMapper mapper,
                               IStorage storage)
        {
            _guitarraRepository = guitarraRepository;
            _parteService = parteService;
            _marcaService = marcaService;
            _mapper = mapper;
            _storage = storage;
        }

        public async Task<GuitarraOutputDTO> Criar(GuitarraInputDTO dto)
        {
            var guitarra = _mapper.Map<GuitarraModel>(dto);

            guitarra.Braco = await _parteService.GetBraco(dto.BracoID);
            guitarra.Corpo = await _parteService.GetCorpo(dto.CorpoID);
            guitarra.Ponte = await _parteService.GetPonte(dto.PonteID);
            guitarra.Tarraxa = await _parteService.GetTarraxa(dto.TarraxaID);
            guitarra.Traste = await _parteService.GetTraste(dto.TrasteID);

            guitarra.Captadores = new();
            foreach (var captador in dto.CaptadoresIDs)
            {
                guitarra.Captadores.Add(await _parteService.GetCaptador(captador));
            }

            guitarra.Chaveamentos = new();
            foreach (var chaveamento in dto.ChaveamentosIDs)
            {
                guitarra.Chaveamentos.Add(await _parteService.GetChaveamento(chaveamento));
            }
            guitarra.Marca = await _marcaService.Obter(dto.MarcaID);

            guitarra.Foto = await _storage.Upload(dto.FotoUrl);

            guitarra.Validar();

            await _guitarraRepository.Save(guitarra);

            return _mapper.Map<GuitarraOutputDTO>(guitarra);
        }

        public async Task<GuitarraOutputDTO> Atualizar(GuitarraUpdateDTO dto)
        {
            var guitarra = await _guitarraRepository.GetByIDCompleto(dto.ID);

            guitarra.CodigoFabricante = dto.CodigoFabricante;
            guitarra.ConfiguracaoCaptadores = dto.ConfiguracaoCaptadores;
            guitarra.ConfiguracaoCaptadoresOutro = dto.ConfiguracaoCaptadoresOutro;
            guitarra.Descricao = dto.Descricao;
            guitarra.Nome = dto.Nome;

            guitarra.Braco = await _parteService.GetBraco(dto.BracoID);
            guitarra.Corpo = await _parteService.GetCorpo(dto.CorpoID);
            guitarra.Ponte = await _parteService.GetPonte(dto.PonteID);
            guitarra.Tarraxa = await _parteService.GetTarraxa(dto.TarraxaID);
            guitarra.Traste = await _parteService.GetTraste(dto.TrasteID);

            //Remove captadores
            for (int i = guitarra.Captadores.Count - 1; i >= 0; i--)
            {
                if (!dto.CaptadoresIDs.Contains(guitarra.Captadores[i].ID))
                {
                    guitarra.Captadores.RemoveAt(i);
                }
            }
            //Inclui captadores
            foreach (var captadorID in dto.CaptadoresIDs)
            {
                if (!guitarra.Captadores.Any(c => c.ID == captadorID))
                {
                    guitarra.Captadores.Add(await _parteService.GetCaptador(captadorID));
                }
            }

            //Remove chaveamentos
            for (int i = guitarra.Chaveamentos.Count - 1; i >= 0; i--)
            {
                if (!dto.ChaveamentosIDs.Contains(guitarra.Chaveamentos[i].ID))
                {
                    guitarra.Chaveamentos.RemoveAt(i);
                }
            }
            //Inclui chaveamentos
            foreach (var chaveamentoID in dto.ChaveamentosIDs)
            {
                if (!guitarra.Chaveamentos.Any(c => c.ID == chaveamentoID))
                {
                    guitarra.Chaveamentos.Add(await _parteService.GetChaveamento(chaveamentoID));
                }
            }

            guitarra.Marca = await _marcaService.Obter(dto.MarcaID);

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
            var result = await _guitarraRepository.GetAllCompleto();

            return _mapper.Map<List<GuitarraOutputDTO>>(result);
        }
    }
}
