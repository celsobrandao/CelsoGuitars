﻿using CelsoGuitars.Application.Usuario.DTO;
using MediatR;

namespace CelsoGuitars.Application.Usuario.Handler.Query
{
    public class GetAllUsuarioQuery : IRequest<GetAllUsuarioQueryResponse>
    {
    }

    public class GetAllUsuarioQueryResponse
    {
        public IList<UsuarioOutputDTO> Usuarios { get; set; }

        public GetAllUsuarioQueryResponse(IList<UsuarioOutputDTO> usuarios)
        {
            Usuarios = usuarios;
        }
    }
}
