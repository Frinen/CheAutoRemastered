using CheAutoRemastered.Application.Engine.Commands.CreateEngine;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    }
}
