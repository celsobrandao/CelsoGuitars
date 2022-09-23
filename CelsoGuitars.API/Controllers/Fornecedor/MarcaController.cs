using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Application.Fornecedor.Handler.Command;
using CelsoGuitars.Application.Fornecedor.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CelsoGuitars.API.Controllers.Fornecedor
{
    [Route("api/[controller]"), ApiController, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MarcaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MarcaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllMarcaQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(MarcaInputDTO dto)
        {
            var result = await _mediator.Send(new CriarMarcaCommand(dto));

            return Created($"{result.Marca.ID}", result.Marca);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(MarcaUpdateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _mediator.Send(new AtualizarMarcaCommand(dto));

            return Ok(result.Marca);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(Guid marcaID)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _mediator.Send(new RemoverMarcaCommand(marcaID));

            return NoContent();
        }
    }
}
