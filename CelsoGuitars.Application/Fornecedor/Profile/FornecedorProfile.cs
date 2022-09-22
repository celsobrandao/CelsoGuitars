using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Fornecedor;

namespace CelsoGuitars.Application.Fornecedor.Profile
{
    public class FornecedorProfile : AutoMapper.Profile
    {
        public FornecedorProfile()
        {
            CreateMap<Marca, MarcaOutputDTO>();
            CreateMap<MarcaInputDTO, Marca>();
            CreateMap<MarcaUpdateDTO, Marca>();
        }
    }
}
