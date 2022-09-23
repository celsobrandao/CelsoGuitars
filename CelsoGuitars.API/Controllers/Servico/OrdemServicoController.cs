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
    public class OrdemServicoController : Controller
    {
        private readonly IMediator _mediator;

        public OrdemServicoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllOrdemServicoQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(OrdemServicoInputDTO dto)
        {
            var result = await _mediator.Send(new CriarOrdemServicoCommand(dto));

            return Created($"{result.OrdemServico.ID}", result.OrdemServico);
        }

        [HttpPut, Route("Atualizar")]
        public async Task<IActionResult> Atualizar(OrdemServicoUpdateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _mediator.Send(new AtualizarOrdemServicoCommand(dto));

            return Ok(result.OrdemServico);
        }

        [HttpPut, Route("Finalizar")]
        public async Task<IActionResult> Finalizar(OrdemServicoFinalizarInputDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _mediator.Send(new FinalizarOrdemServicoCommand(dto));

            return Ok(result.OrdemServico);
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(Guid ordemServicoID)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _mediator.Send(new RemoverOrdemServicoCommand(ordemServicoID));

            return NoContent();
        }
    }
}
