using CelsoGuitars.Application.Guitarra.DTO;
using CelsoGuitars.Application.Guitarra.Handler.Command;
using CelsoGuitars.Application.Guitarra.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CelsoGuitars.API.Controllers.Guitarra
{
    [Route("api/[controller]"), ApiController, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GuitarraController : Controller
    {
        private readonly IMediator _mediator;

        public GuitarraController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet, Route("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllGuitarraQuery()));
        }

        [HttpGet, Route("GetAllPartes")]
        public async Task<IActionResult> GetAllPartes()
        {
            return Ok(await _mediator.Send(new GetAllPartesQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(GuitarraInputDTO dto)
        {
            var result = await _mediator.Send(new CriarGuitarraCommand(dto));

            return Created($"{result.Guitarra.ID}", result.Guitarra);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(GuitarraUpdateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _mediator.Send(new AtualizarGuitarraCommand(dto));

            return Ok(result.Guitarra);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(Guid GuitarraID)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _mediator.Send(new RemoverGuitarraCommand(GuitarraID));

            return NoContent();
        }
    }
}
