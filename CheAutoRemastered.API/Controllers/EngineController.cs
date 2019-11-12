using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheAutoRemastered.Application.Engine.Commands.CreateEngine;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CheAutoRemastered.API.Controllers
{
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
