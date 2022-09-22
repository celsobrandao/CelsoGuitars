using AutoMapper;
using CelsoGuitars.Application.Fornecedor.Service.Interfaces;
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
    }
}
