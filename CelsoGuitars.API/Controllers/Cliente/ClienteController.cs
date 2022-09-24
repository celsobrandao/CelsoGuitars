using CelsoGuitars.Application.Cliente.DTO;
using CelsoGuitars.Application.Cliente.Handler.Command;
using CelsoGuitars.Application.Cliente.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CelsoGuitars.API.Controllers.Cliente
{
    [Route("api/[controller]"), ApiController, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllClienteQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(ClienteInputDTO dto)
        {
            var result = await _mediator.Send(new CriarClienteCommand(dto));

            return Created($"{result.Cliente.ID}", result.Cliente);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(ClienteUpdateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _mediator.Send(new AtualizarClienteCommand(dto));

            return Ok(result.Cliente);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(Guid clienteID)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _mediator.Send(new RemoverClienteCommand(clienteID));

            return NoContent();
        }
    }
}
