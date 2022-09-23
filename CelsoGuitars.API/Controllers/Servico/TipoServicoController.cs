using CelsoGuitars.Application.Servico.DTO;
using CelsoGuitars.Application.Servico.Handler.Command;
using CelsoGuitars.Application.Servico.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CelsoGuitars.API.Controllers.Servico
{
    [Route("api/[controller]"), ApiController, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TipoServicoController : Controller
    {
        private readonly IMediator _mediator;

        public TipoServicoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllTipoServicoQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(TipoServicoInputDTO dto)
        {
            var result = await _mediator.Send(new CriarTipoServicoCommand(dto));

            return Created($"{result.TipoServico.ID}", result.TipoServico);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(TipoServicoUpdateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _mediator.Send(new AtualizarTipoServicoCommand(dto));

            return Ok(result.TipoServico);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(Guid tipoServicoID)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _mediator.Send(new RemoverTipoServicoCommand(tipoServicoID));

            return NoContent();
        }
    }
}
