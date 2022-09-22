using AutoMapper;
using CelsoGuitars.Application.Servico.Service.Interfaces;
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
    }
}
