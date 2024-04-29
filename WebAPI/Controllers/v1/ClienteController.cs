using Application.Features.Clientes.Commands.CreateClienteCommand;
using Application.Features.Clientes.Commands.DeleteClienteCommand;
using Application.Features.Clientes.Commands.UpdateClienteCommand;
using Application.Features.Clientes.Queries.GetClienteById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClienteController : BaseApiController
    {
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id) {
            return Ok(await Mediator.Send(new GetClienteByIdQuery { Id = id }));
        }
        [HttpPost]
        public async Task<ActionResult> Post(CreateClienteCommand command) {
            return Ok(await Mediator.Send(command));
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, UpdateClienteCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return Ok(await Mediator.Send(command));
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteClienteCommand { Id = id }));
        }
    }
}