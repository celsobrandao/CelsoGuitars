using AutoMapper;
using CelsoGuitars.Application.Servico.Service.Interfaces;
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
    }
}
