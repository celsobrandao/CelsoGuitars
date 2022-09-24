using AutoMapper;
using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Application.Fornecedor.Service.Interfaces;
using CelsoGuitars.Domain.Fornecedor;
using CelsoGuitars.Domain.Fornecedor.Repository;

namespace CelsoGuitars.Application.Fornecedor.Service
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;
        private readonly IMapper _mapper;

        public MarcaService(IMarcaRepository marcaRepository,
                            IMapper mapper)
        {
            _marcaRepository = marcaRepository;
            _mapper = mapper;
        }

        public async Task<MarcaOutputDTO> Criar(MarcaInputDTO dto)
        {
            var marca = _mapper.Map<Marca>(dto);

            marca.Validar();

            await _marcaRepository.Save(marca);

            return _mapper.Map<MarcaOutputDTO>(marca);
        }

        public async Task<MarcaOutputDTO> Atualizar(MarcaUpdateDTO dto)
        {
            var marca = _mapper.Map<Marca>(dto);

            marca.Validar();

            await _marcaRepository.Update(marca);

            return _mapper.Map<MarcaOutputDTO>(marca);
        }

        public async Task Remover(Guid marcaID)
        {
            var marca = await _marcaRepository.Get(marcaID);

            await _marcaRepository.Delete(marca);
        }

        public Task<Marca> Obter(Guid marcaID)
        {
            return _marcaRepository.Get(marcaID);
        }

        public async Task<List<MarcaOutputDTO>> ObterTodos()
        {
            var result = await _marcaRepository.GetAll();

            return _mapper.Map<List<MarcaOutputDTO>>(result);
        }
    }
}
