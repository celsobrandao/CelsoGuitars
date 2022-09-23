using CelsoGuitars.Application.Cliente.DTO;
using CelsoGuitars.Application.Cliente.Handler.Command;
using CelsoGuitars.Application.Cliente.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        [HttpPost, Route("ValidarLogin"), AllowAnonymous]
        public async Task<IActionResult> ValidarLogin([FromServices] IConfiguration configuration, ClienteLoginInputDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _mediator.Send(new ValidarLoginClienteCommand(dto));

            if (result.Cliente.Valido)
            {
                return Ok($"Bearer Token: {GenerateToken(configuration, result.Cliente.ID.Value)}");
            }
            else
            {
                return Unauthorized(result.Cliente.Mensagem);
            }
        }

        private static string GenerateToken(IConfiguration configuration, Guid id)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["TokenSecret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Name, id.ToString()),
                new Claim("role", "User")
            };

            var token = new JwtSecurityToken(
                    issuer: configuration["Issuer"],
                    audience: configuration["Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
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
