using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CheAutoRemastered.Application.Interfaces;
using MediatR;

namespace CheAutoRemastered.Application.Engine.Commands.CreateEngine
{
    public class EngineCreateCommand : IRequest
    {
        public string Name { get; set; }
        public int PistonsCount { get; set; }
        public double Volume { get; set; }
        public double Power { get; set; }
        public double Torque { get; set; }
    }

    public class Handler : IRequestHandler<EngineCreateCommand>
    {
        private readonly ICheAutoDbContext _context;
        public Handler(IMediator mediator, ICheAutoDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(EngineCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Models.Engine
            {
                Id = Guid.NewGuid(),
                Deleted = false,
                Name = request.Name,
                PistonsCount = request.PistonsCount,
                Volume = request.Volume,
                Power = request.Power,
                Torque = request.Torque
            };

            _context.Engines.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
