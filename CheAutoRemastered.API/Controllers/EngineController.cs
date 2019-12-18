using System;
using CheAutoRemastered.Application.Engine.Commands.CreateEngine;
using CheAutoRemastered.Application.Engine.Commands.Delete;
using CheAutoRemastered.Application.Engine.Commands.Get;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CheAutoRemastered.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]

    public class EngineController : ControllerBase
    {
        private IMediator _mediator;

        public EngineController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult CreateEngine([FromBody] EngineCreateCommand command)
        {
            _mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetEngines()
        {
            var command = new GetEngineAction();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult DeleteEngines(Guid id)
        {
            _mediator.Send(new DeleteEngineCommand(){Id = id});
            return Ok();
        }
    }
}
